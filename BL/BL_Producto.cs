using DAL;
using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public static class BL_Producto
    {
        public static Producto Insert(Producto Entidad)
        {
            return DAL_Producto.Insert(Entidad);
        }

        public static bool Update(Producto Entidad)
        {
            return DAL_Producto.Update(Entidad);
        }

        public static bool Archivar(Producto Entidad)
        {
            return DAL_Producto.Archivar(Entidad);
        }

        public static List<Producto> Lista(bool Activo = true)
        {
            return DAL_Producto.Lista(Activo);
        }

        public static List<ProductoView> listProductoDetalle()
        {
            return DAL_Producto.listProductoDetalle();
        }

        public static bool actualizarStock(Producto Entidad)
        {
            return DAL_Producto.actualizarStock(Entidad);
        }
    }
}
