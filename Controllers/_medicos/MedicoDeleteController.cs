using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prueba.Services;

namespace Prueba.Controllers._medicos
{
    [ApiController]
    [Route("api/[controller]")]
    public class MedicoDeleteController : ControllerBase
    {
        private readonly IMedicoRepository _medicoRepository;

        public MedicoDeleteController(IMedicoRepository medicoRepository)
        {
            _medicoRepository = medicoRepository;
        }

        //endpoint
        [HttpDelete("{id}")]
        public IActionResult DeleteMedico(int id)
        {
            _medicoRepository.Remove(id);
            return Ok();
        }
    }
}