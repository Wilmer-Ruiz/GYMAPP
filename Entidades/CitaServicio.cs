//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Entidades
{
    public class CitaServicio
    {
        public int CitaServicioID { get; set; }
        public int ServicioID { get; set; }
        public Servicio? Servicio { get; set; }
        public int CitaID { get; set; }
        public Cita? Cita { get; set; }
    }
}
