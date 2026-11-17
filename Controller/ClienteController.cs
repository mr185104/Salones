using Proyecto_Salon_de_Eventos.Dto;
using Proyecto_Salon_de_Eventos.Model;
using Proyecto_Salon_de_Eventos.Service;
using System;
using System.Collections.Generic;

namespace Proyecto_Salon_de_Eventos.Controller
{
    public class ClienteController
    {
        private readonly ClienteService _service = new ClienteService();

        public void CrearCliente(string nombre, string apellido, string telefono, string dni, string email, string notas = "")
        {
            Cliente cliente = new Cliente(nombre, apellido, telefono, dni, email, notas);
            _service.CrearCliente(cliente);
        }

        public void CrearCliente(ClienteDto clienteDto)
        {
            Cliente cliente = new Cliente(
                clienteDto.Nombre,
                clienteDto.Apellido,
                clienteDto.Telefono,
                clienteDto.Dni,
                clienteDto.Email,
                clienteDto.Notas
            );

            _service.CrearCliente(cliente);
        }

        public IEnumerable<ClienteDto> ListarClientes()
        {
            List<ClienteDto> listaDtos = new List<ClienteDto>();

            foreach (Cliente cliente in _service.ObtenerClientes())
            {
                ClienteDto dto = new ClienteDto(
                    cliente.Id,
                    cliente.Nombre,
                    cliente.Apellido,
                    cliente.Telefono,
                    cliente.Dni,
                    cliente.Email,
                    cliente.Notas
                );

                listaDtos.Add(dto);
            }

            return listaDtos;
        }

        public ClienteDto? BuscarCliente(int id)
        {
            Cliente? cliente = _service.BuscarCliente(id);

            if (cliente == null)
            {
                return null;
            }

            return new ClienteDto(
                cliente.Id,
                cliente.Nombre,
                cliente.Apellido,
                cliente.Telefono,
                cliente.Dni,
                cliente.Email,
                cliente.Notas
            );
        }

        public void ActualizarCliente(int id, string nombre, string apellido, string telefono, string dni, string email, string notas)
        {
            Cliente cliente = new Cliente(nombre, apellido, telefono, dni, email, notas);
            cliente.Id = id;

            _service.ActualizarCliente(cliente);
        }

        public void EliminarCliente(int id)
        {
            _service.EliminarCliente(id);
        }
    }
}