using DAL;
using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BL_Permiso
    {
        public static List<Permiso> Lista(bool Activo = true)
        {
            return DAL_Permiso.Lista(Activo);
        }

        public static string getPermiso(short PermisoID)
        {
            return DAL_Permiso.getPermiso(PermisoID);
        }
    }
}
