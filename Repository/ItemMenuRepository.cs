using Proyecto_Salon_de_Eventos.Model;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;

namespace Proyecto_Salon_de_Eventos.Repository
{
    public class ItemMenuRepository : IRepository<ItemMenu>
    {
        private static int _nextId = 1;
        private static readonly ConcurrentDictionary<int, ItemMenu> _itemMenus = new ConcurrentDictionary<int, ItemMenu>();

        public void Add(ItemMenu itemMenu)
        {
            itemMenu.Id = Interlocked.Increment(ref _nextId) - 1;
            _itemMenus.TryAdd(itemMenu.Id, itemMenu);
        }

        public IEnumerable<ItemMenu> GetAll()
        {
            return _itemMenus.Values;
        }

        public ItemMenu? GetById(int id)
        {
            _itemMenus.TryGetValue(id, out ItemMenu? itemEncontrado);
            return itemEncontrado;
        }

        public bool Update(ItemMenu itemActualizado)
        {
            ItemMenu? itemExistente = GetById(itemActualizado.Id);

            if (itemExistente == null)
            {
                return false;
            }

            itemExistente.Cantidad = itemActualizado.Cantidad;
            itemExistente.Item = itemActualizado.Item;

            return true;
        }

        public bool Remove(int id)
        {
            return _itemMenus.TryRemove(id, out _);
        }
    }
}