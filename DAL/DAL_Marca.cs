using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DAL_Marca
    {
        public static Marca Insert(Marca Entidad)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                Entidad.Activo = true;
                Entidad.fechaRegistro = DateTime.Now;
                bd.Marcas.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
        }
        public static List<Marca> Lista(bool Activo = true)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                return bd.Marcas.Where(a => a.Activo == Activo).ToList();
            }
        }

        public static string getMarca(short MarcaID)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                var marcaFound = bd.Marcas.FirstOrDefault(a => a.ID == MarcaID);

                if (marcaFound != null)
                {
                    return marcaFound.nombreMarca;
                }
                else
                {
                    return " ";
                }
            }
        }
    }
}
