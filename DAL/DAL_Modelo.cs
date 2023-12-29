using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DAL_Modelo
    {
        public static Modelo Insert(Modelo Entidad)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                Entidad.Activo = true;
                Entidad.fechaRegistro = DateTime.Now;
                bd.Modelos.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
        }
        public static List<Modelo> Lista(bool Activo = true)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                return bd.Modelos.Where(a => a.Activo == Activo).ToList();
            }
        }

        public static string getModelo(short ModeloID)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                var modeloFound = bd.Modelos.FirstOrDefault(a => a.ID == ModeloID);

                if (modeloFound != null)
                {
                    return modeloFound.nombreModelo;
                }
                else
                {
                    return " ";
                }
            }
        }
    }
}
