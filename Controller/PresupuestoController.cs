using Proyecto_Salon_de_Eventos.Dto;
using Proyecto_Salon_de_Eventos.Model;
using Proyecto_Salon_de_Eventos.Service;
using System;
using System.Collections.Generic;

namespace Proyecto_Salon_de_Eventos.Controller
{
    public class PresupuestoController
    {
        private readonly PresupuestoService _service = new PresupuestoService();

        // 1. Método único y unificado para Crear (recibe el Presupuesto completo)
        public string CrearPresupuesto(Presupuesto presupuesto)
        {
            try
            {
                presupuesto.Id = 0; // Forzamos 0 para que la base de datos autoincremente
                _service.CrearPresupuesto(presupuesto);
                return "Presupuesto creado correctamente.";
            }
            catch (Exception ex)
            {
                return ManejarError("crear", ex);
            }
        }

        // 2. Método único y unificado para Actualizar (recibe el Presupuesto completo)
        public string ActualizarPresupuesto(Presupuesto presupuesto)
        {
            try
            {
                bool actualizado = _service.ActualizarPresupuesto(presupuesto);

                if (actualizado)
                {
                    return "Presupuesto actualizado correctamente.";
                }
                else
                {
                    return "Presupuesto no encontrado.";
                }
            }
            catch (Exception ex)
            {
                return ManejarError("actualizar", ex);
            }
        }

        // 3. Listar todos los presupuestos mapeados a DTO (para la grilla principal)
        public IEnumerable<PresupuestoDto> ListarPresupuestos()
        {
            List<PresupuestoDto> listaDtos = new List<PresupuestoDto>();

            foreach (Presupuesto presupuesto in _service.ObtenerPresupuestos())
            {
                string nombreCliente = presupuesto.Cliente != null ? presupuesto.Cliente.Nombre : "Sin cliente";
                string nombreSalon = presupuesto.Salon != null ? presupuesto.Salon.Nombre : "Sin salón";

                PresupuestoDto dto = new PresupuestoDto(
                    presupuesto.Id,
                    presupuesto.FechaPresupuesto,
                    presupuesto.FechaEvento,
                    nombreCliente,
                    presupuesto.Estado,
                    presupuesto.Duracion,
                    nombreSalon,
                    presupuesto.CalcularTotal(),
                    presupuesto.CalcularGanancia(),
                    presupuesto.CalcularTotalInvitados()
                );

                listaDtos.Add(dto);
            }

            return listaDtos;
        }

        // 4. Buscar presupuesto por ID (mapeado a DTO)
        public PresupuestoDto? BuscarPresupuesto(int id)
        {
            Presupuesto? presupuesto = _service.BuscarPresupuesto(id);

            if (presupuesto == null)
            {
                return null;
            }
            else
            {
                string nombreCliente = presupuesto.Cliente != null ? presupuesto.Cliente.Nombre : "Sin cliente";
                string nombreSalon = presupuesto.Salon != null ? presupuesto.Salon.Nombre : "Sin salón";

                return new PresupuestoDto(
                    presupuesto.Id,
                    presupuesto.FechaPresupuesto,
                    presupuesto.FechaEvento,
                    nombreCliente,
                    presupuesto.Estado,
                    presupuesto.Duracion,
                    nombreSalon,
                    presupuesto.CalcularTotal(),
                    presupuesto.CalcularGanancia(),
                    presupuesto.CalcularTotalInvitados()
                );
            }
        }

        // 4.1. Buscar modelo de presupuesto puro por ID (para editar en la View)
        public Presupuesto? BuscarModeloPresupuestoPorId(int id)
        {
            return _service.BuscarPresupuesto(id);
        }

        // 5. Eliminar presupuesto por ID
        public string EliminarPresupuesto(int id)
        {
            bool eliminado = _service.EliminarPresupuesto(id);

            if (eliminado)
            {
                return "Presupuesto eliminado correctamente.";
            }
            else
            {
                return "No se encontró el presupuesto.";
            }
        }

        // Método auxiliar privado para formatear los errores con InnerException de forma limpia
        private string ManejarError(string operacion, Exception ex)
        {
            string detalle = ex.Message;
            if (ex.InnerException != null)
            {
                detalle += " --> Inner: " + ex.InnerException.Message;
                if (ex.InnerException.InnerException != null)
                {
                    detalle += " --> Detalle: " + ex.InnerException.InnerException.Message;
                }
            }
            return $"Error al {operacion} presupuesto: " + detalle;
        }
    }
}