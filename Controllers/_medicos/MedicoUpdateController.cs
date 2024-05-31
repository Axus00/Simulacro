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
    public class MedicoUpdateController : ControllerBase
    {
        private readonly IMedicoRepository _medicoRepository;

        public MedicoUpdateController(IMedicoRepository medicoRepository)
        {
            _medicoRepository = medicoRepository;
        }

        //endpoint
        [HttpPut("{id}")]
        public IActionResult MedicoUpdate(int id, Medico medico)
        {
            _medicoRepository.Update(id, medico);
            return Ok();
        }
    }
}