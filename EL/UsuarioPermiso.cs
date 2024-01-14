using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class UsuarioPermiso
    {
        public short ID { get; set; }
        public short UsuarioID { get; set; }
        public short PermisoID { get; set; }
        public bool Activo { get; set; }
        public short? usuarioRegistro { get; set; }
        public DateTime? fechaRegistro { get; set; }
        public short? usuarioActualiza { get; set; }
        public DateTime? fechaActualizacion { get; set; }

    }
}
