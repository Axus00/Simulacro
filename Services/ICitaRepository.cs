using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prueba.Dto;
using Prueba.Models;

namespace Prueba.Services
{
    public interface ICitaRepository
    {
        IEnumerable<CitaDto> GetCitas(); //GEt
        CitaDto CitaById(int id); //GET By Id
        void Add(Cita cita); // Añadir

        void Remove(int id);

        void Update(int id, Cita cita);

    }
}