using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prueba.Dto;
using Prueba.Models;
using Prueba.Services;

namespace Prueba.Controllers._medicos
{
    [ApiController]
    [Route("api/[controller]")]
    public class MedicosController : ControllerBase
    {
        private readonly IMedicoRepository _medicoRepository;

        public MedicosController(IMedicoRepository medicoRepository)
        {
            _medicoRepository = medicoRepository;
        }

        //endpoint
        [HttpGet]
        public IEnumerable<MedicoDto> Get()
        {
            return _medicoRepository.GetMedicos();
        }

        [HttpGet("{id}")]
        public MedicoDto MedicoById(int id)
        {
            if(!ModelState.IsValid)
            {
                NotFound("Parámetro no encontrado");
            }
            
            return _medicoRepository.MedicoById(id);
        }
    }
}