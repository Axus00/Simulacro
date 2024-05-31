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
    public class EspecialidadesController :ControllerBase
    {
        private readonly IEspecialidadRepository _especialidadRepository;

        public EspecialidadesController(IEspecialidadRepository especialidadRepository)
        {
            _especialidadRepository = especialidadRepository;
        }

        //endpoint
        [HttpGet]
        public IEnumerable<EspecialidadDto> Get()
        {
            return _especialidadRepository.GetEspecialidades();
        }

        [HttpGet("{id}")]
        public EspecialidadDto DetailsEspecialidad(int id)
        {
            if(!ModelState.IsValid)
            {
                NotFound("No se puso encontrar");
            }
            

            return _especialidadRepository.EspecialidadById(id);

        
        }
    }
}