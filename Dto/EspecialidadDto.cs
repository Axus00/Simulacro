using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Dto
{
    public class EspecialidadDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        [Required]
        [StringLength(1000)]
        public string Descripcion { get; set; }

        public string Estado { get; set; }

        public EspecialidadDto(int id, string nombre, string descripcion, string estado)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            Estado = estado;
        }
    }
}