using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prueba.Services;

namespace Prueba.Controllers._pacientes
{
    [ApiController]
    [Route("api/[controller]")]
    public class PacienteDeleteController : ControllerBase
    {
        private readonly IPacienteRepository _pacienteRepository;

        public PacienteDeleteController(IPacienteRepository pacienteRepository)
        {
            _pacienteRepository = pacienteRepository;
        }

        //endpoint
        [HttpDelete("{id}")]
        public IActionResult DeletePaciente(int id)
        {
            _pacienteRepository.Remove(id);
            return Ok();
        }
    }
}