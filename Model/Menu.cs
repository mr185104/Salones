using System;
using System.Collections.Generic;

namespace Proyecto_Salon_de_Eventos.Model
{
    public class Menu
    {
        private string _nombre = string.Empty;
        private string _detalle = string.Empty;
        private decimal _precio;

        public int Id { get; set; }

        public string Nombre
        {
            get => _nombre;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre del menú no puede estar vacío.");
                _nombre = value.Trim();
            }
        }

        public string Detalle
        {
            get => _detalle;
            set => _detalle = value?.Trim() ?? string.Empty;
        }

        public decimal Precio
        {
            get => _precio;
            set
            {
                if (value < 0)
                    throw new ArgumentException("El precio del menú no puede ser negativo.");
                _precio = value;
            }
        }

        public bool EsAdulto { get; set; }

        public List<AptoMenu> AptosMenu { get; set; } = new List<AptoMenu>();

        public Menu() { }

        public Menu(string nombre, string detalle, decimal precio, bool esAdulto, List<AptoMenu>? aptosMenu = null)
        {
            Nombre = nombre;
            Detalle = detalle;
            Precio = precio;
            EsAdulto = esAdulto;
            AptosMenu = aptosMenu ?? new List<AptoMenu>();
        }

        public override string ToString()
        {
            string aptos = AptosMenu.Count > 0 ? string.Join(", ", AptosMenu) : "Ninguno";
            return $"{Id} - {Nombre} | Detalle: {Detalle} | Precio: ${Precio} | Tipo: {(EsAdulto ? "Adulto" : "Infantil")} | Aptos: [{aptos}]";
        }
    }
}