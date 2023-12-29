using DAL;
using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public static class BL_Modelo
    {
        public static Modelo Insert(Modelo Entidad)
        {
            return DAL_Modelo.Insert(Entidad);
        }
        public static List<Modelo> Lista(bool Activo = true)
        {
            return DAL_Modelo.Lista(Activo);
        }

        public static string getModelo(short ModeloID)
        {
            return DAL_Modelo.getModelo(ModeloID);
        }
    }
}
