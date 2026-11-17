using System;

namespace Proyecto_Salon_de_Eventos.Model
{
    public class ServicioAdicional
    {
        // Atributos privados
        private int _id = 0;
        private string _nombre = string.Empty;
        private decimal _precio = 0.0m;

        public int Id
        {
            get => _id;
            set => _id = value >= 0 ? value : 0; // Permitimos 0 para que SQLite se encargue del autoincrement
        }

        public string Nombre
        {
            get => _nombre;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El nombre del servicio no puede estar vacío.");
                }
                _nombre = value.Trim();
            }
        }

        public decimal Precio
        {
            get => _precio;
            set => _precio = value >= 0 ? value : 0m;
        }

        public ServicioAdicional() { }

        public ServicioAdicional(int id, string nombre, decimal precio)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
        }

        public decimal CalcularSubtotal(int unidades)
        {
            int unidadesValidas = unidades > 0 ? unidades : 1;
            return Precio * unidadesValidas;
        }

        public override string ToString()
        {
            return $"{Id} - {Nombre} | Precio: ${Precio}";
        }
    }
}