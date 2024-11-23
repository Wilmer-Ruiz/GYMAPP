//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public string? Nombre { get; set; } = string.Empty;
        public string? Apellido { get; set; } = string.Empty;
        public string? CorreoElectronico { get; set; }
        public string? Telefono { get; set; }
    }
}
