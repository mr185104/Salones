using Proyecto_Salon_de_Eventos.Model;
using Proyecto_Salon_de_Eventos.Repository;
using Proyecto_Salon_de_Eventos.Repository.Sqlite;
using System;
using System.Collections.Generic;

namespace Proyecto_Salon_de_Eventos.Service
{
    public class ServicioAdicionalService
    {
        private readonly IRepository<ServicioAdicional> _repository;

        public ServicioAdicionalService(IRepository<ServicioAdicional>? repository = null)
        {
            if (repository != null)
            {
                _repository = repository;
            }
            else
            {
                _repository = new SqliteServicioAdicionalRepository();
            }
        }

        public void CrearServicioAdicional(ServicioAdicional servicio)
        {
            if (servicio == null)
            {
                throw new ArgumentNullException(nameof(servicio), "El servicio adicional no puede ser nulo.");
            }

            foreach (ServicioAdicional s in _repository.GetAll())
            {
                if (s.Nombre.Trim().ToLower() == servicio.Nombre.Trim().ToLower())
                {
                    throw new InvalidOperationException("Ya existe un servicio adicional con ese nombre.");
                }
            }

            _repository.Add(servicio);
        }

        public IEnumerable<ServicioAdicional> ObtenerServiciosAdicionales()
        {
            return _repository.GetAll();
        }

        public ServicioAdicional? BuscarServicioAdicional(int id)
        {
            return _repository.GetById(id);
        }

        public bool ActualizarServicioAdicional(ServicioAdicional servicio)
        {
            if (servicio == null)
            {
                return false;
            }

            return _repository.Update(servicio);
        }

        public bool EliminarServicioAdicional(int id)
        {
            return _repository.Remove(id);
        }
    }
}