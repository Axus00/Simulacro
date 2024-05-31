using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Prueba.Dto;

namespace Prueba.Models
{
    public class Tratamiento
    {
        public int Id { get; set; }
        public int CitaID { get; set; }
        public Cita Cita { get; set; } // objeto refenciando a cita
        
        [Required]
        [StringLength(1000)]
        public string Descripcion { get; set; }
        
        public Estado? Estado { get; set; }
    }
}