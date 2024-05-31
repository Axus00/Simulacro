using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prueba.Dto;
using Prueba.Models;
using Prueba.Services;

namespace Prueba.Controllers.__citas
{
    [ApiController]
    [Route("api/[controller]")]
    public class CitasController : ControllerBase
    {
        private readonly ICitaRepository _citaRepository;

        public CitasController(ICitaRepository citaRepository)
        {
            _citaRepository = citaRepository;
        }

        //endpoints
        [HttpGet]
        public IEnumerable<CitaDto> Get()
        {
            return _citaRepository.GetCitas();
        }

        [HttpGet("{id}")]
        public CitaDto DetailsCita(int id)
        {
            if(!ModelState.IsValid)
            {
                NotFound("No se ha encontrado la cita.");
            }

            return _citaRepository.CitaById(id);
            
        }
    }
}