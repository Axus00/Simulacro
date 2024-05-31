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
    public class CitaUpdateController : ControllerBase
    {
        private readonly ICitaRepository _citaRepository;

        public CitaUpdateController(ICitaRepository citaRepository)
        {
            _citaRepository = citaRepository;
        }

        //endpoint
        [HttpPut("{id}")]
        public IActionResult CitaUpdate(int id, [FromBody] Cita cita)
        {
            _citaRepository.Update(id, cita);
            return Ok("Se ha creado de forma correcta");
        }
    }
}