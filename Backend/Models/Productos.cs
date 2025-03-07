using Microsoft.EntityFrameworkCore;

namespace PruebaTecnica.Models
{
    public class Producto
    {
        public int ID { get; set; }
        public String? Nombre { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int CategoriaId { get; set; }
        public String? Imagen { get; set; }
    }
}
