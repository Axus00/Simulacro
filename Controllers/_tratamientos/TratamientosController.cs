using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prueba.Dto;
using Prueba.Services;

namespace Prueba.Controllers._tratamientos
{
    [ApiController]
    [Route("api/[controller]")]
    public class TratamientosController : ControllerBase
    {
        private readonly ITratamientoRepository _tratamientoRepository;

        public TratamientosController(ITratamientoRepository tratamientoRepository)
        {
            _tratamientoRepository = tratamientoRepository;
        }

        // endpoint
        [HttpGet]
        public IEnumerable<TratamientoDto> Get()
        {
            return _tratamientoRepository.GetTratamientos();
        }

        [HttpGet("{id}")]
        public TratamientoDto TratamientoById(int id)
        {
            return _tratamientoRepository.TratamientoById(id);
        }
    }
}