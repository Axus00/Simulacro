using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Dto
{
    public class PacienteDto
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
        

        public string Estado { get; set; }

        //contructor
        public PacienteDto(int id, string nombres, string apellidos, DateOnly fechaNacimiento, string correo, string telefono, string direccion, string estado)
        {
            Id = id;
            Nombres = nombres;
            Apellidos = apellidos;
            FechaNacimiento = fechaNacimiento;
            Correo = correo;
            Telefono = telefono;
            Direccion = direccion;
            Estado = estado;
        }
    }
}