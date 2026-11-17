namespace Proyecto_Salon_de_Eventos.Dto
{
    public class AptoMenuDto
    {
        public int Id { get; set; }
        public string Detalle { get; set; }

        public AptoMenuDto()
        {
            Id = 0;
            Detalle = string.Empty;
        }

        public AptoMenuDto(int id, string detalle)
        {
            Id = id;
            Detalle = detalle;
        }

        public override string ToString()
        {
            return Id + " - " + Detalle;
        }
    }
}
