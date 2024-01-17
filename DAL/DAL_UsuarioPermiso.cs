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
        public static UsuarioPermiso Insert(UsuarioPermiso Entidad)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                var arrayPermisos = bd.Permisos.Where(a => a.Activo == true).ToArray();
                foreach (var permiso in arrayPermisos)
                {
                    Entidad.PermisoID = permiso.ID;
                    if (permiso.ID != 1)
                    {
                        Entidad.Activo = false;
                    }
                    else
                    {
                        Entidad.Activo = true;
                    }
                    Entidad.fechaRegistro = DateTime.Now;
                    bd.UsuarioPermsisos.Add(Entidad);
                    bd.SaveChanges();
                }
                return Entidad;
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
