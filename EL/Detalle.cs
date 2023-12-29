using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Detalle
    {
        public short ID { get; set; }
        public short ProductoID { get; set; }
        public short FacturaID { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public float precioVenta { get; set; }
        public short Cantidad { get; set; }
        public float Descuento { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public float totalDetalle { get; set; }

        public bool Activo { get; set; }
        public short? usuarioRegistro { get; set; }
        public DateTime? fechaRegistro { get; set; }
        public short? usuarioActualiza { get; set; }
        public DateTime? fechaActualizacion { get; set; }

        public Producto Producto { get; set; } = null!;
        public Factura Factura { get; set; } = null!;
    }

    public class DetalleView
    {
        public short DetalleID { get; set; }
        public short ProductoID { get; set; }
        public string NombreProducto { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public float PrecioVenta { get; set; }
        public short Cantidad { get; set; }
        public float Descuento { get; set; }
        public float totalDetalle { get; set; }

    }
}
