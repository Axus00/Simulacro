using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prueba.Models;
using Prueba.Services;

namespace Prueba.Controllers.__citas
{
    [ApiController]
    [Route("api/[controller]")]
    public class EspecialidadCreateController : ControllerBase
    {
        private readonly IEspecialidadRepository _especialidadRepository;

        public EspecialidadCreateController(IEspecialidadRepository especialidadRepository)
        {
            _especialidadRepository = especialidadRepository;
        }

        //endpoint
        [HttpPost]
        public IActionResult Create(Especialidad especialidad)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest("No ha sido posible realizar la acción");
            }

            _especialidadRepository.Add(especialidad);
            return Ok("Se ha creado de forma correcta");
        }
    }
}