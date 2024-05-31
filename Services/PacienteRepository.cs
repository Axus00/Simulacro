using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Prueba.Data;
using Prueba.Dto;
using Prueba.Models;

namespace Prueba.Services
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly BaseContext _context;
        public PacienteRepository(BaseContext context)
        {
            _context = context;
        }
        public void Add(Paciente paciente)
        {
            _context.Pacientes.Add(paciente);
        }

        public IEnumerable<PacienteDto> GetPacientes()
        {
            var paciente = _context.Pacientes.ToList();
            
            List<PacienteDto> pacienteList = new List<PacienteDto>();

            foreach (var item in paciente)
            {

                PacienteDto pacienteDto = new PacienteDto(
                    item.Id,
                    item.Nombres,
                    item.Apellidos,
                    item.FechaNacimiento,
                    item.Correo,
                    item.Telefono,
                    item.Direccion,
                    item.Estado.ToString()
                );
                
                pacienteList.Add(pacienteDto);
            }

            return pacienteList;
        }

        public PacienteDto PacienteById(int id)
        {
            var paciente = _context.Pacientes.Find();

            PacienteDto pacienteDto = new PacienteDto(paciente.Id, paciente.Nombres, paciente.Apellidos, paciente.FechaNacimiento, paciente.Correo, paciente.Telefono, paciente.Direccion, paciente.Estado.ToString());

            return pacienteDto;
            
            
        }

        public void Remove(int id)
        {
            var pacienteRemove = _context.Pacientes.Find(id);
            _context.Pacientes.Remove(pacienteRemove);
            _context.SaveChanges();
        }

        public void Update(int id, Paciente paciente)
        {
            var pacienteUpdate = _context.Pacientes.FirstOrDefault(p => p.Id == id);
            pacienteUpdate.Nombres = paciente.Nombres;
            pacienteUpdate.Apellidos = paciente.Apellidos;
            pacienteUpdate.FechaNacimiento = paciente.FechaNacimiento;
            pacienteUpdate.Correo = paciente.Correo;
            pacienteUpdate.Telefono = paciente.Telefono;
            pacienteUpdate.Direccion = paciente.Direccion;
            
            _context.SaveChanges();
        }
    }
}