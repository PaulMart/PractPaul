using System;
using System.Runtime.Serialization;

namespace Modelo
{
    public class Persona
    {
        [DataMember]
        public int id_persona { get; set; }
        public string nombre { get; set; } = "";
        [DataMember]
        public string apellido { get; set; } = "";
        [DataMember]
        public string dni { get; set; } = "";
        [DataMember]
        public DateTime fecha_nacimiento { get; set; }
        [DataMember]
        public DateTime fecha_registro { get; set; }
    }
}
