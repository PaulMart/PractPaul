using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using Negocio;
using Modelo;

namespace ApiClinica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : Controller
    {
        readonly IConfiguration _configuration;

        public PersonaController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [AllowAnonymous]
        [HttpGet("ListarPersona")]
        public IActionResult ListarPersonas()
        {
            try
            {
                using (NPersona instancia = new NPersona(_configuration))
                {
                    var sd = instancia.ListarPersona();

                    return Ok(sd);
                }
            }
            catch (Exception ex)
            {

            }
            return null;
        }


        [AllowAnonymous]
        [HttpPost("InsertarPersona")]
        public IActionResult InsertarPersona([FromBody] Persona _Persona)
        {
            try
            {
                using (NPersona instancia = new NPersona(_configuration))
                {
                    bool resul = instancia.InsertarPersona(_Persona);
                    return Ok(resul);
                }
            }
            catch (Exception ex)
            {

            }
            return null;
        }
    }
}
