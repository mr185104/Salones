using System;

namespace Proyecto_Salon_de_Eventos.Model
{
    public class AptoMenu
    {
        private string _detalle = string.Empty;

        public int Id { get; set; }

        public string Detalle
        {
            get => _detalle;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El detalle del AptoMenu no puede estar vacío.");
                _detalle = value.Trim();
            }
        }

        public AptoMenu() { }

        public AptoMenu(string detalle)
        {
            Detalle = detalle;
        }

        public override string ToString()
        {
            return $"{Id} - {Detalle}";
        }
    }
}