using AutomotrizBack.negocio.implementaciones;
using AutomotrizBack.negocio.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutomotrizWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private IAplicacion app;

        public ProductoController()
        {
            app = new Aplicacion();
        }

        [HttpGet("consultar")]
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


        //

        [HttpGet("reporte")]
        public IActionResult GetReporteProductosListado()
        {

            try
            {
                return Ok(app.ObtenerReporteProductosListado());
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno. Intente nuevamente");
            }

        }
    }
}
