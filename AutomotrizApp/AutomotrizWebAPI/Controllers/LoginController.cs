using AutomotrizBack.datos;
using AutomotrizBack.negocio.implementaciones;
using AutomotrizBack.negocio.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutomotrizWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IAplicacion app;

        public LoginController()
        {
            app = new Aplicacion();
        }

        [HttpPost("ingresar")]
        public IActionResult PostLogin(List<Parametro> credenciales)
        {
            try
            {
                return Ok(app.Login(credenciales));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno: "+ex.Message+". Intente nuevamente");
            }

        }
    }
}
