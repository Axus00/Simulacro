using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prueba.Data;
using Prueba.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Prueba.Dto;

namespace Prueba.Services
{
    
    public class MedicoRepository : IMedicoRepository
    {
        private readonly BaseContext _context;
        public MedicoRepository(BaseContext context)
        {
            _context = context;
        }
        public void Add(Medico medico)
        {
            _context.Medicos.Add(medico);
        }

        public IEnumerable<MedicoDto> GetMedicos()
        {
            var medico = _context.Medicos.Include(m => m.Especialidad).ToList();

            List<MedicoDto> medicoList = new List<MedicoDto>();

            foreach (var item in medico)
            {
                MedicoDto medicoDto = new MedicoDto(
                    item.Id,
                    item.NombreCompleto,
                    item.EspecialidadId,
                    item.Correo,
                    item.Telefono,
                    item.Estado.ToString()
                );

                medicoList.Add(medicoDto);
                
            }

            return medicoList;
        }

        public MedicoDto MedicoById(int id)
        {
            var medico = _context.Medicos.Find(id);
            MedicoDto medicoDto = new MedicoDto(medico.Id, medico.NombreCompleto, medico.EspecialidadId, medico.Correo, medico.Telefono, medico.Estado.ToString());
            
            return medicoDto;
        }

        public void Remove(int id)
        {
            var medico = _context.Medicos.FirstOrDefault(m => m.Id == id);
            medico.Estado = Estado.Eliminado;
            _context.Update(medico);
            _context.SaveChanges();
        }

        public void Update(int id, Medico medico)
        {
            var especialidad = _context.Medicos.FirstOrDefault(e => e.Id == id);
            especialidad.NombreCompleto = medico.NombreCompleto;
            especialidad.Correo = medico.Correo;
            especialidad.Telefono = medico.Telefono;

            _context.SaveChanges();
        }
    }
}