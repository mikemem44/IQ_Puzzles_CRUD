using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Producto
    {
        public short ID { get; set; }
        public short ModeloID { get; set; }
        public short MarcaID { get; set; }
        public string nombreProducto { get; set; } = null!;

        [Column(TypeName = "decimal(6,2)")]
        public float precioUnitario { get; set; }
        public bool Activo { get; set; }
        public short Stock { get; set; }
        public short? usuarioRegistro { get; set; }
        public DateTime? fechaRegistro { get; set; }
        public short? usuarioActualiza { get; set; }
        public DateTime? fechaActualizacion { get; set; }
        public Modelo Modelo { get; set; } = null!;
        public Marca Marca { get; set; } = null!;
        //public Detalle? Detalle { get; set; }
        public ICollection<Detalle> Detalles { get; } = new List<Detalle>();
    }

    public class ProductoView
    {
        public short ProductoID { get; set; }
        public string Nombre { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public float PrecioUnitario { get; set; }
        public short Stock { get; set; }
    }
}
