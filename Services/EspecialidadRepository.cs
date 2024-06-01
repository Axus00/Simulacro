using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prueba.Data;
using Prueba.Dto;
using Prueba.Models;

namespace Prueba.Services
{
    public class EspecialidadRepository : IEspecialidadRepository
    {
        private readonly BaseContext _context;
        public EspecialidadRepository(BaseContext context)
        {
            _context = context;
        }
        public void Add(Especialidad especialidad)
        {
            _context.Especialidades.Add(especialidad);
            _context.SaveChanges(); 
        }

        public EspecialidadDto EspecialidadById(int id)
        {

            var especialidad = _context.Especialidades.Find(id);

            EspecialidadDto especialidadDto = new EspecialidadDto(especialidad.Id, especialidad.Nombre, especialidad.Descripcion, especialidad.Estado.ToString());

            return especialidadDto;
        }

        public IEnumerable<EspecialidadDto> GetEspecialidades()
        {
            var especialidad =_context.Especialidades.ToList();

            List<EspecialidadDto> listEspecialidad = new List<EspecialidadDto>();

            foreach (var item in especialidad)
            {
                EspecialidadDto especialidadDto = new EspecialidadDto(
                    item.Id,
                    item.Nombre,
                    item.Descripcion,
                    item.Estado.ToString()
                );

                listEspecialidad.Add(especialidadDto);
            }
            

            return listEspecialidad;
        }

        public void Remove(int id)
        {
            var _especialidad = _context.Especialidades.FirstOrDefault(e => e.Id == id);
            _especialidad.Estado = Dto.Estado.Eliminado;
            _context.Update(_especialidad);
            _context.SaveChanges();
        }

        public void Update(int id,  Especialidad especialidad)
        {
            var _especialidad = _context.Especialidades.FirstOrDefault(e => e.Id == id);
            _especialidad.Nombre = especialidad.Nombre;
            _especialidad.Descripcion = especialidad.Descripcion;
            _especialidad.Estado = especialidad.Estado;

            _context.SaveChanges();
        }

        public void UpdateStatus(int id, [FromBody] EspecialidadDto especialidad)
        {
            var update_status = _context.Especialidades.FirstOrDefault(esp => esp.Id == id);
            EspecialidadDto especialidadDto = new EspecialidadDto(update_status.Id, update_status.Nombre, update_status.Descripcion, update_status.Estado.ToString());

            especialidadDto.Id = especialidad.Id;
            especialidadDto.Nombre = especialidad.Nombre;
            especialidadDto.Descripcion = especialidad.Descripcion;
            especialidadDto.Estado = especialidad.Estado;

            _context.SaveChanges();
        }
    }
}