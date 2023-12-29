using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DAL_Factura
    {
        public static Factura Insert(Factura Entidad)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                Entidad.Activo = true;
                Entidad.fechaCompra = DateTime.Now;
                Entidad.fechaRegistro = DateTime.Now;
                bd.Facturas.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
        }

        public static bool Update(Factura Entidad)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                var Registro = bd.Facturas.Find(Entidad.ID);
                if (Registro != null)
                {
                    Registro.fechaCompra = DateTime.Now;
                    Registro.totalCompra = Entidad.totalCompra;
                    Registro.montoPagado = Entidad.montoPagado;
                    Registro.Cambio = Entidad.Cambio;
                    Registro.usuarioActualiza = Entidad.usuarioActualiza;
                    Registro.fechaActualizacion = DateTime.Now;
                    return bd.SaveChanges() > 0;
                }
                else
                {
                    return false;
                }

            }
        }

        public static List<Factura> Lista(bool Activo = true)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                return bd.Facturas.Where(a => a.Activo == Activo).ToList();
            }
        }

        public static List<FacturaView> listDetalleCompraFactura(short ID_Factura)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                var query = from d in bd.Detalles
                            join f in bd.Facturas on d.FacturaID equals f.ID
                            join c in bd.Clientes on f.ClienteID equals c.ID
                            join p in bd.Productos on d.ProductoID equals p.ID
                            join mo in bd.Modelos on p.ModeloID equals mo.ID
                            join ma in bd.Marcas on p.MarcaID equals ma.ID
                            where d.Activo == true && d.FacturaID == ID_Factura
                            select new FacturaView
                            {
                                DetalleID = d.ID,
                                ProductoID = d.ProductoID,
                                NombreCliente = c.Nombre,
                                ApellidoCliente = c.Apellido,
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
