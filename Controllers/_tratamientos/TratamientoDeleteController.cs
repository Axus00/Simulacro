using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prueba.Services;

namespace Prueba.Controllers._tratamientos
{
    [ApiController]
    [Route("api/[controller]")]
    public class TratamientoDeleteController : ControllerBase
    {
        private readonly ITratamientoRepository _tratamientoRepository;

        public TratamientoDeleteController(ITratamientoRepository tratamientoRepository)
        {
            _tratamientoRepository = tratamientoRepository;
        }

        //endpoint
        [HttpDelete("{id}")]
        public IActionResult DeleteTratamiento(int id)
        {
            try
            {
                _tratamientoRepository.Remove(id);
                return Ok("Se ha eliminado el tratamiento");
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"Error: {ex.Message}");
            }
            finally 
            {
                NoContent();
            }

        }
    }
}