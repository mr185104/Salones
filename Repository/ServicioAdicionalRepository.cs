using Proyecto_Salon_de_Eventos.Model;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;

namespace Proyecto_Salon_de_Eventos.Repository
{
    public class ServicioAdicionalRepository : IRepository<ServicioAdicional>
    {
        private static int _nextId = 1;
        private static readonly ConcurrentDictionary<int, ServicioAdicional> _servicios = new ConcurrentDictionary<int, ServicioAdicional>();

        public void Add(ServicioAdicional servicio)
        {
            servicio.Id = Interlocked.Increment(ref _nextId) - 1;
            _servicios.TryAdd(servicio.Id, servicio);
        }

        public IEnumerable<ServicioAdicional> GetAll()
        {
            return _servicios.Values;
        }

        public ServicioAdicional? GetById(int id)
        {
            _servicios.TryGetValue(id, out ServicioAdicional? servicioEncontrado);
            return servicioEncontrado;
        }

        public bool Update(ServicioAdicional servicioActualizado)
        {
            ServicioAdicional? servicioExistente = GetById(servicioActualizado.Id);

            if (servicioExistente == null)
            {
                return false;
            }

            servicioExistente.Nombre = servicioActualizado.Nombre;
            servicioExistente.Precio = servicioActualizado.Precio;

            return true;
        }

        public bool Remove(int id)
        {
            return _servicios.TryRemove(id, out _);
        }

        public bool ExistsByNombre(string nombre)
        {
            foreach (ServicioAdicional servicio in _servicios.Values)
            {
                if (servicio.Nombre.Trim().ToLower() == nombre.Trim().ToLower())
                {
                    return true;
                }
            }

            return false;
        }
    }
}