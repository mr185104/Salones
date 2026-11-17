using Microsoft.EntityFrameworkCore;
using Proyecto_Salon_de_Eventos.Model;

namespace Proyecto_Salon_de_Eventos.Data
{
    public class SalonDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Salon> Salones { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<AptoMenu> AptosMenu { get; set; }
        public DbSet<ItemMenu> ItemMenus { get; set; }
        public DbSet<ServicioAdicional> ServiciosAdicionales { get; set; }
        public DbSet<Presupuesto> Presupuestos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=salon_eventos.db");
        }
    }
}