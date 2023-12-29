using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class RolFormulario
    {
        public short ID { get; set; }
        public short RolID { get; set; }
        public short FormularioID { get; set; }
        public bool Activo { get; set; }
        public short? usuarioRegistro { get; set; }
        public DateTime? fechaRegistro { get; set; }
        public short? usuarioActualiza { get; set; }
        public DateTime? fechaActualizacion { get; set; }

    }

    public class RolFormularioView
    {
        public short ID { get; set; }
        public short RolID { get; set; }
        public string NombreRol { get; set; }
        public short FormularioID { get; set; }
        public string NombreFormulario { get; set; }
        public bool Habilitado { get; set; }
        public short? UsuarioActualiza { get; set; }
        public DateTime? FechaActualizacion { get; set; }
    }
}
