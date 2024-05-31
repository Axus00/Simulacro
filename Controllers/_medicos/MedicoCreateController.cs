using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prueba.Models;
using Prueba.Services;

namespace Prueba.Controllers._medicos
{
    [ApiController]
    [Route("api/[controller]")]
    public class MedicoCreateController : ControllerBase
    {
        private readonly IMedicoRepository _medicoRepository;

        public MedicoCreateController(IMedicoRepository medicoRepository)
        {
            _medicoRepository = medicoRepository;
        }

        //endpoint
        [HttpPost]
        public IActionResult Create(Medico medico)
        {
            _medicoRepository.Add(medico);
            return Ok();
        }
    }
}