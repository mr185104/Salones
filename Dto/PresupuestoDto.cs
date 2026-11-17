using System;
using Proyecto_Salon_de_Eventos.Model;

namespace Proyecto_Salon_de_Eventos.Dto
{
    public class PresupuestoDto
    {
        public int Id { get; set; }
        public DateOnly FechaPresupuesto { get; set; }
        public DateOnly FechaEvento { get; set; }
        public string NombreCliente { get; set; }
        public Estado Estado { get; set; }
        public int Duracion { get; set; }
        public string NombreSalon { get; set; }
        public decimal Total { get; set; }
        public decimal Ganancia { get; set; }
        public int TotalInvitados { get; set; }

        public PresupuestoDto()
        {
            Id = 0;
            FechaPresupuesto = DateOnly.FromDateTime(DateTime.Now);
            FechaEvento = DateOnly.FromDateTime(DateTime.Now.AddMonths(1));
            NombreCliente = string.Empty;
            Estado = Estado.PREPARACION;
            Duracion = 1;
            NombreSalon = string.Empty;
            Total = 0m;
            Ganancia = 0m;
            TotalInvitados = 0;
        }

        public PresupuestoDto(int id, DateOnly fechaPresupuesto, DateOnly fechaEvento, string nombreCliente, Estado estado, int duracion, string nombreSalon, decimal total, decimal ganancia, int totalInvitados)
        {
            Id = id;
            FechaPresupuesto = fechaPresupuesto;
            FechaEvento = fechaEvento;
            NombreCliente = nombreCliente;
            Estado = estado;
            Duracion = duracion;
            NombreSalon = nombreSalon;
            Total = total;
            Ganancia = ganancia;
            TotalInvitados = totalInvitados;
        }

        public override string ToString()
        {
            return "Presupuesto #" + Id + " - Cliente: " + NombreCliente + " | Evento: " + FechaEvento + " | Estado: " + Estado + " | Total: $" + Total;
        }
    }
}