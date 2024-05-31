using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prueba.Dto;
using Prueba.Models;

namespace Prueba.Services
{
    public interface IMedicoRepository
    {
        IEnumerable<MedicoDto> GetMedicos();
        MedicoDto MedicoById(int id);
        void Add(Medico medico);
        void Remove(int id);
        void Update(int id, Medico medico);

    }
}