using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prueba.Data;
using Prueba.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Prueba.Services._consultas
{
    public class ConsultasRespository : IConsultasRespository
    {
        private readonly BaseContext _context;
        public ConsultasRespository(BaseContext context)
        {
            _context = context;
        }
        public int GetCitas(int pacienteId)
        {
            var cantidad_citas = _context.Citas.Where(p => p.PacienteId == pacienteId).Count();
            
            return cantidad_citas;
        }

        public int GetCitasByDate(DateOnly date)
        {
            var cantidad_citas_fecha = _context.Citas.Where(c => c.Fecha == date).Count();
            
            return cantidad_citas_fecha;
        }

        IEnumerable<Cita> IConsultasRespository.GetPacientes(int medicoId)
        {
            var cantidad_pacientes = _context.Citas.Where(paciente => paciente.MedicoId == medicoId).ToList(); 
            
            return cantidad_pacientes;
        }
    }
}