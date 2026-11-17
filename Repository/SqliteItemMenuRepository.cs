using Microsoft.EntityFrameworkCore;
using Proyecto_Salon_de_Eventos.Data;
using Proyecto_Salon_de_Eventos.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Proyecto_Salon_de_Eventos.Repository.Sqlite
{
    public class SqliteItemMenuRepository : IRepository<ItemMenu>
    {
        private readonly SalonDbContext _context;

        public SqliteItemMenuRepository()
        {
            _context = new SalonDbContext();
            _context.Database.EnsureCreated();
        }

        public void Add(ItemMenu itemMenu)
        {
            if (itemMenu == null)
            {
                throw new ArgumentNullException(nameof(itemMenu));
            }

            _context.ItemMenus.Add(itemMenu);
            _context.SaveChanges();
        }

        public IEnumerable<ItemMenu> GetAll()
        {
            List<ItemMenu> listaItems = new List<ItemMenu>(_context.ItemMenus.ToList());
            return listaItems;
        }

        public ItemMenu? GetById(int id)
        {
            ItemMenu? itemEncontrado = _context.ItemMenus.Find(id);
            return itemEncontrado;
        }

        public bool Update(ItemMenu itemActualizado)
        {
            if (itemActualizado == null)
            {
                return false;
            }

            ItemMenu? itemExistente = GetById(itemActualizado.Id);
            if (itemExistente == null)
            {
                return false;
            }

            itemExistente.Cantidad = itemActualizado.Cantidad;
            itemExistente.Item = itemActualizado.Item;

            int filasAfectadas = _context.SaveChanges();
            return filasAfectadas > 0;
        }

        public bool Remove(int id)
        {
            ItemMenu? itemRemovido = GetById(id);
            if (itemRemovido == null)
            {
                return false;
            }

            _context.ItemMenus.Remove(itemRemovido);
            int filasAfectadas = _context.SaveChanges();
            return filasAfectadas > 0;
        }
    }
}