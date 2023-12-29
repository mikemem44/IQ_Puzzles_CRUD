using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DAL_Producto
    {
        public static Producto Insert(Producto Entidad)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                Entidad.Activo = true;
                Entidad.fechaRegistro = DateTime.Now;
                bd.Productos.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
        }

        public static bool Update(Producto Entidad)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                var Registro = bd.Productos.Find(Entidad.ID);
                if (Registro != null)
                {
                    Registro.ModeloID = Entidad.ModeloID;
                    Registro.MarcaID = Entidad.MarcaID;
                    Registro.nombreProducto = Entidad.nombreProducto;
                    Registro.precioUnitario = Entidad.precioUnitario;
                    Registro.Stock = Entidad.Stock;
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

        public static bool Archivar(Producto Entidad)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                var Registro = bd.Productos.Find(Entidad.ID);
                if (Registro != null)
                {
                    Registro.Activo = false;
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

        public static List<Producto> Lista(bool Activo = true)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                return bd.Productos.Where(a => a.Activo == Activo).ToList();
            }
        }

        public static List<ProductoView> listProductoDetalle()
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                var query = from p in bd.Productos
                            join mo in bd.Modelos on p.ModeloID equals mo.ID
                            join ma in bd.Marcas on p.MarcaID equals ma.ID
                            where p.Activo == true
                            select new ProductoView
                            {
                                ProductoID = p.ID,
                                Nombre = p.nombreProducto,
                                Modelo = mo.nombreModelo,
                                Marca = ma.nombreMarca,
                                PrecioUnitario = p.precioUnitario,
                                Stock = p.Stock
                            };

                return query.ToList();
            }
        }

        public static bool actualizarStock(Producto Entidad)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                var Registro = bd.Productos.Find(Entidad.ID);
                if (Registro != null)
                {
                    Registro.Stock -= Entidad.Stock;
                    if (Registro.Stock <= 0)
                    {
                        Registro.Activo = false;
                    }
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

    }
}
