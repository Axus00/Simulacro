using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Dto
{
    public class MedicoDto
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public int EspecialidadId { get; set; }

        [Required]
        [EmailAddress]
        public string Correo { get; set; }
        public string Telefono { get; set; }

        public string Estado { get; set; }

        //contructor
        public MedicoDto(int id, string nombreCompleto, int especialidadId, string correo, string telefono, string estado)
        {
            Id = id;
            NombreCompleto = nombreCompleto;
            EspecialidadId = especialidadId;
            Correo = correo;
            Telefono = telefono;
            Estado = estado;
        }
    }
}