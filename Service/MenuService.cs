using Proyecto_Salon_de_Eventos.Model;
using Proyecto_Salon_de_Eventos.Repository;
using Proyecto_Salon_de_Eventos.Repository.Sqlite;
using System;
using System.Collections.Generic;

namespace Proyecto_Salon_de_Eventos.Service
{
    public class MenuService
    {
        private readonly IRepository<Menu> _repository;

        public MenuService(IRepository<Menu>? repository = null)
        {
            if (repository != null)
            {
                _repository = repository;
            }
            else
            {
                _repository = new SqliteMenuRepository();
            }
        }

        public void CrearMenu(Menu menu)
        {
            if (menu == null)
            {
                throw new ArgumentNullException("El menú no puede ser nulo.");
            }

            foreach (Menu m in _repository.GetAll())
            {
                if (m.Nombre.Trim().ToLower() == menu.Nombre.Trim().ToLower())
                {
                    throw new InvalidOperationException("Ya existe un menú con ese nombre.");
                }
            }

            _repository.Add(menu);
        }

        public IEnumerable<Menu> ObtenerMenus()
        {
            return _repository.GetAll();
        }

        public Menu? BuscarMenu(int id)
        {
            return _repository.GetById(id);
        }

        public bool ActualizarMenu(Menu menu)
        {
            if (menu == null)
            {
                return false;
            }

            return _repository.Update(menu);
        }

        public bool EliminarMenu(int id)
        {
            return _repository.Remove(id);
        }
    }
}
