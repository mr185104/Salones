using Proyecto_Salon_de_Eventos.Model;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;

namespace Proyecto_Salon_de_Eventos.Repository
{
    public class SalonRepository : IRepository<Salon>
    {
        private static int _nextId = 1;

        private static readonly ConcurrentDictionary<int, Salon> _salones = new ConcurrentDictionary<int, Salon>();

        public void Add(Salon salon)
        {
            salon.Id = Interlocked.Increment(ref _nextId) - 1;

            _salones.TryAdd(salon.Id, salon);
        }

        public IEnumerable<Salon> GetAll()
        {
            return _salones.Values;
        }

        public Salon? GetById(int id)
        {
            Salon? salonEncontrado;
            _salones.TryGetValue(id, out salonEncontrado);

            return salonEncontrado;
        }

        public bool Update(Salon salonActualizado)
        {
            Salon? salonExistente = GetById(salonActualizado.Id);

            if (salonExistente == null)
            {
                return false; 
            }

            salonExistente.Nombre = salonActualizado.Nombre;
            salonExistente.Direccion = salonActualizado.Direccion;
            salonExistente.Localidad = salonActualizado.Localidad; 
            salonExistente.Capacidad = salonActualizado.Capacidad;
            salonExistente.Precio = salonActualizado.Precio;

            return true;
        }

        public bool Remove(int id)
        {
            Salon? salonRemovido;
            bool resultado = _salones.TryRemove(id, out salonRemovido);

            return resultado;
        }


        public bool ExistsByNombre(string nombre)
        {
            foreach (Salon salon in _salones.Values)
            {
                if (salon.Nombre.ToLower() == nombre.ToLower())
                {
                    return true; 
                }
            }

            return false; 
        }
    }
}