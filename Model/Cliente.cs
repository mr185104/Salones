using System;

using System;

namespace Proyecto_Salon_de_Eventos.Model
{
    public class Cliente
    {
        // Atributos privados
        private string _nombre = string.Empty;
        private string _apellido = string.Empty;
        private string _telefono = string.Empty;
        private string _dni = string.Empty;
        private string _email = string.Empty;
        private string _notas = string.Empty;

        //  Id lo asignaria la base de datos(idea}
        public int Id { get; set; }

       
        public string Nombre
        {
            get => _nombre;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El Nombre no puede estar vacío.");
                _nombre = value.Trim();
            }
        }

        public string Apellido
        {
            get => _apellido;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El Apellido no puede estar vacío.");
                _apellido = value.Trim();
            }
        }

        public string Telefono
        {
            get => _telefono;
            set => _telefono = value?.Trim() ?? string.Empty;
        }

        public string Dni
        {
            get => _dni;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El DNI no puede estar vacío.");
                _dni = value.Trim();
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || !value.Contains("@"))
                    throw new ArgumentException("El email no es válido.");
                _email = value.Trim();
            }
        }

        public string Notas
        {
            get => _notas;
            set => _notas = value?.Trim() ?? string.Empty;
        }


        public Cliente() { }

        public Cliente(string nombre, string apellido, string telefono, string dni, string email, string notas = "")
        {
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Dni = dni;
            Email = email;
            Notas = notas;
        }

        public override string ToString()
        {
            return $"{Id} - {Nombre} {Apellido} | DNI: {Dni} | Tel: {Telefono} | Email: {Email} | Notas: {Notas}";
        }
    }
}
