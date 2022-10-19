using AutomotrizApp.dominio;
using AutomotrizBack.negocio.implementaciones;
using AutomotrizBack.negocio.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutomotrizWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Controller : ControllerBase
    {
        private IAplicacion app;

        Controller()
        {
            app = new Aplicacion();
        }

        [HttpGet("productos")]
        public IActionResult GetProductos()
        {
            return Ok(app.ObtenerProductos());
        }

        [HttpPost]
        public IActionResult PostPedido(Pedido oPedido)
        {
            if (oPedido == null)            
                return BadRequest();
            
            if (app.CrearPedido(oPedido))                
                return Ok("Ok");   
            
            else
                return Ok("Not Ok");

        }

    }
}
