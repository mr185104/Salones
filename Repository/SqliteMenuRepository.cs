using Microsoft.EntityFrameworkCore;
using Proyecto_Salon_de_Eventos.Data;
using Proyecto_Salon_de_Eventos.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Proyecto_Salon_de_Eventos.Repository.Sqlite
{
    public class SqliteMenuRepository : IRepository<Menu>
    {
        private readonly SalonDbContext _context;

        public SqliteMenuRepository()
        {
            _context = new SalonDbContext();
            _context.Database.EnsureCreated();
        }

        public void Add(Menu menu)
        {
            if (menu == null)
            {
                throw new ArgumentNullException(nameof(menu));
            }

            _context.Menus.Add(menu);
            _context.SaveChanges();
        }

        public IEnumerable<Menu> GetAll()
        {
            // CORREGIDO: .Include(m => m.AptosMenu) trae las restricciones asociadas a cada menú
            List<Menu> listaMenus = new List<Menu>(_context.Menus.Include(m => m.AptosMenu).ToList());
            return listaMenus;
        }

        public Menu? GetById(int id)
        {
            // CORREGIDO: Usamos FirstOrDefault con Include para traer el menú con sus AptosMenu cargados
            Menu? menuEncontrado = _context.Menus
                                           .Include(m => m.AptosMenu)
                                           .FirstOrDefault(m => m.Id == id);
            return menuEncontrado;
        }

        public bool Update(Menu menuActualizado)
        {
            if (menuActualizado == null)
            {
                return false;
            }

            // Limpiamos el rastreador para descartar cualquier instancia previa con el mismo ID
            _context.ChangeTracker.Clear();

            // Indicamos a EF Core que actualice la entidad y sus relaciones
            _context.Menus.Update(menuActualizado);

            int filasAfectadas = _context.SaveChanges();
            return filasAfectadas > 0;
        }

        public bool Remove(int id)
        {
            Menu? menuRemovido = GetById(id);
            if (menuRemovido == null)
            {
                return false;
            }

            _context.Menus.Remove(menuRemovido);
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
            return _context.Menus.Any(m => m.Nombre.Trim().ToLower() == nombreBuscado);
        }
    }
}