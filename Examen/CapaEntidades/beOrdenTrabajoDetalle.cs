using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class beOrdenTrabajoDetalle
    {
        public int Id_OTDetalle { get; set; }
        public int Id_OT { get; set; }
        public int Id_Equipo { get; set; }
        public string Descripcion_Equipo { get; set; }
        public string Descripcion_Marca { get; set; }
        public int CantEquipo_OT { get; set; }
    }
}
