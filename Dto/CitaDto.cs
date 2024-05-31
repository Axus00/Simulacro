using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Dto
{
    public class CitaDto
    {
        public int Id { get; set; }
        public int MedicoId { get; set; } 
        public int PacienteId { get; set; } 
        public DateOnly Fecha { get; set; }

        public string Estado { get; set; }

        public CitaDto(int id, int medicoId, int pacienteId, DateOnly fecha, string estado)
        {
            Id = id;
            MedicoId = medicoId;
            pacienteId = pacienteId;
            Fecha = fecha;
            Estado = estado;
        }
    }
}