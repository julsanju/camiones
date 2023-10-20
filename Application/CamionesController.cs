
using Microsoft.AspNetCore.Mvc;
using Domain;
using Domain.ICamiones;
using Microsoft.Identity.Client;

namespace Application
{
    public class CamionesController : ControllerBase
    {
        

        private readonly ICamiones _camion;

        public CamionesController(ICamiones camion)
        {
            _camion = camion;
        }
        //peticion para insertar productos
        [HttpPost]
        [Route("api/camiones/insertar")]
        public async Task<IActionResult> Post([FromBody] Camion c)
        {
            try
            {
                if (c == null)
                {
                     string mensajeError = "El objeto de productos es nulo.";
                    
                    return BadRequest(mensajeError);
                }


                await _camion.Agregar_Camiones(c);


                string mensaje = "registro exitoso";
                return Ok(mensaje);
            }
            catch (Exception ex)
            {
                // Maneja la excepción de acuerdo a tus necesidades
                return StatusCode(500, $"Ocurrió un error al insertar el producto: {ex.Message}");
            }
        }
    }
}
