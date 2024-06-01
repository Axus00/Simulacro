using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prueba.Models;

namespace Prueba.Services._consultas
{
    public interface IConsultasRespository
    {
        int GetCitas(int pacienteId);
        IEnumerable<Cita> GetPacientes(int medicoId);

        int GetCitasByDate(DateOnly date);
    }
}