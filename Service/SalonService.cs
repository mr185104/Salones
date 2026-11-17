using Microsoft.EntityFrameworkCore;
using Proyecto_Salon_de_Eventos.Model;
using Proyecto_Salon_de_Eventos.Repository;
using Proyecto_Salon_de_Eventos.Repository.Sqlite;
using System;
using System.Collections.Generic;

namespace Proyecto_Salon_de_Eventos.Service
{
    public class SalonService
    {
        private readonly IRepository<Salon> _repository;

        public SalonService(IRepository<Salon>? repository = null)
        {
            if (repository != null)
            {
                _repository = repository;
            }
            else
            {
                _repository = new SqliteSalonRepository();
            }
        }

        public void CrearSalon(Salon salon)
        {
            if (salon == null)
            {
                throw new ArgumentNullException(nameof(salon), "El salón no puede ser nulo.");
            }

            foreach (Salon s in _repository.GetAll())
            {
                if (s.Nombre.ToLower() == salon.Nombre.ToLower())
                {
                    throw new InvalidOperationException("Ya existe un salón registrado con el nombre: " + salon.Nombre);
                }
            }

            _repository.Add(salon);
        }

        public IEnumerable<Salon> ObtenerSalones()
        {
            return _repository.GetAll();
        }

        public Salon? BuscarSalon(int id)
        {
            return _repository.GetById(id);
        }

        public void ActualizarSalon(Salon salon)
        {
            if (salon == null)
            {
                throw new ArgumentNullException(nameof(salon), "El salón no puede ser nulo.");
            }

            Salon? salonExistente = _repository.GetById(salon.Id);
            if (salonExistente == null)
            {
                throw new KeyNotFoundException("El salón que intenta actualizar no fue encontrado en la base de datos.");
            }

            foreach (Salon s in _repository.GetAll())
            {
                if (s.Id != salon.Id && s.Nombre.ToLower() == salon.Nombre.ToLower())
                {
                    throw new InvalidOperationException("El nuevo nombre ya pertenece a otro salón registrado.");
                }
            }

            // Llamada directa sin asignar a booleano
            _repository.Update(salon);
        }

        public void EliminarSalon(int id)
        {
            try
            {
                Salon? salon = _repository.GetById(id);
                if (salon == null)
                {
                    throw new KeyNotFoundException("No se encontró el salón que desea eliminar.");
                }

                // Llamada directa sin asignar a booleano
                _repository.Remove(id);
            }
            catch (DbUpdateException)
            {
                // Capturamos el error de restricción de clave foránea (Foreign Key)
                throw new InvalidOperationException("No se puede eliminar el salón porque tiene presupuestos o registros asociados en el sistema.");
            }
        }
    }
}