using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Prueba.Data;
using Prueba.Dto;
using Prueba.Models;

namespace Prueba.Services
{
    public class TratamientoRepository : ITratamientoRepository
    {
        private readonly BaseContext _context;
        public TratamientoRepository(BaseContext context)
        {
            _context = context;
        }
        public void Add(Tratamiento tratamiento)
        {
            _context.Tratamientos.Add(tratamiento);
            _context.SaveChanges();
        }

        public IEnumerable<TratamientoDto> GetTratamientos()
        {
            var tratamiento = _context.Tratamientos.Include(t => t.Cita).ToList();

            List<TratamientoDto> tratamientoList = new List<TratamientoDto>();

            foreach (var item in tratamiento)
            {
                TratamientoDto tratamientoDto = new TratamientoDto(
                    item.Id,
                    item.CitaID,
                    item.Descripcion,
                    item.Estado.ToString()
                );

                tratamientoList.Add(tratamientoDto);
            }

            return tratamientoList;
            
        }

        public void Remove(int id)
        {
            var tratamiento = _context.Tratamientos.Find(id);
            _context.Remove(tratamiento);
            _context.SaveChanges();
        }

        public TratamientoDto TratamientoById(int id)
        {
            var tratamientoId = _context.Tratamientos.Find(id);

            TratamientoDto tratamientoDto = new TratamientoDto(tratamientoId.Id, tratamientoId.CitaID, tratamientoId.Descripcion, tratamientoId.Estado.ToString());


            return tratamientoDto;
        }

        public void Update(int id, Tratamiento tratamiento)
        {
            var tratamientoUpdate = _context.Tratamientos.FirstOrDefault(t => t.Id == id);
            tratamientoUpdate.Descripcion = tratamiento.Descripcion;
            tratamientoUpdate.Cita = tratamiento.Cita;

            //actualizamos y guardamos en la base
            _context.Tratamientos.Update(tratamientoUpdate);
            _context.SaveChanges();

        }
    }
}