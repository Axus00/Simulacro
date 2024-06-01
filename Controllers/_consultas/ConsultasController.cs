using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prueba.Models;
using Prueba.Services._consultas;

namespace Prueba.Controllers._consultas
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConsultasController : ControllerBase
    {
        private readonly IConsultasRespository _consultasRespository;
        public ConsultasController(IConsultasRespository consultasRespository)
        {
            _consultasRespository = consultasRespository;
        }

        //endpoint
        [HttpGet("{id}")]
        public IActionResult GetCitasPaciente(int id)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest("No es posible encontrar el valor");
            }

            try
            {
                var cantidadCita = _consultasRespository.GetCitas(id);
                 return Ok($"El número total de citas para el paciente {id} es de {cantidadCita} citas");
                /* return Ok($"Se ha realizado la operación de forma correcta para el usuario {id}"); */
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error: {ex.Message}");
            }

            
        }

        [HttpGet("medico/{id}")]
        public IEnumerable<Cita> GetPacientesMedico(int id)
        {
            return  _consultasRespository.GetPacientes(id);
        }

        [HttpGet("citas/date")]
        public IActionResult GetCitasAgendadas([FromQuery] DateOnly date)
        {
            try
            {
                var result = _consultasRespository.GetCitasByDate(date);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error: {ex.Message}");
            }
            
        }
    }
}