using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Usuario
    {
        public short ID { get; set; }
        public string Nombre { get; set; } = null!;
        public string Username { get; set; } = null!;
        public short PermisoID { get; set; }
        public string Correo { get; set; } = null!;
        public byte[] Contrasena { get; set; } = null!;
        public bool Bloqueado { get; set; }
        public short Contador { get; set; }

        public bool Activo { get; set; }
        public short? usuarioRegistro { get; set; }
        public DateTime? fechaRegistro { get; set; }
        public short? usuarioActualiza { get; set; }
        public DateTime? fechaActualizacion { get; set; }

        public ICollection<Factura> Facturas { get; } = new List<Factura>();
        public List<RolUsuario> RolUsuarios { get; } = new();
        public List<Rol> Roles { get; } = new();
        public Permiso Permiso { get; set; } = null!;
    }
}
