using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class RolUsuario
    {
        public short ID { get; set; }
        public short UsuarioID { get; set; }
        public short RolID { get; set; }

        public bool Activo { get; set; }
        public short? usuarioRegistro { get; set; }
        public DateTime? fechaRegistro { get; set; }
        public short? usuarioActualiza { get; set; }
        public DateTime? fechaActualizacion { get; set; }
    }

    public class RolUsuarioView
    {
        public short RolUsuarioID { get; set; }
        public short RolID { get; set; }   
        public string nombreRol { get; set; }
        public string Username { get; set; }
        public short UsuarioID { get; set; }
        public short? UsuarioRegistro { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public short? UsuarioActualiza { get; set; }
        public DateTime? FechaActualizacion { get; set; }
    }
}
