using System;

namespace Proyecto_Salon_de_Eventos.Model
{
    public class ItemMenu
    {
        // Campos privados
        private int _id;
        private int _cantidad;
        private Menu _item;

        // Propiedades con validaciones básicas
        public int Id
        {
            get { return _id; }
            set { _id = value >= 0 ? value : 0; } // CORREGIDO: Permite 0 para autoincremento de EF/SQLite
        }

        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value > 0 ? value : 1; }
        }

        public Menu Item
        {
            get { return _item; }
            set
            {
                ArgumentNullException.ThrowIfNull(value);
                _item = value;
            }
        }

        // Constructor por defecto
        public ItemMenu()
        {
            Id = 0; // CORREGIDO: Inicia en 0 para entidades nuevas
            Cantidad = 1;
            Item = new Menu(); // valor por defecto
        }

        // Constructor parametrizado
        public ItemMenu(int id, int cantidad, Menu item)
        {
            Id = id;
            Cantidad = cantidad;
            Item = item;
        }

        // Método para calcular subtotal
        public decimal CalcularSubtotal()
        {
            return Item.Precio * Cantidad;
        }

        // Método de utilidad
        public override string ToString()
        {
            return Cantidad + " x " + Item.Detalle + " | Precio Unitario: $" + Item.Precio + " | Subtotal: $" + CalcularSubtotal();
        }
    }
}