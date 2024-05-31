using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using Prueba.Dto;
using System.Threading.Tasks;

namespace Prueba.Models
{
    
    public class Especialidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        [Required]
        [StringLength(1000)]
        public string Descripcion { get; set; }

        public Estado? Estado { get; set; }
        

        [JsonIgnore]
        public List<Medico>? Medicos { get; set; }
    }
}