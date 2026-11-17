using Microsoft.EntityFrameworkCore;
using Proyecto_Salon_de_Eventos.Data;
using Proyecto_Salon_de_Eventos.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Proyecto_Salon_de_Eventos.Repository.Sqlite
{
    public class SqliteSalonRepository : IRepository<Salon>
    {
        private readonly SalonDbContext _context;

        public SqliteSalonRepository()
        {
            _context = new SalonDbContext();
            _context.Database.EnsureCreated();
        }

        public void Add(Salon salon)
        {
            if (salon == null)
            {
                throw new ArgumentNullException(nameof(salon));
            }

            _context.Salones.Add(salon);
            _context.SaveChanges();
        }

        public IEnumerable<Salon> GetAll()
        {
            List<Salon> listaSalones = new List<Salon>(_context.Salones.ToList());
            return listaSalones;
        }

        public Salon? GetById(int id)
        {
            Salon? salonEncontrado = _context.Salones.Find(id);
            return salonEncontrado;
        }

        public bool Update(Salon salonActualizado)
        {
            if (salonActualizado == null)
            {
                return false;
            }

            Salon? salonExistente = GetById(salonActualizado.Id);
            if (salonExistente == null)
            {
                return false;
            }

            salonExistente.Nombre = salonActualizado.Nombre;
            salonExistente.Direccion = salonActualizado.Direccion;
            salonExistente.Localidad = salonActualizado.Localidad;
            salonExistente.Capacidad = salonActualizado.Capacidad;
            salonExistente.Precio = salonActualizado.Precio;

            int filasAfectadas = _context.SaveChanges();
            return filasAfectadas > 0;
        }

        public bool Remove(int id)
        {
            Salon? salonRemovido = GetById(id);
            if (salonRemovido == null)
            {
                return false;
            }

            _context.Salones.Remove(salonRemovido);
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
            return _context.Salones.Any(s => s.Nombre.ToLower() == nombreBuscado);
        }
    }
}