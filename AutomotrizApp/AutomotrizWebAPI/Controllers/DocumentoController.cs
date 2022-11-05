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
    public class DocumentoController : ControllerBase
    {
        private IAplicacion app;

        public DocumentoController()
        {
            app = new Aplicacion();
        }
               
        [HttpGet("consultar")]
        public IActionResult GetDocumentos(DateTime desde, DateTime hasta, string cliente)
        {
            try
            {
                return Ok(app.ObtenerDocumentosPorFiltro(desde,hasta,cliente));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno. Intente nuevamente");
            }

        }

        [HttpPost("crear")]
        public IActionResult PostDocumento(Documento oPedido)
        {
            try
            {
                if (oPedido == null)
                    return BadRequest("Objeto Pedido requerido");
                else
                    return Ok(app.CrearDocumento(oPedido));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "No se pudo registrar correctamente.");
            }
        }

        [HttpDelete("eliminar")]
        public IActionResult DeleteDocumento(int id)
        {
            try
            {
                if (id == 0)
                    return BadRequest("Id es requerido");
                else
                    return Ok(app.BorrarDocumento(id));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "No se pudo eliminar correctamente.");
            }
        }
    }
}
