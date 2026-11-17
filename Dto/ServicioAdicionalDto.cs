namespace Proyecto_Salon_de_Eventos.Dto
{
    public class ServicioAdicionalDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public ServicioAdicionalDto()
        {
            Id = 0;
            Nombre = string.Empty;
            Precio = 0m;
        }

        public ServicioAdicionalDto(int id, string nombre, decimal precio)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
        }

        public override string ToString()
        {
            return Id + " - " + Nombre + " | Precio: $" + Precio;
        }
    }
}