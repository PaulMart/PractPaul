using System;
using System.Collections.Generic;
using System.Data;
using Interfaces;
using Modelo;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace Datos
{
    public class DPersona : IPersona
    {
        private string database;
        public DPersona(IConfiguration config)
        {
            database = config["Database:CNX"];
        }

        public IEnumerable<Persona> ListarPersona()
        {
            using (SqlConnection sql = new SqlConnection(database))
            {
                using (SqlCommand cmd = new SqlCommand("sp_listar_personas", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    sql.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Persona personas = new Persona();
                            personas.id_persona = (int)reader["id_persona"];
                            personas.nombre = (string)reader["nombre"];
                            personas.apellido = (string)reader["apellido"];
                            personas.dni = (string)reader["dni"];
                            personas.fecha_nacimiento = (DateTime)reader["fecha_nacimiento"];
                            personas.fecha_registro = (DateTime)reader["fecha_registro"];
                            yield return personas;
                        }
                    }
                }
            }
        }

        public bool InsertarPersona(Persona persona)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(database))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_registrar_persona", sql))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Nombre", persona.nombre));
                        cmd.Parameters.Add(new SqlParameter("@Apellido", persona.apellido));
                        cmd.Parameters.Add(new SqlParameter("@Dni", persona.dni));
                        cmd.Parameters.Add(new SqlParameter("@FechaNacimiento", (DateTime)persona.fecha_nacimiento));
                        cmd.Parameters.Add(new SqlParameter("@FechaRegistro", DateTime.Now));
                        sql.Open();
                        cmd.ExecuteNonQuery();

                        var codreg = 1;
                        return Convert.ToBoolean(codreg);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }
    }
}
