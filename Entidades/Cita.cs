//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Entidades
{
    public class Cita
    {
        public int CitaID { get; set; }
        public DateTime FechaHora { get; set; }
        public int ClienteID { get; set; }
        public string? Notas { get; set; }
        public int TrabajadorID { get; set; }
        public Cliente? Cliente { get; set; }
        public Trabajador? Trabajador { get; set; }
        public List<Servicio> Servicios { get; set; } = new();
    }
}
