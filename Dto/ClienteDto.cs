namespace Proyecto_Salon_de_Eventos.Dto
{
    public class ClienteDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Dni { get; set; }
        public string Email { get; set; }
        public string Notas { get; set; }

        public ClienteDto()
        {
            Id = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;
            Telefono = string.Empty;
            Dni = string.Empty;
            Email = string.Empty;
            Notas = string.Empty;
        }

        public ClienteDto(int id, string nombre, string apellido, string telefono, string dni, string email, string notas)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Dni = dni;
            Email = email;
            Notas = notas;
        }

        public override string ToString()
        {
            return Id + " - " + Nombre + " " + Apellido + " | DNI: " + Dni + " | Tel: " + Telefono + " | Email: " + Email + " | Notas: " + Notas;
        }
    }
}
