using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Prueba.Dto;

namespace Prueba.Models
{
    
    public class Medico
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public int EspecialidadId { get; set; }
        public Especialidad Especialidad { get; set; } // objeto refenciando a especialidad

        [Required]
        [EmailAddress]
        public string Correo { get; set; }
        public string Telefono { get; set; }

        public Estado? Estado { get; set; }
        

        [JsonIgnore]
        public List<Cita>? Citas { get; set; }
    }
}