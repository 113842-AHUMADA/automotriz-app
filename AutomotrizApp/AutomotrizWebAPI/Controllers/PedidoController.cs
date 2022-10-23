using AutomotrizApp.dominio;
using AutomotrizBack.negocio.implementaciones;
using AutomotrizBack.negocio.interfaces;
using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel;
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

        [HttpGet("consultar")]
        public IActionResult GetPedidos(DateTime desde, DateTime hasta, string cliente)
        {
            try
            {
                return Ok(app.ObtenerPedidosPorFiltro(desde,hasta,cliente));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno. Intente nuevamente");
            }

        }

        [HttpPost("crear")]
        public IActionResult PostPedido(Pedido oPedido)
        {
            try
            {
                if (oPedido == null)
                    return BadRequest("Objeto Pedido requerido");
                else
                    return Ok(app.CrearPedido(oPedido));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "No se pudo registrar correctamente.");
            }
        }

        [HttpDelete("eliminar")]
        public IActionResult DeletePedido(int id)
        {
            try
            {
                if (id == 0)
                    return BadRequest("Id es requerido");
                else
                    return Ok(app.BorrarPedido(id));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "No se pudo eliminar correctamente.");
            }
        }
    }
}
