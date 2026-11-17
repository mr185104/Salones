using Proyecto_Salon_de_Eventos.Model;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;

namespace Proyecto_Salon_de_Eventos.Repository
{
    public class AptoMenuRepository : IRepository<AptoMenu>
    {
        private static int _nextId = 1;
        private static readonly ConcurrentDictionary<int, AptoMenu> _aptosMenu = new ConcurrentDictionary<int, AptoMenu>();

        public void Add(AptoMenu aptoMenu)
        {
            aptoMenu.Id = Interlocked.Increment(ref _nextId) - 1;
            _aptosMenu.TryAdd(aptoMenu.Id, aptoMenu);
        }

        public IEnumerable<AptoMenu> GetAll()
        {
            return _aptosMenu.Values;
        }

        public AptoMenu? GetById(int id)
        {
            _aptosMenu.TryGetValue(id, out AptoMenu? aptoEncontrado);
            return aptoEncontrado;
        }

        public bool Update(AptoMenu aptoMenuActualizado)
        {
            AptoMenu? aptoExistente = GetById(aptoMenuActualizado.Id);

            if (aptoExistente == null)
            {
                return false;
            }

            aptoExistente.Detalle = aptoMenuActualizado.Detalle;

            return true;
        }

        public bool Remove(int id)
        {
            return _aptosMenu.TryRemove(id, out _);
        }

        public bool ExistsByDetalle(string detalle)
        {
            foreach (AptoMenu apto in _aptosMenu.Values)
            {
                if (apto.Detalle.Trim().ToLower() == detalle.Trim().ToLower())
                {
                    return true;
                }
            }

            return false;
        }
    }
}
