using DAL;
using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public static class BL_Marca
    {
        public static Marca Insert(Marca Entidad)
        {
            return DAL_Marca.Insert(Entidad);
        }
        public static List<Marca> Lista(bool Activo = true)
        {
            return DAL_Marca.Lista(Activo);
        }

        public static string getMarca(short MarcaID)
        {
            return DAL_Marca.getMarca(MarcaID);
        }
    }
}
