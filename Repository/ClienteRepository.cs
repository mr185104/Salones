using Proyecto_Salon_de_Eventos.Model;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;

namespace Proyecto_Salon_de_Eventos.Repository
{
    public class ClienteRepository : IRepository<Cliente>
    {
        // Contador atómico para asegurar un ID único en entornos multihilo
        private static int _nextId = 1;

        // Estructura de datos segura para concurrencia que simula la base de datos en memoria
        private static readonly ConcurrentDictionary<int, Cliente> _clientes = new ConcurrentDictionary<int, Cliente>();

        public void Add(Cliente cliente)
        {
            // Asignamos el ID actual e incrementamos el contador de forma segura
            cliente.Id = Interlocked.Increment(ref _nextId) - 1;

            // Agregamos el cliente usando su ID como clave
            _clientes.TryAdd(cliente.Id, cliente);
        }

        public IEnumerable<Cliente> GetAll()
        {
            // Retorna todos los objetos Cliente guardados en el diccionario
            return _clientes.Values;
        }

        public Cliente? GetById(int id)
        {
            // Intentamos obtener el cliente por su clave de forma segura
            Cliente? clienteEncontrado;
            _clientes.TryGetValue(id, out clienteEncontrado);

            return clienteEncontrado;
        }

        public bool Update(Cliente clienteActualizado)
        {
            // 1. Buscamos si el cliente existe antes de modificarlo
            Cliente? clienteExistente = GetById(clienteActualizado.Id);

            if (clienteExistente == null)
            {
                return false; // No se encontró el cliente a actualizar
            }

            // 2. Sobrescribimos sus propiedades
            clienteExistente.Nombre = clienteActualizado.Nombre;
            clienteExistente.Apellido = clienteActualizado.Apellido;
            clienteExistente.Telefono = clienteActualizado.Telefono;
            clienteExistente.Dni = clienteActualizado.Dni;
            clienteExistente.Email = clienteActualizado.Email;
            clienteExistente.Notas = clienteActualizado.Notas;

            return true;
        }

        public bool Remove(int id)
        {
            // Intentamos remover la entrada usando el ID
            Cliente? clienteRemovido;
            bool resultado = _clientes.TryRemove(id, out clienteRemovido);

            return resultado;
        }

        // Métodos de apoyo específicos explicados con recorridos tradicionales

        public Cliente? GetByEmail(string email)
        {
            foreach (Cliente cliente in _clientes.Values)
            {
                if (cliente.Email.ToLower() == email.ToLower())
                {
                    return cliente; // Encontrado
                }
            }

            return null; // Si termina el bucle sin encontrar coincidencia
        }

        public bool ExistsByDni(string dni)
        {
            foreach (Cliente cliente in _clientes.Values)
            {
                if (cliente.Dni.Trim() == dni.Trim())
                {
                    return true; // Encontrado
                }
            }

            return false; // No existe
        }
    }
}