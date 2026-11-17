using Proyecto_Salon_de_Eventos.Dto;
using Proyecto_Salon_de_Eventos.Model;
using Proyecto_Salon_de_Eventos.Service;
using System;
using System.Collections.Generic;

namespace Proyecto_Salon_de_Eventos.Controller
{
    public class ItemMenuController
    {
        private readonly ItemMenuService _service = new ItemMenuService();

        // 1. Crear un ítem de menú
        public string CrearItemMenu(int cantidad, int menuId)
        {
            try
            {
                _service.CrearItemMenu(cantidad, menuId);
                return "Ítem de menú creado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al crear ítem de menú: " + ex.Message;
            }
        }

        // 2. Listar todos los ítems convertidos a DTO
        public IEnumerable<ItemMenuDto> ListarItemMenus()
        {
            List<ItemMenuDto> listaDtos = new List<ItemMenuDto>();

            foreach (ItemMenu item in _service.ObtenerItemMenus())
            {
                ItemMenuDto dto = new ItemMenuDto(
                    item.Id,
                    item.Cantidad,
                    item.Item.Id,
                    item.Item.Detalle,
                    item.Item.Precio,
                    item.CalcularSubtotal()
                );

                listaDtos.Add(dto);
            }

            return listaDtos;
        }

        // 3. Buscar ítem por ID
        public ItemMenuDto? BuscarItemMenu(int id)
        {
            ItemMenu? item = _service.BuscarItemMenu(id);

            if (item == null)
            {
                return null;
            }
            else
            {
                return new ItemMenuDto(
                    item.Id,
                    item.Cantidad,
                    item.Item.Id,
                    item.Item.Detalle,
                    item.Item.Precio,
                    item.CalcularSubtotal()
                );
            }
        }

        // 4. Actualizar ítem de menú
        public string ActualizarItemMenu(int id, int cantidad, int menuId)
        {
            try
            {
                bool actualizado = _service.ActualizarItemMenu(id, cantidad, menuId);

                if (actualizado)
                {
                    return "Ítem de menú actualizado correctamente.";
                }
                else
                {
                    return "No se pudo actualizar (el ítem o el menú asociado no existen).";
                }
            }
            catch (Exception ex)
            {
                return "Error al actualizar ítem de menú: " + ex.Message;
            }
        }

        // 5. Eliminar ítem de menú por ID
        public string EliminarItemMenu(int id)
        {
            bool eliminado = _service.EliminarItemMenu(id);

            if (eliminado)
            {
                return "Ítem de menú eliminado correctamente.";
            }
            else
            {
                return "No se encontró el ítem de menú.";
            }
        }
    }
}