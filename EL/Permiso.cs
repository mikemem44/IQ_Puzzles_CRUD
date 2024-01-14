using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Permiso
    {
        public short ID { get; set; }
        public string nombrePermiso { get; set; } = null!;
        public bool Activo { get; set; }
        public short? usuarioRegistro { get; set; }
        public DateTime? fechaRegistro { get; set; }
        public short? usuarioActualiza { get; set; }
        public DateTime? fechaActualizacion { get; set; }

        public ICollection<Usuario> Usuarios { get; } = new List<Usuario>();
    }
}
