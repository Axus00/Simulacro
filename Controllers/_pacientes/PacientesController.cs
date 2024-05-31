using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prueba.Dto;
using Prueba.Services;

namespace Prueba.Controllers._pacientes
{
    [ApiController]
    [Route("api/[controller]")]
    public class PacientesController : ControllerBase
    {
        private readonly IPacienteRepository _pacienteRepository;

        public PacientesController(IPacienteRepository pacienteRepository)
        {
            _pacienteRepository = pacienteRepository;
        }

        //endpoint
        [HttpGet]
        public IEnumerable<PacienteDto> Get()
        {
            return _pacienteRepository.GetPacientes();
        }

        [HttpGet("{id}")]
        public PacienteDto PacienteById(int id)
        {
            if(!ModelState.IsValid)
            {
                NotFound("El paciente no ha sido encontrado");
            }

            return _pacienteRepository.PacienteById(id);
        }
    }
}