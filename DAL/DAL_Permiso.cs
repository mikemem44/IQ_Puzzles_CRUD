using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DAL_Permiso
    {
        public static List<Permiso> Lista (bool Activo = true)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext ())
            {
                return bd.Permisos.Where(a=> a.Activo == Activo).ToList();
            }
        }

        public static string getPermiso(short PermisoID)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                var permisoFound = bd.Permisos.FirstOrDefault(a => a.ID == PermisoID);

                if (permisoFound != null)
                {
                    return permisoFound.nombrePermiso;
                }
                else
                {
                    return "Lectura";
                }
            }
        }
    }
}
