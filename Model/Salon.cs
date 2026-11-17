using System;

namespace Proyecto_Salon_de_Eventos.Model
{
    public class Salon
    {
        // Atributos privados
        private string _nombre = string.Empty;
        private string _direccion = string.Empty;
        private string _localidad = string.Empty;
        private int _capacidad;
        private decimal _precio;

        // El Id es autoincremental y lo asignará el repositorio
        public int Id { get; set; }

        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El nombre del salón no puede estar vacío.");
                }
                _nombre = value.Trim();
            }
        }

        public string Direccion
        {
            get
            {
                return _direccion;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("La dirección del salón no puede estar vacía.");
                }
                _direccion = value.Trim();
            }
        }

        public string Localidad
        {
            get
            {
                return _localidad;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("La localidad del salón no puede estar vacía.");
                }
                _localidad = value.Trim();
            }
        }

        public int Capacidad
        {
            get
            {
                return _capacidad;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("La capacidad del salón debe ser un número entero mayor a cero.");
                }
                _capacidad = value;
            }
        }

        public decimal Precio
        {
            get
            {
                return _precio;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("El precio del salón no puede ser un valor negativo.");
                }
                _precio = value;
            }
        }

        // Constructor vacío (requerido para instanciaciones por defecto)
        public Salon() { }

        // Constructor completo con parámetros
        public Salon(string nombre, string direccion, string localidad, int capacidad, decimal precio)
        {
            Nombre = nombre;
            Direccion = direccion;
            Localidad = localidad;
            Capacidad = capacidad;
            Precio = precio;
        }

        // Método para representación en texto (útil para ListBoxes o ComboBoxes)
        public override string ToString()
        {
            return Id + " - " + Nombre + " (" + Localidad + ") | Capacidad: " + Capacidad + " personas | Precio: $" + Precio + " | Dir: " + Direccion;
        }
    }
}