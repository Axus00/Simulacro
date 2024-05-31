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
    public class TratamientoCreateController : ControllerBase
    {
        private readonly ITratamientoRepository _tratamientoRepository;

        public TratamientoCreateController(ITratamientoRepository tratamientoRepository)
        {
            _tratamientoRepository = tratamientoRepository;
        }

        // endpoint
        [HttpPost]
        public IActionResult Create(Tratamiento tratamiento)
        {
            try
            {
                _tratamientoRepository.Add(tratamiento);
                return Ok("Se ha creado de forma exitosa");
            }
            catch
            {
                
                return Created();
            }
            
        }
    }
}