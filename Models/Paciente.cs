using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Prueba.Dto;

namespace Prueba.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateOnly FechaNacimiento { get; set; }

        [Required]
        [EmailAddress]
        public string Correo { get; set; }
        public string Telefono { get; set; }

        [Required]
        public string Direccion { get; set; }
        

        public Estado? Estado { get; set; }

        [JsonIgnore]
        public List<Cita>? Citas { get; set; }
    }
}