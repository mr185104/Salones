using Microsoft.EntityFrameworkCore;
using Proyecto_Salon_de_Eventos.Data;
using Proyecto_Salon_de_Eventos.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Proyecto_Salon_de_Eventos.Repository.Sqlite
{
    public class SqliteAptoMenuRepository : IRepository<AptoMenu>
    {
        private readonly SalonDbContext _context;

        public SqliteAptoMenuRepository()
        {
            _context = new SalonDbContext();
            _context.Database.EnsureCreated();
        }

        public void Add(AptoMenu aptoMenu)
        {
            if (aptoMenu == null)
            {
                throw new ArgumentNullException(nameof(aptoMenu));
            }

            _context.AptosMenu.Add(aptoMenu);
            _context.SaveChanges();
        }

        public IEnumerable<AptoMenu> GetAll()
        {
            List<AptoMenu> listaAptos = new List<AptoMenu>(_context.AptosMenu.ToList());
            return listaAptos;
        }

        public AptoMenu? GetById(int id)
        {
            AptoMenu? aptoEncontrado = _context.AptosMenu.Find(id);
            return aptoEncontrado;
        }

        public bool Update(AptoMenu aptoMenuActualizado)
        {
            if (aptoMenuActualizado == null)
            {
                return false;
            }

            AptoMenu? aptoExistente = GetById(aptoMenuActualizado.Id);
            if (aptoExistente == null)
            {
                return false;
            }

            aptoExistente.Detalle = aptoMenuActualizado.Detalle;

            int filasAfectadas = _context.SaveChanges();
            return filasAfectadas > 0;
        }

        public bool Remove(int id)
        {
            AptoMenu? aptoRemovido = GetById(id);
            if (aptoRemovido == null)
            {
                return false;
            }

            _context.AptosMenu.Remove(aptoRemovido);
            int filasAfectadas = _context.SaveChanges();
            return filasAfectadas > 0;
        }

        public bool ExistsByDetalle(string detalle)
        {
            if (string.IsNullOrEmpty(detalle))
            {
                return false;
            }

            List<AptoMenu> todosLosAptos = new List<AptoMenu>(_context.AptosMenu.ToList());
            foreach (AptoMenu apto in todosLosAptos)
            {
                if (apto.Detalle.Trim().ToLower() == detalle.Trim().ToLower())
                {
                    return true;
                }
            }

            return false;
        }
    }
}