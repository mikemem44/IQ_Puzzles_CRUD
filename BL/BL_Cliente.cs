using DAL;
using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public static class BL_Cliente
    {
        public static Cliente Insert(Cliente Entidad)
        {
            return DAL_Cliente.Insert(Entidad);
        }
        public static bool Update(Cliente Entidad)
        {
            return DAL_Cliente.Update(Entidad);
        }
        public static bool Archivar(Cliente Entidad)
        {
            return DAL_Cliente.Archivar(Entidad);
        }
        public static List<Cliente> Lista(bool Activo = true)
        {
            return DAL_Cliente.Lista(Activo);
        }
    }
}
