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
    public class CitaDeleteController : ControllerBase
    {
        private readonly ICitaRepository _citaRepository;

        public CitaDeleteController(ICitaRepository citaRepository)
        {
            _citaRepository = citaRepository;
        }

        //endpoint
        [HttpDelete("{id}")]
        public IActionResult DeleteCita(int id)
        {
            _citaRepository.Remove(id);
            return Ok("Se ha eliminado de forma correcta");
        }
    }
}