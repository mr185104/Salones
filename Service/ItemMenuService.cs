using Proyecto_Salon_de_Eventos.Model;
using Proyecto_Salon_de_Eventos.Repository;
using Proyecto_Salon_de_Eventos.Repository.Sqlite;
using System;
using System.Collections.Generic;

namespace Proyecto_Salon_de_Eventos.Service
{
    public class ItemMenuService
    {
        private readonly IRepository<ItemMenu> _itemMenuRepository;
        private readonly IRepository<Menu> _menuRepository;

        public ItemMenuService(IRepository<ItemMenu>? itemMenuRepository = null, IRepository<Menu>? menuRepository = null)
        {
            if (itemMenuRepository != null)
            {
                _itemMenuRepository = itemMenuRepository;
            }
            else
            {
                _itemMenuRepository = new SqliteItemMenuRepository();
            }

            if (menuRepository != null)
            {
                _menuRepository = menuRepository;
            }
            else
            {
                _menuRepository = new SqliteMenuRepository();
            }
        }

        public void CrearItemMenu(int cantidad, int menuId)
        {
            Menu? menuExistente = _menuRepository.GetById(menuId);
            if (menuExistente == null)
            {
                throw new InvalidOperationException("No se puede crear el ítem porque el menú especificado no existe.");
            }

            ItemMenu itemMenu = new ItemMenu(0, cantidad, menuExistente); // ID en 0 para que EF Core autoincremente
            _itemMenuRepository.Add(itemMenu);
        }

        public IEnumerable<ItemMenu> ObtenerItemMenus()
        {
            return _itemMenuRepository.GetAll();
        }

        public ItemMenu? BuscarItemMenu(int id)
        {
            return _itemMenuRepository.GetById(id);
        }

        public bool ActualizarItemMenu(int id, int cantidad, int menuId)
        {
            Menu? menuExistente = _menuRepository.GetById(menuId);
            if (menuExistente == null)
            {
                return false;
            }

            ItemMenu itemMenuActualizado = new ItemMenu(id, cantidad, menuExistente);
            return _itemMenuRepository.Update(itemMenuActualizado);
        }

        public bool EliminarItemMenu(int id)
        {
            return _itemMenuRepository.Remove(id);
        }
    }
}