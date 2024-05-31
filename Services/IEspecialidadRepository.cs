using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prueba.Dto;
using Prueba.Models;

namespace Prueba.Services
{
    public interface IEspecialidadRepository
    {
        IEnumerable<EspecialidadDto> GetEspecialidades();
        EspecialidadDto EspecialidadById(int id);
        void Add(Especialidad especialidad);
        void Remove(int id);
        void Update(int id, Especialidad especialidad);
    }
}