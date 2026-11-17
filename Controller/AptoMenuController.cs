using Proyecto_Salon_de_Eventos.Dto;
using Proyecto_Salon_de_Eventos.Model;
using Proyecto_Salon_de_Eventos.Service;
using System;
using System.Collections.Generic;

namespace Proyecto_Salon_de_Eventos.Controller
{
    public class AptoMenuController
    {
        private readonly AptoMenuService _service = new AptoMenuService();

        // 1. Crear AptoMenu pasando parámetro individual
        public string CrearAptoMenu(string detalle)
        {
            try
            {
                AptoMenu aptoMenu = new AptoMenu(detalle);
                _service.CrearAptoMenu(aptoMenu);
                return "AptoMenu creado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al crear AptoMenu: " + ex.Message;
            }
        }

        // 2. Crear AptoMenu pasando un DTO desde la vista
        public string CrearAptoMenu(AptoMenuDto aptoMenuDto)
        {
            try
            {
                AptoMenu aptoMenu = new AptoMenu(aptoMenuDto.Detalle);
                _service.CrearAptoMenu(aptoMenu);
                return "AptoMenu creado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al crear AptoMenu: " + ex.Message;
            }
        }

        // 3. Listar todos los AptoMenu convertidos a DTO mediante un bucle foreach explícito
        public IEnumerable<AptoMenuDto> ListarAptosMenu()
        {
            List<AptoMenuDto> listaDtos = new List<AptoMenuDto>();

            foreach (AptoMenu apto in _service.ObtenerAptosMenu())
            {
                AptoMenuDto dto = new AptoMenuDto(
                    apto.Id,
                    apto.Detalle
                );

                listaDtos.Add(dto);
            }

            return listaDtos;
        }

        // 4. Buscar AptoMenu por ID usando un bloque if-else explícito
        public AptoMenuDto? BuscarAptoMenu(int id)
        {
            AptoMenu? apto = _service.BuscarAptoMenu(id);

            if (apto == null)
            {
                return null;
            }
            else
            {
                return new AptoMenuDto(
                    apto.Id,
                    apto.Detalle
                );
            }
        }

        // 5. Actualizar AptoMenu asignando el ID paso a paso
        public string ActualizarAptoMenu(int id, string detalle)
        {
            try
            {
                AptoMenu aptoMenu = new AptoMenu(detalle);
                aptoMenu.Id = id; // Asignamos el ID explícitamente

                bool actualizado = _service.ActualizarAptoMenu(aptoMenu);

                if (actualizado)
                {
                    return "AptoMenu actualizado correctamente.";
                }
                else
                {
                    return "AptoMenu no encontrado.";
                }
            }
            catch (Exception ex)
            {
                return "Error al actualizar AptoMenu: " + ex.Message;
            }
        }

        // 6. Eliminar AptoMenu por ID
        public string EliminarAptoMenu(int id)
        {
            bool eliminado = _service.EliminarAptoMenu(id);

            if (eliminado)
            {
                return "AptoMenu eliminado correctamente.";
            }
            else
            {
                return "No se encontró el AptoMenu.";
            }
        }
    }
}
