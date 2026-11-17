using Microsoft.EntityFrameworkCore;
using Proyecto_Salon_de_Eventos.Model;
using Proyecto_Salon_de_Eventos.Repository;
using Proyecto_Salon_de_Eventos.Repository.Sqlite;
using System;
using System.Collections.Generic;

namespace Proyecto_Salon_de_Eventos.Service
{
    public class ClienteService
    {
        private readonly IRepository<Cliente> _repository;

        public ClienteService(IRepository<Cliente>? repository = null)
        {
            if (repository != null)
            {
                _repository = repository;
            }
            else
            {
                _repository = new SqliteClienteRepository();
            }
        }

        public void CrearCliente(Cliente cliente)
        {
            if (cliente == null)
            {
                throw new ArgumentNullException(nameof(cliente), "El cliente no puede ser nulo.");
            }

            foreach (Cliente c in _repository.GetAll())
            {
                if (c.Email.ToLower() == cliente.Email.ToLower())
                {
                    throw new InvalidOperationException("Ya existe un cliente con ese email.");
                }

                if (c.Dni.Trim() == cliente.Dni.Trim())
                {
                    throw new InvalidOperationException("Ya existe un cliente con ese DNI.");
                }
            }

            _repository.Add(cliente);
        }

        public IEnumerable<Cliente> ObtenerClientes()
        {
            return _repository.GetAll();
        }

        public Cliente? BuscarCliente(int id)
        {
            return _repository.GetById(id);
        }

        public void ActualizarCliente(Cliente cliente)
        {
            if (cliente == null)
            {
                throw new ArgumentNullException(nameof(cliente), "El cliente no puede ser nulo.");
            }

            bool actualizado = _repository.Update(cliente);

            if (!actualizado)
            {
                throw new KeyNotFoundException("El cliente que intenta actualizar no fue encontrado en la base de datos.");
            }
        }

        public void EliminarCliente(int id)
        {
            try
            {
                bool eliminado = _repository.Remove(id);

                if (!eliminado)
                {
                    throw new KeyNotFoundException("No se encontró el cliente que desea eliminar.");
                }
            }
            catch (DbUpdateException)
            {
                // Capturamos el error de restricción de clave foránea (Foreign Key)
                // y lanzamos una excepción de negocio limpia y descriptiva.
                throw new InvalidOperationException("No se puede eliminar el cliente porque tiene presupuestos o eventos asociados en el sistema.");
            }
        }
    }
}