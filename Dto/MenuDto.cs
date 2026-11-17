using System.Collections.Generic;
using System.Linq; // Necesario para usar .Select() y .Join()
using Proyecto_Salon_de_Eventos.Model;

namespace Proyecto_Salon_de_Eventos.Dto
{
    public class MenuDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Detalle { get; set; }
        public decimal Precio { get; set; }
        public bool EsAdulto { get; set; }
        public List<AptoMenu> AptosMenu { get; set; }

        // --- PROPIEDAD NUEVA PARA MOSTRAR EN EL DATAGRIDVIEW ---
        public string AptosMenuTexto
        {
            get
            {
                if (AptosMenu == null || AptosMenu.Count == 0)
                    return "Ninguno";

                return string.Join(", ", AptosMenu.Select(a => a.Detalle));
            }
        }

        public MenuDto()
        {
            Id = 0;
            Nombre = string.Empty;
            Detalle = string.Empty;
            Precio = 0m;
            EsAdulto = true;
            AptosMenu = new List<AptoMenu>();
        }

        public MenuDto(int id, string nombre, string detalle, decimal precio, bool esAdulto, List<AptoMenu>? aptosMenu = null)
        {
            Id = id;
            Nombre = nombre;
            Detalle = detalle;
            Precio = precio;
            EsAdulto = esAdulto;
            AptosMenu = aptosMenu ?? new List<AptoMenu>();
        }

        public override string ToString()
        {
            string aptos = AptosMenu != null && AptosMenu.Count > 0 ? string.Join(", ", AptosMenu) : "Ninguno";
            return Id + " - " + Nombre + " | Detalle: " + Detalle + " | Precio: $" + Precio + " | Tipo: " + (EsAdulto ? "Adulto" : "Infantil") + " | Aptos: [" + aptos + "]";
        }
    }
}