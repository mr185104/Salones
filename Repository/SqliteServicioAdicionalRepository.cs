using Microsoft.EntityFrameworkCore;
using Proyecto_Salon_de_Eventos.Data;
using Proyecto_Salon_de_Eventos.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Proyecto_Salon_de_Eventos.Repository.Sqlite
{
    public class SqliteServicioAdicionalRepository : IRepository<ServicioAdicional>
    {
        private readonly SalonDbContext _context;

        public SqliteServicioAdicionalRepository()
        {
            _context = new SalonDbContext();
            // Aseguramos que la base de datos esté creada al instanciar el repositorio
            _context.Database.EnsureCreated();
        }

        public void Add(ServicioAdicional servicio)
        {
            if (servicio == null)
            {
                throw new ArgumentNullException(nameof(servicio));
            }

            _context.ServiciosAdicionales.Add(servicio);
            _context.SaveChanges();
        }

        public IEnumerable<ServicioAdicional> GetAll()
        {
            List<ServicioAdicional> listaServicios = new List<ServicioAdicional>(_context.ServiciosAdicionales.ToList());
            return listaServicios;
        }

        public ServicioAdicional? GetById(int id)
        {
            ServicioAdicional? servicioEncontrado = _context.ServiciosAdicionales.Find(id);
            return servicioEncontrado;
        }

        public bool Update(ServicioAdicional servicioActualizado)
        {
            if (servicioActualizado == null)
            {
                return false;
            }

            ServicioAdicional? servicioExistente = GetById(servicioActualizado.Id);
            if (servicioExistente == null)
            {
                return false;
            }

            servicioExistente.Nombre = servicioActualizado.Nombre;
            servicioExistente.Precio = servicioActualizado.Precio;

            int filasAfectadas = _context.SaveChanges();
            return filasAfectadas > 0;
        }

        public bool Remove(int id)
        {
            ServicioAdicional? servicioRemovido = GetById(id);
            if (servicioRemovido == null)
            {
                return false;
            }

            _context.ServiciosAdicionales.Remove(servicioRemovido);
            int filasAfectadas = _context.SaveChanges();
            return filasAfectadas > 0;
        }

        public bool ExistsByNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                return false;
            }

            string nombreBuscado = nombre.Trim().ToLower();
            return _context.ServiciosAdicionales.Any(s => s.Nombre.Trim().ToLower() == nombreBuscado);
        }
    }
}