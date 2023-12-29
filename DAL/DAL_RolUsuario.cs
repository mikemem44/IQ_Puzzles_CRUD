using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DAL_RolUsuario
    {
        public static RolUsuario Insert(RolUsuario Entidad)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                Entidad.Activo = true;
                Entidad.fechaRegistro = DateTime.Now;
                bd.RolUsuarios.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
        }

        public static bool Update(RolUsuario Entidad)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                var Registro = bd.RolUsuarios.Find(Entidad.ID);
                if (Registro != null)
                {
                    Registro.UsuarioID = Entidad.UsuarioID;
                    Registro.RolID = Entidad.RolID;
                    Registro.usuarioActualiza = Entidad.usuarioActualiza;
                    Registro.fechaActualizacion = DateTime.Now;
                    return bd.SaveChanges() > 0;
                }
                else
                {
                    return false;
                }

            }
        }

        public static bool Archivar(RolUsuario Entidad)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                var Registro = bd.RolUsuarios.Find(Entidad.ID);
                if (Registro != null)
                {
                    Registro.Activo = false;
                    Registro.usuarioActualiza = Entidad.usuarioActualiza;
                    Registro.fechaActualizacion = DateTime.Now;
                    return bd.SaveChanges() > 0;
                }
                else
                {
                    return false;
                }
                
            }
        }
        public static short getRolID(short Id_Usuario)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                var userMatch = bd.RolUsuarios.Where(a => a.UsuarioID == Id_Usuario).FirstOrDefault();

                if (userMatch != null)
                {
                    return userMatch.RolID;
                }
                else
                {
                    return -1;
                }
            }
        }

        public static List<RolUsuarioView> listRolUsuario()
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                var query = from ru in bd.RolUsuarios
                            join r in bd.Roles on ru.RolID equals r.ID
                            join u in bd.Usuarios on ru.UsuarioID equals u.ID
                            where ru.Activo == true && r.Activo == true && u.Activo == true
                            select new RolUsuarioView
                            {
                                RolUsuarioID = ru.ID,
                                RolID = ru.RolID,
                                nombreRol = r.nombreRol,
                                Username = u.Username,
                                UsuarioID = ru.UsuarioID,
                                UsuarioRegistro = ru.usuarioRegistro,
                                FechaRegistro = ru.fechaRegistro,
                                UsuarioActualiza = ru.usuarioActualiza,
                                FechaActualizacion = ru.fechaActualizacion
                            };

                return query.ToList();
            }
        }
    }
}
