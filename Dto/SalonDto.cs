namespace Proyecto_Salon_de_Eventos.Dto
{
    public class SalonDto
    {
        // Propiedades simples para transporte de datos
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Localidad { get; set; } // ⬅️ Nueva propiedad agregada
        public int Capacidad { get; set; }
        public decimal Precio { get; set; }

        // Constructor vacío: Inicializa valores por defecto seguros
        public SalonDto()
        {
            Id = 0;
            Nombre = string.Empty;
            Direccion = string.Empty;
            Localidad = string.Empty; // ⬅️ Inicialización limpia
            Capacidad = 0;
            Precio = 0m; // Se usa 'm' para indicar un literal tipo decimal
        }

        // Constructor completo para instanciación rápida en el Controller o la Vista
        public SalonDto(int id, string nombre, string direccion, string localidad, int capacidad, decimal precio)
        {
            Id = id;
            Nombre = nombre;
            Direccion = direccion;
            Localidad = localidad;
            Capacidad = capacidad;
            Precio = precio;
        }

        // Método ToString para facilitar el formateo en controles visuales (ComboBox, ListBox, DataGridView)
        public override string ToString()
        {
            return Id + " - " + Nombre + " (" + Localidad + ") | Capacidad: " + Capacidad + " personas | Precio: $" + Precio + " | Dir: " + Direccion;
        }
    }
}