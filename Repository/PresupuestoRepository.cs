using Proyecto_Salon_de_Eventos.Model;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;

namespace Proyecto_Salon_de_Eventos.Repository
{
    public class PresupuestoRepository : IRepository<Presupuesto>
    {
        private static int _nextId = 1;
        private static readonly ConcurrentDictionary<int, Presupuesto> _presupuestos = new ConcurrentDictionary<int, Presupuesto>();

        public void Add(Presupuesto presupuesto)
        {
            presupuesto.Id = Interlocked.Increment(ref _nextId) - 1;
            _presupuestos.TryAdd(presupuesto.Id, presupuesto);
        }

        public IEnumerable<Presupuesto> GetAll()
        {
            return _presupuestos.Values;
        }

        public Presupuesto? GetById(int id)
        {
            _presupuestos.TryGetValue(id, out Presupuesto? presupuestoEncontrado);
            return presupuestoEncontrado;
        }

        public bool Update(Presupuesto presupuestoActualizado)
        {
            Presupuesto? presupuestoExistente = GetById(presupuestoActualizado.Id);

            if (presupuestoExistente == null)
            {
                return false;
            }

            presupuestoExistente.FechaPresupuesto = presupuestoActualizado.FechaPresupuesto;
            presupuestoExistente.FechaEvento = presupuestoActualizado.FechaEvento;
            presupuestoExistente.Cliente = presupuestoActualizado.Cliente;
            presupuestoExistente.Estado = presupuestoActualizado.Estado;
            presupuestoExistente.Duracion = presupuestoActualizado.Duracion;
            presupuestoExistente.Salon = presupuestoActualizado.Salon;
            presupuestoExistente.Menus = presupuestoActualizado.Menus;
            presupuestoExistente.ServiciosAdicionales = presupuestoActualizado.ServiciosAdicionales;

            return true;
        }

        public bool Remove(int id)
        {
            return _presupuestos.TryRemove(id, out _);
        }
    }
}