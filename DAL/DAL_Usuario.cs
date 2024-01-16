using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using EL;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public static class DAL_Usuario
    {
        public static Usuario Insert(Usuario Entidad)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                Entidad.Activo = true;
                Entidad.fechaRegistro = DateTime.Now;
                bd.Usuarios.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }  
        }

        public static bool Update(Usuario Entidad)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                var Registro = bd.Usuarios.Find(Entidad.ID);
                if (Registro != null)
                {
                    Registro.Nombre = Entidad.Nombre;
                    Registro.Username = Entidad.Username;
                    Registro.Contrasena = Entidad.Contrasena;
                    Registro.Correo = Entidad.Correo;
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

        public static bool agregarContadorBloqueo(Usuario Entidad)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                var Registro = bd.Usuarios.Find(Entidad.ID);
                if (Registro != null)
                {
                    Registro.Contador += 1;
                    if (Registro.Contador >= 5)
                    {
                        Registro.Bloqueado = true;
                    }
                    return bd.SaveChanges() > 0;
                }
                else
                {
                    return false;
                }
                
            }
        }

        public static bool Archivar(Usuario Entidad)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                var Registro = bd.Usuarios.Find(Entidad.ID);
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

        public static List<Usuario> Lista (bool Activo = true)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                return bd.Usuarios.Where(a => a.Activo == Activo).ToList();
            }
        }

        public static byte[] Sha256(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(UTF8Encoding.UTF8.GetBytes(input));
            }
        }

        

        public static bool verificarLogin (string username, byte[] contrasena)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                return bd.Usuarios.Where(a => a.Username.ToLower() == username.ToLower() && a.Contrasena == contrasena).Count() > 0;
            }
        }

        public static short getUserIDSiLoginValido(string username)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                var userMatch = bd.Usuarios
                    .FirstOrDefault(a => a.Username.ToLower() == username.ToLower());

                if (userMatch != null)
                {
                    return userMatch.ID;
                }
                else
                {
                    return -1;
                }
            }
        }

        /*public static short getPermisoID(short Id_Usuario)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                var userMatch = bd.Usuarios.Where(a => a.ID == Id_Usuario).FirstOrDefault();

                if (userMatch != null)
                {
                    return userMatch.PermisoID;
                }
                else
                {
                    return -1;
                }
            }
        }*/

        public static bool verificarUsuarioBloqueado(Usuario Entidad)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                var Registro = bd.Usuarios.Find(Entidad.ID);
                if (Registro != null)
                {
                    if (Registro.Bloqueado == true)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

                return false;
            }
        }

        public static bool bloquearUsuarioMenu(Usuario Entidad)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                var Registro = bd.Usuarios.Find(Entidad.ID);
                if (Registro != null)
                {
                    Registro.Bloqueado = true;
                    Registro.Contador = 5;
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

        public static bool desbloquearUsuario(Usuario Entidad)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                var Registro = bd.Usuarios.Find(Entidad.ID);
                if (Registro != null)
                {
                    Registro.Bloqueado = false;
                    Registro.Contador = 0;
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

        public static bool verificarUsuarioExiste(string UserName)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                return bd.Usuarios.Where(a => a.Username.ToLower() == UserName.ToLower()).Count() > 0;
            }

        }

    }
}
