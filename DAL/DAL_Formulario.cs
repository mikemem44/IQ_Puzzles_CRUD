using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DAL_Formulario
    {
        public static List<Formulario> Lista(bool Activo = true)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                return bd.Formularios.Where(a => a.Activo == Activo).ToList();
            }
        }
    }
}
