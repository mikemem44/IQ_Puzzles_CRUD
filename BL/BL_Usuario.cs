using DAL;
using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public static class BL_Usuario
    {
        public static Usuario Insert(Usuario Entidad)
        {
            return DAL_Usuario.Insert(Entidad);
        }

        public static bool Update(Usuario Entidad)
        {
            return DAL_Usuario.Update(Entidad);
        }

        public static bool agregarContadorBloqueo(Usuario Entidad)
        {
            return DAL_Usuario.agregarContadorBloqueo(Entidad);
        }

        public static bool Archivar(Usuario Entidad)
        {
            return DAL_Usuario.Archivar(Entidad);
        }

        public static List<Usuario> Lista(bool Activo = true)
        {
            return DAL_Usuario.Lista(Activo);
        }

        public static byte[] Sha256(string input)
        {
            return DAL_Usuario.Sha256(input);
        }

        public static bool verificarLogin(string username, byte[] contrasena)
        {
            return DAL_Usuario.verificarLogin(username, contrasena);
        }

        public static short getUserIDSiLoginValido(string username)
        {
            return DAL_Usuario.getUserIDSiLoginValido(username);
        }

        /*public static short getPermisoID(short Id_Usuario)
        {
            return DAL_Usuario.getPermisoID(Id_Usuario);
        }*/

        public static bool verificarUsuarioBloqueado(Usuario Entidad)
        {
            return DAL_Usuario.verificarUsuarioBloqueado(Entidad);
        }

        public static bool bloquearUsuarioMenu(Usuario Entidad)
        {
            return DAL_Usuario.bloquearUsuarioMenu(Entidad);
        }

        public static bool desbloquearUsuario(Usuario Entidad)
        {
            return DAL_Usuario.desbloquearUsuario(Entidad);
        }

        public static bool verificarUsuarioExiste(string UserName)
        {
            return DAL_Usuario.verificarUsuarioExiste(UserName);
        }
    }
}
