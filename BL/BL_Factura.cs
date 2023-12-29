using DAL;
using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public static class BL_Factura
    {
        public static Factura Insert(Factura Entidad)
        {
            return DAL_Factura.Insert(Entidad);
        }

        public static bool Update(Factura Entidad)
        {
            return DAL_Factura.Update(Entidad);
        }

        public static List<Factura> Lista(bool Activo = true)
        {
            return DAL_Factura.Lista(Activo);
        }

        public static List<FacturaView> listDetalleCompraFactura(short ID_Factura)
        {
            return DAL_Factura.listDetalleCompraFactura(ID_Factura);
        }
    }
}
