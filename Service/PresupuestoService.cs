using Proyecto_Salon_de_Eventos.Data; // 👈 Asegúrate de tener este using
using Proyecto_Salon_de_Eventos.Model;
using Proyecto_Salon_de_Eventos.Repository;
using Proyecto_Salon_de_Eventos.Repository.Sqlite;
using Microsoft.EntityFrameworkCore; // 👈 Necesario para .Include()
using System;
using System.Collections.Generic;
using System.Linq;

namespace Proyecto_Salon_de_Eventos.Service
{
    public class PresupuestoService
    {
        private readonly IRepository<Presupuesto> _repository;

        public PresupuestoService(IRepository<Presupuesto>? repository = null)
        {
            if (repository != null)
            {
                _repository = repository;
            }
            else
            {
                _repository = new SqlitePresupuestoRepository();
            }
        }

        public void CrearPresupuesto(Presupuesto presupuesto)
        {
            ValidarPresupuesto(presupuesto);

            _repository.Add(presupuesto);
        }

        public IEnumerable<Presupuesto> ObtenerPresupuestos()
        {
            return _repository.GetAll();
        }

        public Presupuesto? BuscarPresupuesto(int id)
        {
            return _repository.GetById(id);
        }

        public bool ActualizarPresupuesto(Presupuesto presupuesto)
        {
            ValidarPresupuesto(presupuesto);

            return _repository.Update(presupuesto);
        }

        // --- MÉTODO CORREGIDO PARA ELIMINAR CON SUS RELACIONES ---
        public bool EliminarPresupuesto(int id)
        {
            using (SalonDbContext context = new SalonDbContext())
            {
                // 1. Buscamos el presupuesto incluyendo sus relaciones hijas para evitar bloqueos de FK
                Presupuesto presupuestoAEliminar = context.Presupuestos
                    .Include(p => p.Menus)
                    .Include(p => p.ServiciosAdicionales)
                    .FirstOrDefault(p => p.Id == id);

                if (presupuestoAEliminar == null)
                {
                    return false;
                }

                // 2. Removemos explícitamente los ítems de menú dependientes
                if (presupuestoAEliminar.Menus != null)
                {
                    context.Set<ItemMenu>().RemoveRange(presupuestoAEliminar.Menus);
                }

                // 3. Removemos el presupuesto principal de la base de datos
                context.Presupuestos.Remove(presupuestoAEliminar);
                context.SaveChanges();

                return true;
            }
        }

        private void ValidarPresupuesto(Presupuesto presupuesto)
        {
            if (presupuesto == null)
            {
                throw new ArgumentNullException(nameof(presupuesto),
                    "El presupuesto no puede ser nulo.");
            }

            if (presupuesto.Cliente == null)
            {
                throw new ArgumentException(
                    "Debe seleccionar un cliente.");
            }

            if (string.IsNullOrWhiteSpace(presupuesto.Cliente.Dni))
            {
                throw new ArgumentException(
                    "El cliente seleccionado no es válido.");
            }

            if (presupuesto.Salon == null)
            {
                throw new ArgumentException(
                    "Debe seleccionar un salón.");
            }

            if (string.IsNullOrWhiteSpace(presupuesto.Salon.Nombre))
            {
                throw new ArgumentException(
                    "El salón seleccionado no es válido.");
            }

            if (presupuesto.CalcularTotalInvitados() > presupuesto.Salon.Capacidad)
            {
                throw new ArgumentException(
                    $"La cantidad de invitados ({presupuesto.CalcularTotalInvitados()}) supera la capacidad del salón seleccionado ({presupuesto.Salon.Capacidad}).");
            }

            if (presupuesto.Duracion < 1 ||
                presupuesto.Duracion > 12)
            {
                throw new ArgumentException(
                    "La duración debe estar entre 1 y 12 horas.");
            }

            if (presupuesto.FechaEvento <
                DateOnly.FromDateTime(DateTime.Today))
            {
                throw new ArgumentException(
                    "La fecha del evento no puede ser anterior a la fecha actual.");
            }

            if (presupuesto.FechaPresupuesto >
                presupuesto.FechaEvento)
            {
                throw new ArgumentException(
                    "La fecha del presupuesto no puede ser posterior a la fecha del evento.");
            }

            // Validación de servicios adicionales únicos (evita duplicados de ID a nivel de negocio)
            if (presupuesto.ServiciosAdicionales != null && presupuesto.ServiciosAdicionales.Count > 0)
            {
                List<int> idsVerificados = new List<int>();

                foreach (ServicioAdicional servicio in presupuesto.ServiciosAdicionales)
                {
                    if (idsVerificados.Contains(servicio.Id))
                    {
                        throw new ArgumentException(
                            $"El servicio adicional '{servicio.Nombre}' está duplicado en el presupuesto.");
                    }

                    idsVerificados.Add(servicio.Id);
                }
            }
        }
    }
}