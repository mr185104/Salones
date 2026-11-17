using Proyecto_Salon_de_Eventos.Model;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;

namespace Proyecto_Salon_de_Eventos.Repository
{
    public class MenuRepository : IRepository<Menu>
    {
        private static int _nextId = 1;
        private static readonly ConcurrentDictionary<int, Menu> _menus = new ConcurrentDictionary<int, Menu>();

        public void Add(Menu menu)
        {
            menu.Id = Interlocked.Increment(ref _nextId) - 1;
            _menus.TryAdd(menu.Id, menu);
        }

        public IEnumerable<Menu> GetAll()
        {
            return _menus.Values;
        }

        public Menu? GetById(int id)
        {
            _menus.TryGetValue(id, out Menu? menuEncontrado);
            return menuEncontrado;
        }

        public bool Update(Menu menuActualizado)
        {
            Menu? menuExistente = GetById(menuActualizado.Id);

            if (menuExistente == null)
            {
                return false;
            }

            menuExistente.Nombre = menuActualizado.Nombre;
            menuExistente.Detalle = menuActualizado.Detalle;
            menuExistente.Precio = menuActualizado.Precio;
            menuExistente.EsAdulto = menuActualizado.EsAdulto;
            menuExistente.AptosMenu = menuActualizado.AptosMenu;

            return true;
        }

        public bool Remove(int id)
        {
            return _menus.TryRemove(id, out _);
        }

        public bool ExistsByNombre(string nombre)
        {
            foreach (Menu menu in _menus.Values)
            {
                if (menu.Nombre.Trim().ToLower() == nombre.Trim().ToLower())
                {
                    return true;
                }
            }

            return false;
        }
    }
}
