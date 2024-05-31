using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Prueba.Models;
using Prueba.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;
using Prueba.Dto;
using Prueba.Controllers._mail;

namespace Prueba.Services
{
    public class CitaRepository : ICitaRepository
    {
        private readonly BaseContext _context;
        public CitaRepository(BaseContext context)
        {
            _context = context;
        }
        public void Add(Cita cita)
        {
            _context.Citas.Add(cita);
            _context.SaveChanges();
        }

        public CitaDto CitaById(int id)
        {
            var cita = _context.Citas.Find(id);
            
            CitaDto citaDto  = new CitaDto(cita.Id, cita.MedicoId, cita.PacienteId, cita.Fecha, cita.Estado.ToString());

            return citaDto;
        }

        public IEnumerable<CitaDto> GetCitas()
        {
            var cita = _context.Citas.Include(c => c.Medico).Include(c => c.Paciente).ToList();

            List<CitaDto> list = new List<CitaDto>();

            foreach (var item in cita)
            {
                CitaDto citaDto  = new CitaDto(
                    item.Id,
                    item.MedicoId,
                    item.PacienteId,
                    item.Fecha,
                    item.Estado.ToString()
                );
                
                list.Add(citaDto);
            }

            return list;
             
        }

        public void Remove(int id)
        {
            var cita = _context.Citas.FirstOrDefault(c => c.Id == id);
           /*  Estado estado = new Estado(cita.Estado.ToString());  */
            
            cita.Estado = Estado.Eliminado;
            
            _context.Update(cita);
            _context.SaveChanges();
        }

        public void Update(int id, [FromBody] Cita cita)
        {
            var cita_update = _context.Citas.FirstOrDefault(c => c.Id == id);
            cita_update.Fecha = cita.Fecha;
            cita_update.Medico = cita.Medico;
            cita_update.Paciente = cita.Paciente;
            cita_update.Tratamientos = cita.Tratamientos;

            //enviamos mensaje recordando la cita médica
            MailController Email = new MailController();
            Email.SendEmail();
            
            _context.SaveChanges();
        }
    }
}