using Proyecto_Salon_de_Eventos.Dto;
using Proyecto_Salon_de_Eventos.Model;
using Proyecto_Salon_de_Eventos.Service;
using System;
using System.Collections.Generic;

namespace Proyecto_Salon_de_Eventos.Controller
{
    public class ServicioAdicionalController
    {
        private readonly ServicioAdicionalService _service = new ServicioAdicionalService();

        // 1. Crear servicio pasando parámetros
        public string CrearServicioAdicional(string nombre, decimal precio)
        {
            try
            {
                // CORRECCIÓN: Pasamos 0 en lugar de 1 para que SQLite autoincremente el ID
                ServicioAdicional servicio = new ServicioAdicional(0, nombre, precio);
                _service.CrearServicioAdicional(servicio);
                return "Servicio adicional creado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al crear servicio adicional: " + ex.Message;
            }
        }

        // 2. Crear servicio pasando un DTO desde la vista
        public string CrearServicioAdicional(ServicioAdicionalDto dto)
        {
            try
            {
                // CORRECCIÓN: Pasamos 0 para asegurarnos de que sea una inserción nueva
                ServicioAdicional servicio = new ServicioAdicional(0, dto.Nombre, dto.Precio);
                _service.CrearServicioAdicional(servicio);
                return "Servicio adicional creado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al crear servicio adicional: " + ex.Message;
            }
        }

        // 3. Listar todos los servicios convertidos a DTO
        public IEnumerable<ServicioAdicionalDto> ListarServiciosAdicionales()
        {
            List<ServicioAdicionalDto> listaDtos = new List<ServicioAdicionalDto>();

            foreach (ServicioAdicional servicio in _service.ObtenerServiciosAdicionales())
            {
                ServicioAdicionalDto dto = new ServicioAdicionalDto(
                    servicio.Id,
                    servicio.Nombre,
                    servicio.Precio
                );

                listaDtos.Add(dto);
            }

            return listaDtos;
        }

        // 4. Buscar servicio por ID
        public ServicioAdicionalDto? BuscarServicioAdicional(int id)
        {
            ServicioAdicional? servicio = _service.BuscarServicioAdicional(id);

            if (servicio == null)
            {
                return null;
            }
            else
            {
                return new ServicioAdicionalDto(
                    servicio.Id,
                    servicio.Nombre,
                    servicio.Precio
                );
            }
        }

        // 5. Actualizar servicio (Aquí sí se usa el id real porque es un Update)
        public string ActualizarServicioAdicional(int id, string nombre, decimal precio)
        {
            try
            {
                ServicioAdicional servicio = new ServicioAdicional(id, nombre, precio);
                bool actualizado = _service.ActualizarServicioAdicional(servicio);

                if (actualizado)
                {
                    return "Servicio adicional actualizado correctamente.";
                }
                else
                {
                    return "Servicio adicional no encontrado.";
                }
            }
            catch (Exception ex)
            {
                return "Error al actualizar servicio adicional: " + ex.Message;
            }
        }

        // 6. Eliminar servicio por ID
        public string EliminarServicioAdicional(int id)
        {
            bool eliminado = _service.EliminarServicioAdicional(id);

            if (eliminado)
            {
                return "Servicio adicional eliminado correctamente.";
            }
            else
            {
                return "No se encontró el servicio adicional.";
            }
        }
    }
}