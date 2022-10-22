using AutomotrizApp.dominio;
using AutomotrizBack.negocio.implementaciones;
using AutomotrizBack.negocio.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutomotrizWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private IAplicacion app;

        public PedidoController()
        {
            app = new Aplicacion();
        }

        [HttpGet("productos")]
        public IActionResult GetProductos()
        {
            try
            {
                return Ok(app.ObtenerProductos());
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno. Intente nuevamente");
            }

        }

        [HttpPost("pedidos")]
        public IActionResult PostPedido(Pedido oPedido)
        {
            try
            {
                if (oPedido == null)
                    return BadRequest();
                else
                    return Ok(app.CrearPedido(oPedido));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "No se pudo registrar correctamente.");
            };

        }
    }
}
