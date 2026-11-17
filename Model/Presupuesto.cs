using System;
using System.Collections.Generic;

namespace Proyecto_Salon_de_Eventos.Model
{
    public enum Estado
    {
        CERRADO,
        PREPARACION,
        ENVIADO,
        APROBADO
    }

    public class Presupuesto
    {
        private int _id;
        private DateOnly _fechaPresupuesto;
        private DateOnly _fechaEvento;
        private Cliente _cliente;
        private Estado _estado;
        private int _duracion; // Cambiado a int para representar las horas (1 a 12)
        private Salon _salon;
        private List<ItemMenu> _menus;
        private List<ServicioAdicional> _serviciosAdicionales;

        public int Id
        {
            get { return _id; }
            set { _id = value >= 0 ? value : 0; }
        }

        public DateOnly FechaPresupuesto
        {
            get { return _fechaPresupuesto; }
            set { _fechaPresupuesto = value; }
        }

        public DateOnly FechaEvento
        {
            get { return _fechaEvento; }
            set
            {
                if (value < FechaPresupuesto)
                {
                    throw new ArgumentException("La fecha del evento no puede ser anterior al presupuesto.");
                }
                _fechaEvento = value;
            }
        }

        public Cliente Cliente
        {
            get { return _cliente; }
            set
            {
                ArgumentNullException.ThrowIfNull(value);
                _cliente = value;
            }
        }

        public Estado Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        // 👉 REGLA DE NEGOCIO: Duración en horas estrictamente entre 1 y 12
        public int Duracion
        {
            get { return _duracion; }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("La duración del evento debe ser un valor entre 1 y 12 horas.");
                }
                _duracion = value;
            }
        }

        public Salon Salon
        {
            get { return _salon; }
            set { _salon = value ?? new Salon(); }
        }

        public List<ItemMenu> Menus
        {
            get { return _menus; }
            set { _menus = value ?? new List<ItemMenu>(); }
        }

        public List<ServicioAdicional> ServiciosAdicionales
        {
            get { return _serviciosAdicionales; }
            set { _serviciosAdicionales = value ?? new List<ServicioAdicional>(); }
        }

        // Constructor por defecto
        public Presupuesto()
        {
            _id = 0;
            _fechaPresupuesto = DateOnly.FromDateTime(DateTime.Now);
            _fechaEvento = DateOnly.FromDateTime(DateTime.Now.AddMonths(1));
            _cliente = new Cliente();
            _estado = Estado.PREPARACION;
            _duracion = 4; // Valor por defecto seguro dentro del rango (ej: 4 horas)
            _salon = new Salon();
            _menus = new List<ItemMenu>();
            _serviciosAdicionales = new List<ServicioAdicional>();
        }

        // Constructor parametrizado original (sin ID)
        public Presupuesto(DateOnly fechaPresupuesto, DateOnly fechaEvento, Cliente cliente, Estado estado, int duracion, Salon salon)
        {
            _id = 0;
            FechaPresupuesto = fechaPresupuesto;
            FechaEvento = fechaEvento;
            Cliente = cliente;
            Estado = estado;
            Duracion = duracion; // Pasa por el setter validando el rango 1-12
            Salon = salon;
            Menus = new List<ItemMenu>();
            ServiciosAdicionales = new List<ServicioAdicional>();
        }

        // Constructor parametrizado con ID (para repositorio)
        public Presupuesto(int id, DateOnly fechaPresupuesto, DateOnly fechaEvento, Cliente cliente, Estado estado, int duracion, Salon salon)
        {
            Id = id;
            FechaPresupuesto = fechaPresupuesto;
            FechaEvento = fechaEvento;
            Cliente = cliente;
            Estado = estado;
            Duracion = duracion; // Pasa por el setter validando el rango 1-12
            Salon = salon;
            Menus = new List<ItemMenu>();
            ServiciosAdicionales = new List<ServicioAdicional>();
        }

        public Presupuesto Clonar()
        {
            Presupuesto clon = new Presupuesto(Id, FechaPresupuesto, FechaEvento, Cliente, Estado, Duracion, Salon);
            clon.Menus = new List<ItemMenu>(Menus);
            clon.ServiciosAdicionales = new List<ServicioAdicional>(ServiciosAdicionales);
            return clon;
        }

        public decimal CalcularTotal()
        {
            decimal totalMenus = 0m;
            foreach (ItemMenu itemMenu in Menus)
            {
                totalMenus += itemMenu.CalcularSubtotal();
            }

            decimal totalServicios = 0m;
            foreach (ServicioAdicional servicio in ServiciosAdicionales)
            {
                totalServicios += servicio.CalcularSubtotal(1);
            }

            decimal precioSalon = Salon != null ? Salon.Precio : 0m;
            return totalMenus + totalServicios + precioSalon;
        }

        public decimal CalcularGanancia()
        {
            return CalcularTotal() * 0.20m;
        }

        public void CambiarEstado(Estado nuevoEstado)
        {
            Estado = nuevoEstado;
        }

        public int CalcularTotalInvitados()
        {
            int totalInvitados = 0;
            foreach (ItemMenu itemMenu in Menus)
            {
                totalInvitados += itemMenu.Cantidad;
            }
            return totalInvitados;
        }

        public override string ToString()
        {
            return "Presupuesto #" + Id + " para " + Cliente.Nombre + " | Evento: " + FechaEvento + " | Estado: " + Estado + " | Total: $" + CalcularTotal();
        }
    }
}