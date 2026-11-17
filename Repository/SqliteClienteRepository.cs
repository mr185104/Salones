using Microsoft.EntityFrameworkCore;
using Proyecto_Salon_de_Eventos.Data;
using Proyecto_Salon_de_Eventos.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Proyecto_Salon_de_Eventos.Repository.Sqlite
{
    public class SqliteClienteRepository : IRepository<Cliente>
    {
        private readonly SalonDbContext _context;

        public SqliteClienteRepository()
        {
            _context = new SalonDbContext();
            // Asegura que la base de datos SQLite y la tabla de clientes existan
            _context.Database.EnsureCreated();
        }

        public void Add(Cliente cliente)
        {
            if (cliente == null)
            {
                throw new ArgumentNullException(nameof(cliente));
            }

            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        public IEnumerable<Cliente> GetAll()
        {
            List<Cliente> listaClientes = new List<Cliente>(_context.Clientes.ToList());
            return listaClientes;
        }

        public Cliente? GetById(int id)
        {
            Cliente? clienteEncontrado = _context.Clientes.Find(id);
            return clienteEncontrado;
        }

        public bool Update(Cliente clienteActualizado)
        {
            if (clienteActualizado == null)
            {
                return false;
            }

            Cliente? clienteExistente = GetById(clienteActualizado.Id);
            if (clienteExistente == null)
            {
                return false;
            }

            // Actualizamos propiedades de la entidad rastreada por EF Core
            clienteExistente.Nombre = clienteActualizado.Nombre;
            clienteExistente.Apellido = clienteActualizado.Apellido;
            clienteExistente.Telefono = clienteActualizado.Telefono;
            clienteExistente.Dni = clienteActualizado.Dni;
            clienteExistente.Email = clienteActualizado.Email;
            clienteExistente.Notas = clienteActualizado.Notas;

            int filasAfectadas = _context.SaveChanges();
            return filasAfectadas > 0;
        }

        public bool Remove(int id)
        {
            Cliente? clienteRemovido = GetById(id);
            if (clienteRemovido == null)
            {
                return false;
            }

            _context.Clientes.Remove(clienteRemovido);
            int filasAfectadas = _context.SaveChanges();
            return filasAfectadas > 0;
        }

        // --- Métodos de apoyo específicos optimizados ---

        public Cliente? GetByEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return null;
            }

            string emailBuscado = email.Trim().ToLower();
            return _context.Clientes.FirstOrDefault(c => c.Email.ToLower() == emailBuscado);
        }

        public bool ExistsByDni(string dni)
        {
            if (string.IsNullOrWhiteSpace(dni))
            {
                return false;
            }

            string dniBuscado = dni.Trim();
            return _context.Clientes.Any(c => c.Dni.Trim() == dniBuscado);
        }
    }
}