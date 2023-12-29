using DAL;
using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public static class BL_RolUsuario
    {
        public static RolUsuario Insert(RolUsuario Entidad)
        {
            return DAL_RolUsuario.Insert(Entidad);
        }

        public static bool Update(RolUsuario Entidad)
        {
            return DAL_RolUsuario.Update(Entidad);
        }
        public static bool Archivar(RolUsuario Entidad)
        {
            return DAL_RolUsuario.Archivar(Entidad);
        }
        public static short getRolID(short Id_Usuario)
        {
            return DAL_RolUsuario.getRolID(Id_Usuario);
        }

        public static List<RolUsuarioView> listRolUsuario()
        {
            return DAL_RolUsuario.listRolUsuario();
        }
    }
}
