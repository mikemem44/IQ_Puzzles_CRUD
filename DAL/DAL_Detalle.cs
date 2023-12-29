using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DAL_Detalle
    {
        public static Detalle Insert(Detalle Entidad)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                Entidad.Activo = true;
                Entidad.fechaRegistro = DateTime.Now;
                bd.Detalles.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
        }
        public static List<DetalleView> listDetalleFactura(short ID_Factura)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                var query = from d in bd.Detalles
                            join p in bd.Productos on d.ProductoID equals p.ID
                            join mo in bd.Modelos on p.ModeloID equals mo.ID
                            join ma in bd.Marcas on p.MarcaID equals ma.ID
                            where d.Activo == true && p.Activo == true && d.FacturaID == ID_Factura
                            select new DetalleView
                            {
                                DetalleID = d.ID,
                                ProductoID = d.ProductoID,
                                NombreProducto = p.nombreProducto,
                                Modelo = mo.nombreModelo,
                                Marca = ma.nombreMarca,
                                PrecioVenta = d.precioVenta,
                                Cantidad = d.Cantidad,
                                Descuento = d.Descuento,
                                totalDetalle = d.totalDetalle
                            };

                return query.ToList();
            }
        }

    
    }
}
