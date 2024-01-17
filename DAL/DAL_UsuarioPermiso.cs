using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DAL_UsuarioPermiso
    {
        public static bool Insert(short ID_Usuario)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                var arrayPermisos = bd.Permisos.Where(a => a.Activo == true).ToArray();
                foreach (var permiso in arrayPermisos)
                {
                    var nuevoUsuarioPermiso = new UsuarioPermiso
                    {
                        UsuarioID = ID_Usuario,
                        PermisoID = permiso.ID,
                        Activo = permiso.ID == 1,
                        fechaRegistro = DateTime.Now
                    };
                    
                    bd.UsuarioPermsisos.Add(nuevoUsuarioPermiso);
                }
                return bd.SaveChanges()>0;
            }
        }

        public static short getPermisoID(short Id_Usuario)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                var userMatch = bd.UsuarioPermsisos.Where(a => a.UsuarioID == Id_Usuario).FirstOrDefault();

                if (userMatch != null)
                {
                    return userMatch.PermisoID;
                }
                else
                {
                    return -1;
                }
            }
        }
    }
}
