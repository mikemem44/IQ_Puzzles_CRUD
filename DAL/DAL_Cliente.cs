using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DAL_Cliente
    {
        public static Cliente Insert(Cliente Entidad)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                Entidad.Activo = true;
                Entidad.fechaRegistro = DateTime.Now;
                bd.Clientes.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
                //edit this line
            }
        }

        public static bool Update(Cliente Entidad)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                var Registro = bd.Clientes.Find(Entidad.ID);
                if (Registro != null)
                {
                    Registro.Nombre = Entidad.Nombre;
                    Registro.Apellido = Entidad.Apellido;
                    Registro.Correo = Entidad.Correo;
                    Registro.Telefono = Entidad.Telefono;
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

        public static bool Archivar(Cliente Entidad)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                var Registro = bd.Clientes.Find(Entidad.ID);
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

        public static List<Cliente> Lista(bool Activo = true)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                return bd.Clientes.Where(a => a.Activo == Activo).ToList();
            }
        }

    }
}
