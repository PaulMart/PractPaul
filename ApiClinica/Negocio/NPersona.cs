using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using Interfaces;
using Datos;
using Modelo;

namespace Negocio
{
    public class NPersona : IDisposable
    {
        readonly IConfiguration _configuration;
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        public NPersona(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IEnumerable<Persona> ListarPersona()
        {
            IPersona instancia = new DPersona(_configuration);
            return instancia.ListarPersona();
        }

        public bool InsertarPersona(Persona data)
        {
            {
                IPersona instancia = new DPersona(_configuration);
                return instancia.InsertarPersona(data);
            }
        }
    }
}
