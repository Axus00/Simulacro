using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prueba.Models;
using Prueba.Services;

namespace Prueba.Controllers.__citas
{
    [ApiController]
    [Route("api/[controller]")]
    public class CitaCreateController : ControllerBase
    {
        private readonly ICitaRepository _citaRepository;

        public CitaCreateController(ICitaRepository citaRepository)
        {
            _citaRepository = citaRepository;
        }

        //endpoint
        [HttpPost]
        public IActionResult Create([FromBody] Cita cita)
        {
            try
            {
                _citaRepository.Add(cita);
                return Ok("La cita ha sido creada de forma exitosa");
            }
            catch
            {
                return BadRequest("No ha sido posible crear la cita");
            }
            
        }
    }
}