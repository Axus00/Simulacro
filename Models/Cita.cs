using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using Prueba.Dto;
using System.Threading.Tasks;

namespace Prueba.Models
{
    
    public class Cita
    {
        public int Id { get; set; }
        public int MedicoId { get; set; }
        public Medico Medico { get; set; } // objeto refenciando a medico
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; } // objeto refenciando a paciente 
        public DateOnly Fecha { get; set; }

        public Estado? Estado { get; set; }

        [JsonIgnore]
        public List<Tratamiento> Tratamientos { get; set; }
    }
}