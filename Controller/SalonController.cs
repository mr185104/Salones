using Proyecto_Salon_de_Eventos.Dto;
using Proyecto_Salon_de_Eventos.Model;
using Proyecto_Salon_de_Eventos.Service;
using System;
using System.Collections.Generic;

namespace Proyecto_Salon_de_Eventos.Controller
{
    public class SalonController
    {
        private readonly SalonService _service;

        public SalonController(SalonService? service = null)
        {
            if (service != null)
            {
                _service = service;
            }
            else
            {
                _service = new SalonService();
            }
        }

        public string CrearSalon(SalonDto salonDto)
        {
            try
            {
                Salon salon = new Salon(
                    salonDto.Nombre,
                    salonDto.Direccion,
                    salonDto.Localidad,
                    salonDto.Capacidad,
                    salonDto.Precio
                );

                _service.CrearSalon(salon);
                return "Salón creado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al crear el salón: " + ex.Message;
            }
        }

        public string ActualizarSalon(SalonDto salonDto)
        {
            try
            {
                Salon salon = new Salon(
                    salonDto.Nombre,
                    salonDto.Direccion,
                    salonDto.Localidad,
                    salonDto.Capacidad,
                    salonDto.Precio
                );

                salon.Id = salonDto.Id;

                // Como ahora es void, si falla lanzará una excepción que atrapa el catch
                _service.ActualizarSalon(salon);

                return "Salón actualizado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al actualizar el salón: " + ex.Message;
            }
        }

        public string EliminarSalon(int id)
        {
            try
            {
                // Si no existe o tiene presupuestos asociados, el service lanzará la excepción
                _service.EliminarSalon(id);

                return "Salón eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el salón: " + ex.Message;
            }
        }

        public IEnumerable<SalonDto> ListarSalones()
        {
            List<SalonDto> listaDtos = new List<SalonDto>();

            foreach (Salon salon in _service.ObtenerSalones())
            {
                SalonDto dto = new SalonDto(
                    salon.Id,
                    salon.Nombre,
                    salon.Direccion,
                    salon.Localidad,
                    salon.Capacidad,
                    salon.Precio
                );

                listaDtos.Add(dto);
            }

            return listaDtos;
        }

        public SalonDto? BuscarSalon(int id)
        {
            Salon? salon = _service.BuscarSalon(id);

            if (salon == null)
            {
                return null;
            }

            return new SalonDto(
                salon.Id,
                salon.Nombre,
                salon.Direccion,
                salon.Localidad,
                salon.Capacidad,
                salon.Precio
            );
        }
    }
}