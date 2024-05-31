using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prueba.Models;
using Prueba.Services;

namespace Prueba.Controllers._tratamientos
{
    [ApiController]
    [Route("api/[controller]")]
    public class TratamientoUpdateController : ControllerBase
    {
        private readonly ITratamientoRepository _tratamientoRepository;

        public TratamientoUpdateController(ITratamientoRepository tratamientoRepository)
        {
            _tratamientoRepository = tratamientoRepository;
        }

        //endpoint
        [HttpPut("{id}")]
        public IActionResult TratamientoUpdate(int id, Tratamiento tratamiento)
        {
            try
            {
                _tratamientoRepository.Update(id, tratamiento);
                return Ok("Se ha actualizado de forma correcta.");
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"Error: {ex.Message}");
            }
            
        }
    }
}