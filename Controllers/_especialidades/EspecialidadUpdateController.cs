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
    public class EspecialidadUpdateController : ControllerBase
    {
        private readonly IEspecialidadRepository _especialidadRepository;

        public EspecialidadUpdateController(IEspecialidadRepository especialidadRepository)
        {
            _especialidadRepository = especialidadRepository;
        }

        //endpoint
        [HttpPut("{id}")]
        public IActionResult EspecialidadUpdate(int id, [FromBody] Especialidad especialidad)
        {
            _especialidadRepository.Update(id, especialidad);
            return Ok("Se ha creado de forma exitosa");
        }

        [HttpPut("updateStatus/{id}")]
        public IActionResult UpdateStatus(int id, EspecialidadDto especialidad)
        {
             _especialidadRepository.UpdateStatus(id, especialidad);
             return Ok();
        
        }
    }
}