using DAL;
using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public static class BL_UsuarioPermiso
    {
        public static bool Insert(short ID_Usuario)
        {
            return DAL_UsuarioPermiso.Insert(ID_Usuario);
        }
        public static short getPermisoID(short Id_Usuario)
        {
            return DAL_UsuarioPermiso.getPermisoID(Id_Usuario);
        }
    }
}
