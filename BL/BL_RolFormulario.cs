using DAL;
using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public static class BL_RolFormulario
    {
        public static bool Update(RolFormulario Entidad)
        {
            return DAL_RolFormulario.Update(Entidad);
        }
        public static List<RolFormulario> Lista(bool Activo = true)
        {
            return DAL_RolFormulario.Lista(Activo);
        }

        public static List<RolFormularioView> listaRolFormulario(short ID_Rol)
        {
            return DAL_RolFormulario.listaRolFormulario(ID_Rol);
        }

        public static bool verificarAccesoFormulario(short ID_Rol, short ID_Formulario)
        {
            return DAL_RolFormulario.verificarAccesoFormulario(ID_Rol, ID_Formulario);
        }
    }
}
