using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prueba.Dto;
using Prueba.Models;

namespace Prueba.Services
{
    public interface ITratamientoRepository
    {
        IEnumerable<TratamientoDto> GetTratamientos();
        TratamientoDto TratamientoById(int id);
        void Add(Tratamiento tratamiento);
        void Remove(int id);
        void Update(int id, Tratamiento tratamiento);
    }
}