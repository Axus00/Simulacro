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
    public class PacienteCreateController : ControllerBase
    {
        private readonly IPacienteRepository _pacienteRepository;

        public PacienteCreateController(IPacienteRepository pacienteRepository)
        {
            _pacienteRepository = pacienteRepository;
        }

        //endpoint
        [HttpPost]
        public IActionResult Create(Paciente paciente)
        {
            _pacienteRepository.Add(paciente);
            return Ok("Se ha creado de forma exitosa");
        }
    }
}