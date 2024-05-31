using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prueba.Models;
using Prueba.Services;

namespace Prueba.Controllers._pacientes
{
    [ApiController]
    [Route("api/[controller]")]
    public class PacienteUpdateController : ControllerBase
    {
        private readonly IPacienteRepository _pacienteRepository;

        public PacienteUpdateController(IPacienteRepository pacienteRepository)
        {
            _pacienteRepository = pacienteRepository;
        }

        //endpoint
        [HttpPut("{id}")]
        public IActionResult PacienteUpdate(int id, Paciente paciente)
        {
            _pacienteRepository.Update(id, paciente);
            return Ok("Se ha actualizó de forma exitosa");
        }
    }
}