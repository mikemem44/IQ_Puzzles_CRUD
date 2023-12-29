using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DAL_Rol
    {
        public static List<Rol> Lista (bool Activo = true)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext ())
            {
                return bd.Roles.Where(a => a.Activo == Activo).ToList();
            }
        }

        public static List<string> listaRolesCmbBox()
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext ())
            {
                var roles = bd.Roles
                    .Where(r => r.nombreRol != "Revision" && r.nombreRol != "Administrador")
                    .Select(r => r.nombreRol)
                    .ToList();

                return roles;
            }
        }

        public static string getRol(short RolID)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                var rolFound = bd.Roles.FirstOrDefault(a => a.ID == RolID);

                if (rolFound != null)
                {
                    return rolFound.nombreRol;
                }
                else
                {
                    return "Lectura";
                }
            }
        }
    }
}
