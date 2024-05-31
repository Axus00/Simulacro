using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prueba.Services;

namespace Prueba.Controllers.__citas
{
    [ApiController]
    [Route("api/[controller]")]
    public class EspecialidadDeleteController : ControllerBase
    {
        private readonly IEspecialidadRepository _especialidadRepository;

        public EspecialidadDeleteController(IEspecialidadRepository especialidadRepository)
        {
            _especialidadRepository = especialidadRepository;
        }

        // endpoint
        [HttpDelete("{id}")]
        public IActionResult DeleteEspecialidad(int id)
        {
            try
            {
                _especialidadRepository.Remove(id);
                return Ok("Se ha eliminado de forma correcta");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error: {ex.Message}");
            }
            
        }
    }
}