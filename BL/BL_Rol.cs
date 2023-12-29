using EL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BL_Rol
    {
        public static List<Rol> Lista(bool Activo = true)
        {
            return DAL_Rol.Lista(Activo);
        }

        public static string getRol(short RolID)
        {
            return DAL_Rol.getRol(RolID);
        }

        public static List<string> listaRolesCmbBox()
        {
            return DAL_Rol.listaRolesCmbBox();
        }
    }
}
