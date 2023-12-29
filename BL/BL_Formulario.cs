using DAL;
using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public static class BL_Formulario
    {
        public static List<Formulario> Lista(bool Activo = true)
        {
            return DAL_Formulario.Lista(Activo);
        }
    }
}
