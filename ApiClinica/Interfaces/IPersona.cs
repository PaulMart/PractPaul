using System.Collections.Generic;
using Modelo;

namespace Interfaces
{
    public interface IPersona
    {
        IEnumerable<Persona> ListarPersona();
        bool InsertarPersona(Persona data);
    }
}
