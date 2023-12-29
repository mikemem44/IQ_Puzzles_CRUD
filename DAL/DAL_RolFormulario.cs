using DAL.Migrations;
using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DAL_RolFormulario
    {
        public static bool Update(RolFormulario Entidad)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                var Registro = bd.RolFormularios.Find(Entidad.ID);
                if (Registro != null)
                {
                    Registro.Activo = Entidad.Activo;
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
        public static List<RolFormulario> Lista(bool Activo = true)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                return bd.RolFormularios.Where(a => a.Activo == Activo).ToList();
            }
        }

        public static List<RolFormularioView> listaRolFormulario(short ID_Rol)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                var query = from rf in bd.RolFormularios
                            join r in bd.Roles on rf.RolID equals r.ID
                            join f in bd.Formularios on rf.FormularioID equals f.ID
                            where rf.RolID == ID_Rol && (f.Activo == true || rf.Activo == true)
                            select new RolFormularioView
                            {
                                ID = rf.ID,
                                RolID = r.ID,
                                NombreRol = r.nombreRol,
                                FormularioID = f.ID,
                                NombreFormulario = f.nombreFormulario,
                                Habilitado = rf.Activo,
                                UsuarioActualiza = rf.usuarioActualiza,
                                FechaActualizacion = rf.fechaActualizacion
                            };

                return query.ToList();
            }
        }

        public static bool verificarAccesoFormulario (short ID_Rol, short ID_Formulario)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                var query = bd.RolFormularios
                    .Any(rf => rf.RolID == ID_Rol && rf.FormularioID == ID_Formulario && rf.Activo);

                return query;
            }
        }
    }
}
