using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Dto
{
    public class TratamientoDto
    {
        public int Id { get; set; }
        public int CitaID { get; set; }
        
        [Required]
        [StringLength(1000)]
        public string Descripcion { get; set; }
        
        public string Estado { get; set; }

        //constructor
        public TratamientoDto(int id, int citaID, string descripcion, string estado)
        {
            Id = id;
            CitaID = citaID;
            Descripcion = descripcion;
            Estado = estado;
        }
    }
}