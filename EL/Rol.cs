using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Rol
    {
        public short ID { get; set; }
        public string nombreRol { get; set; } = null!;
        public bool Activo { get; set; }
        public short? usuarioRegistro { get; set; }
        public DateTime? fechaRegistro { get; set; }
        public short? usuarioActualiza { get; set; }
        public DateTime? fechaActualizacion { get; set; }

        public List<RolUsuario> RolUsuarios { get; } = new();
        public List<Usuario> Usuarios { get; } = new();

        public List<RolFormulario> RolFormularios { get; } = new();
        public List<Formulario> Formularios { get; } = new();

    }
}
