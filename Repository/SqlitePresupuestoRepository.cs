using Microsoft.EntityFrameworkCore;
using Proyecto_Salon_de_Eventos.Data;
using Proyecto_Salon_de_Eventos.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Proyecto_Salon_de_Eventos.Repository.Sqlite
{
    public class SqlitePresupuestoRepository : IRepository<Presupuesto>
    {
        public SqlitePresupuestoRepository()
        {
            using (SalonDbContext context = new SalonDbContext())
            {
                context.Database.EnsureCreated();
            }
        }

        public void Add(Presupuesto presupuesto)
        {
            if (presupuesto == null)
            {
                throw new ArgumentNullException(nameof(presupuesto));
            }

            using (SalonDbContext context = new SalonDbContext())
            {
                if (presupuesto.Cliente != null)
                {
                    context.Clientes.Attach(presupuesto.Cliente);
                }

                if (presupuesto.Salon != null)
                {
                    context.Salones.Attach(presupuesto.Salon);
                }

                // Unificamos las referencias de los servicios adicionales para evitar duplicados de tracking
                if (presupuesto.ServiciosAdicionales != null)
                {
                    List<ServicioAdicional> serviciosUnificados = new List<ServicioAdicional>();

                    foreach (ServicioAdicional servicio in presupuesto.ServiciosAdicionales)
                    {
                        ServicioAdicional servicioTracked = context.ServiciosAdicionales.Local.FirstOrDefault(s => s.Id == servicio.Id);

                        if (servicioTracked == null)
                        {
                            servicioTracked = context.ServiciosAdicionales.Find(servicio.Id);

                            if (servicioTracked == null)
                            {
                                servicioTracked = servicio;
                                context.ServiciosAdicionales.Attach(servicioTracked);
                            }
                        }

                        serviciosUnificados.Add(servicioTracked);
                    }

                    presupuesto.ServiciosAdicionales = serviciosUnificados;
                }

                if (presupuesto.Menus != null)
                {
                    foreach (ItemMenu itemMenu in presupuesto.Menus)
                    {
                        if (itemMenu.Item != null)
                        {
                            Menu menuTracked = context.Menus.Local.FirstOrDefault(m => m.Id == itemMenu.Item.Id);
                            if (menuTracked == null)
                            {
                                menuTracked = context.Menus.Find(itemMenu.Item.Id);
                                if (menuTracked == null)
                                {
                                    context.Menus.Attach(itemMenu.Item);
                                }
                                else
                                {
                                    itemMenu.Item = menuTracked;
                                }
                            }
                            else
                            {
                                itemMenu.Item = menuTracked;
                            }
                        }
                    }
                }

                context.Presupuestos.Add(presupuesto);
                context.SaveChanges();
            }
        }

        public IEnumerable<Presupuesto> GetAll()
        {
            using (SalonDbContext context = new SalonDbContext())
            {
                List<Presupuesto> listaPresupuestos = context.Presupuestos
                    .Include(p => p.Cliente)
                    .Include(p => p.Salon)
                    .Include(p => p.Menus)
                        .ThenInclude(im => im.Item)
                    .Include(p => p.ServiciosAdicionales)
                    .ToList();

                return listaPresupuestos;
            }
        }

        public Presupuesto? GetById(int id)
        {
            using (SalonDbContext context = new SalonDbContext())
            {
                Presupuesto presupuesto = context.Presupuestos
                    .Include(p => p.Cliente)
                    .Include(p => p.Salon)
                    .Include(p => p.Menus)
                        .ThenInclude(im => im.Item)
                    .Include(p => p.ServiciosAdicionales)
                    .FirstOrDefault(p => p.Id == id);

                return presupuesto;
            }
        }

        public bool Update(Presupuesto presupuestoActualizado)
        {
            if (presupuestoActualizado == null)
            {
                return false;
            }

            if (presupuestoActualizado.Id == 0)
            {
                System.Diagnostics.Debug.WriteLine("Error: Se intentó actualizar un presupuesto con ID 0.");
                return false;
            }

            using (SalonDbContext context = new SalonDbContext())
            {
                Presupuesto presupuestoExistente = context.Presupuestos
                    .Include(p => p.Menus)
                        .ThenInclude(im => im.Item)
                    .Include(p => p.ServiciosAdicionales)
                    .FirstOrDefault(p => p.Id == presupuestoActualizado.Id);

                if (presupuestoExistente == null)
                {
                    return false;
                }

                presupuestoExistente.FechaPresupuesto = presupuestoActualizado.FechaPresupuesto;
                presupuestoExistente.FechaEvento = presupuestoActualizado.FechaEvento;
                presupuestoExistente.Estado = presupuestoActualizado.Estado;
                presupuestoExistente.Duracion = presupuestoActualizado.Duracion;

                if (presupuestoActualizado.Cliente != null)
                {
                    Cliente clienteTracked = context.Clientes.Local.FirstOrDefault(c => c.Id == presupuestoActualizado.Cliente.Id);
                    if (clienteTracked == null)
                    {
                        clienteTracked = context.Clientes.Find(presupuestoActualizado.Cliente.Id);
                        if (clienteTracked == null)
                        {
                            context.Clientes.Attach(presupuestoActualizado.Cliente);
                            clienteTracked = presupuestoActualizado.Cliente;
                        }
                    }
                    presupuestoExistente.Cliente = clienteTracked;
                }

                if (presupuestoActualizado.Salon != null)
                {
                    Salon salonTracked = context.Salones.Local.FirstOrDefault(s => s.Id == presupuestoActualizado.Salon.Id);
                    if (salonTracked == null)
                    {
                        salonTracked = context.Salones.Find(presupuestoActualizado.Salon.Id);
                        if (salonTracked == null)
                        {
                            context.Salones.Attach(presupuestoActualizado.Salon);
                            salonTracked = presupuestoActualizado.Salon;
                        }
                    }
                    presupuestoExistente.Salon = salonTracked;
                }

                // Sincronización de Menús
                List<ItemMenu> menusAEliminar = presupuestoExistente.Menus
                    .Where(mExistente => !presupuestoActualizado.Menus.Any(mNuevo => mNuevo.Id == mExistente.Id))
                    .ToList();

                foreach (ItemMenu menu in menusAEliminar)
                {
                    context.ItemMenus.Remove(menu);
                }

                foreach (ItemMenu menuNuevo in presupuestoActualizado.Menus)
                {
                    ItemMenu menuExistente = presupuestoExistente.Menus
                        .FirstOrDefault(m => m.Id == menuNuevo.Id && m.Id != 0);

                    if (menuExistente == null)
                    {
                        if (menuNuevo.Item != null)
                        {
                            Menu itemTracked = context.Menus.Local.FirstOrDefault(m => m.Id == menuNuevo.Item.Id);
                            if (itemTracked == null)
                            {
                                itemTracked = context.Menus.Find(menuNuevo.Item.Id);
                                if (itemTracked == null)
                                {
                                    context.Menus.Attach(menuNuevo.Item);
                                }
                                else
                                {
                                    menuNuevo.Item = itemTracked;
                                }
                            }
                            else
                            {
                                menuNuevo.Item = itemTracked;
                            }
                        }
                        presupuestoExistente.Menus.Add(menuNuevo);
                    }
                    else
                    {
                        menuExistente.Cantidad = menuNuevo.Cantidad;
                        if (menuNuevo.Item != null)
                        {
                            Menu itemTracked = context.Menus.Local.FirstOrDefault(m => m.Id == menuNuevo.Item.Id);
                            if (itemTracked == null)
                            {
                                itemTracked = context.Menus.Find(menuNuevo.Item.Id);
                                if (itemTracked == null)
                                {
                                    context.Menus.Attach(menuNuevo.Item);
                                    menuExistente.Item = menuNuevo.Item;
                                }
                                else
                                {
                                    menuExistente.Item = itemTracked;
                                }
                            }
                            else
                            {
                                menuExistente.Item = itemTracked;
                            }
                        }
                    }
                }

                // Sincronización segura de Servicios Adicionales (permitiendo repeticiones con referencias unificadas)
                presupuestoExistente.ServiciosAdicionales.Clear();

                foreach (ServicioAdicional servicioNuevo in presupuestoActualizado.ServiciosAdicionales)
                {
                    ServicioAdicional servicioTracked = context.ServiciosAdicionales.Local.FirstOrDefault(s => s.Id == servicioNuevo.Id);

                    if (servicioTracked == null)
                    {
                        servicioTracked = context.ServiciosAdicionales.Find(servicioNuevo.Id);

                        if (servicioTracked == null)
                        {
                            context.ServiciosAdicionales.Attach(servicioNuevo);
                            servicioTracked = servicioNuevo;
                        }
                    }

                    presupuestoExistente.ServiciosAdicionales.Add(servicioTracked);
                }

                int filasAfectadas = context.SaveChanges();
                return filasAfectadas > 0;
            }
        }

        public bool Remove(int id)
        {
            using (SalonDbContext context = new SalonDbContext())
            {
                Presupuesto presupuestoRemovido = context.Presupuestos.Find(id);
                if (presupuestoRemovido == null)
                {
                    return false;
                }

                context.Presupuestos.Remove(presupuestoRemovido);
                int filasAfectadas = context.SaveChanges();
                return filasAfectadas > 0;
            }
        }
    }
}