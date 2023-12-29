using DAL;
using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public static class BL_Detalle
    {
        public static Detalle Insert(Detalle Entidad)
        {
            return DAL_Detalle.Insert(Entidad);
        }
        public static List<DetalleView> listDetalleFactura(short ID_Factura)
        {
            return DAL_Detalle.listDetalleFactura(ID_Factura);
        }

    }
}
