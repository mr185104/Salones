using Proyecto_Salon_de_Eventos.Dto;
using Proyecto_Salon_de_Eventos.Model;
using Proyecto_Salon_de_Eventos.Service;
using System;
using System.Collections.Generic;

namespace Proyecto_Salon_de_Eventos.Controller
{
    public class MenuController
    {
        private readonly MenuService _service = new MenuService();

        // 1. Crear menú pasando parámetros individuales
        public string CrearMenu(string nombre, string detalle, decimal precio, bool esAdulto, List<AptoMenu>? aptosMenu = null)
        {
            try
            {
                Menu menu = new Menu(nombre, detalle, precio, esAdulto, aptosMenu);
                _service.CrearMenu(menu);
                return "Menú creado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al crear menú: " + ex.Message;
            }
        }

        // 2. Crear menú pasando un DTO desde la vista
        public string CrearMenu(MenuDto menuDto)
        {
            try
            {
                Menu menu = new Menu(
                    menuDto.Nombre,
                    menuDto.Detalle,
                    menuDto.Precio,
                    menuDto.EsAdulto,
                    menuDto.AptosMenu
                );

                _service.CrearMenu(menu);
                return "Menú creado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al crear menú: " + ex.Message;
            }
        }

        // 3. Listar todos los menús convertidos a DTO mediante un bucle foreach explícito
        public IEnumerable<MenuDto> ListarMenus()
        {
            List<MenuDto> listaDtos = new List<MenuDto>();

            foreach (Menu menu in _service.ObtenerMenus())
            {
                MenuDto dto = new MenuDto(
                    menu.Id,
                    menu.Nombre,
                    menu.Detalle,
                    menu.Precio,
                    menu.EsAdulto,
                    menu.AptosMenu
                );

                listaDtos.Add(dto);
            }

            return listaDtos;
        }

        // 4. Buscar menú por ID usando un bloque if-else explícito
        public MenuDto? BuscarMenu(int id)
        {
            Menu? menu = _service.BuscarMenu(id);

            if (menu == null)
            {
                return null;
            }
            else
            {
                return new MenuDto(
                    menu.Id,
                    menu.Nombre,
                    menu.Detalle,
                    menu.Precio,
                    menu.EsAdulto,
                    menu.AptosMenu
                );
            }
        }

        // 5. Actualizar menú asignando el ID paso a paso
        public string ActualizarMenu(int id, string nombre, string detalle, decimal precio, bool esAdulto, List<AptoMenu> aptosMenu)
        {
            try
            {
                Menu menu = new Menu(nombre, detalle, precio, esAdulto, aptosMenu);
                menu.Id = id; // Asignamos el ID explícitamente

                bool actualizado = _service.ActualizarMenu(menu);

                if (actualizado)
                {
                    return "Menú actualizado correctamente.";
                }
                else
                {
                    return "Menú no encontrado.";
                }
            }
            catch (Exception ex)
            {
                return "Error al actualizar menú: " + ex.Message;
            }
        }

        // 6. Eliminar menú por ID
        public string EliminarMenu(int id)
        {
            bool eliminado = _service.EliminarMenu(id);

            if (eliminado)
            {
                return "Menú eliminado correctamente.";
            }
            else
            {
                return "No se encontró el menú.";
            }
        }
    }
}
