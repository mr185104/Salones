using Proyecto_Salon_de_Eventos.Model;
using Proyecto_Salon_de_Eventos.Repository;
using Proyecto_Salon_de_Eventos.Repository.Sqlite;
using System;
using System.Collections.Generic;

namespace Proyecto_Salon_de_Eventos.Service
{
    public class AptoMenuService
    {
        private readonly IRepository<AptoMenu> _repository;

        public AptoMenuService(IRepository<AptoMenu>? repository = null)
        {
            if (repository != null)
            {
                _repository = repository;
            }
            else
            {
                _repository = new SqliteAptoMenuRepository();
            }
        }

        public void CrearAptoMenu(AptoMenu aptoMenu)
        {
            if (aptoMenu == null)
            {
                throw new ArgumentNullException("El AptoMenu no puede ser nulo.");
            }

            foreach (AptoMenu a in _repository.GetAll())
            {
                if (a.Detalle.Trim().ToLower() == aptoMenu.Detalle.Trim().ToLower())
                {
                    throw new InvalidOperationException("Ya existe un AptoMenu con ese detalle.");
                }
            }

            _repository.Add(aptoMenu);
        }

        public IEnumerable<AptoMenu> ObtenerAptosMenu()
        {
            return _repository.GetAll();
        }

        public AptoMenu? BuscarAptoMenu(int id)
        {
            return _repository.GetById(id);
        }

        public bool ActualizarAptoMenu(AptoMenu aptoMenu)
        {
            if (aptoMenu == null)
            {
                return false;
            }

            return _repository.Update(aptoMenu);
        }

        public bool EliminarAptoMenu(int id)
        {
            return _repository.Remove(id);
        }
    }
}