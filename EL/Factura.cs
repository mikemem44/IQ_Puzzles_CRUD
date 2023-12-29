using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Factura
    {
        public short ID { get; set; }
        public short ClienteID { get; set; }
        public short UsuarioID { get; set; }
        public DateTime fechaCompra { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public float totalCompra { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public float montoPagado { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public float Cambio { get; set; }
        public bool Activo { get; set; }
        public short? usuarioRegistro { get; set; }
        public DateTime? fechaRegistro { get; set; }
        public short? usuarioActualiza { get; set; }
        public DateTime? fechaActualizacion { get; set; }

        public ICollection<Detalle> Detalles { get; } = new List<Detalle>();
        public Cliente Cliente { get; set; } = null!;
        public Usuario Usuario { get; set; } = null!;
    }

    public class FacturaView
    {
        public short DetalleID { get; set; }
        public short ProductoID { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public string NombreProducto { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public float PrecioVenta { get; set; }
        public short Cantidad { get; set; }
        public float Descuento { get; set; }
        public float totalDetalle { get; set; }
    }
}
