using AutomotrizApp.dominio;
using AutomotrizBack.negocio.implementaciones;
using AutomotrizBack.negocio.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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


        [HttpPost("crear")]
        public IActionResult PostCrearProducto(Producto oProducto)
        {
            try
            {
                if (oProducto == null)
                    return BadRequest("Objeto Producto requerido");
                else
                    return Ok(app.CrearProducto(oProducto));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "No se pudo registrar correctamente.");
            }
        }


        [HttpGet("reporte/listado")]
        public IActionResult GetReporteProductosListado()
        {

            try
            {
                string JSONresult;
                JSONresult = JsonConvert.SerializeObject(app.ObtenerReporteProductosListado());
                
                
                return Ok(JSONresult);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno. Intente nuevamente");
            }

        }

        [HttpPut("actualizar")]
        public IActionResult PutActualizarProducto(Producto oProducto)
        {
            try
            {
                if (oProducto == null)
                    return BadRequest("Objeto Pedido requerido");
                else
                    return Ok(app.ActualizarProducto(oProducto));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "No se pudo actualizar correctamente.");
            }
        }

        [HttpDelete("eliminar")]
        public IActionResult DeleteProducto(int id)                         
        {
            try
            {
                if (id == 0)
                    return BadRequest("Id es requerido");
                else
                    return Ok(app.BorrarProducto(id));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "No se pudo eliminar correctamente.");
            }
        }





    }
}
