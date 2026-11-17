using System;
using Proyecto_Salon_de_Eventos.Model;

namespace Proyecto_Salon_de_Eventos.Dto
{
    public class ItemMenuDto
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public int MenuId { get; set; }
        public string DetalleMenu { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }

        public ItemMenuDto()
        {
            Id = 0;
            Cantidad = 1;
            MenuId = 0;
            DetalleMenu = string.Empty;
            PrecioUnitario = 0m;
            Subtotal = 0m;
        }

        public ItemMenuDto(int id, int cantidad, int menuId, string detalleMenu, decimal precioUnitario, decimal subtotal)
        {
            Id = id;
            Cantidad = cantidad;
            MenuId = menuId;
            DetalleMenu = detalleMenu;
            PrecioUnitario = precioUnitario;
            Subtotal = subtotal;
        }

        public override string ToString()
        {
            return Cantidad + " x " + DetalleMenu + " | Precio Unitario: $" + PrecioUnitario + " | Subtotal: $" + Subtotal;
        }
    }
}