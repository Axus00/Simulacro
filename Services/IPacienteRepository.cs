using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prueba.Dto;
using Prueba.Models;

namespace Prueba.Services
{
    public interface IPacienteRepository
    {
        IEnumerable<PacienteDto> GetPacientes();
        PacienteDto PacienteById(int id);
        void Add(Paciente paciente);
        void Remove(int id);
        void Update(int id, Paciente paciente); 
    }
}