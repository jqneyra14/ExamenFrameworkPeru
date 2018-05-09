using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
   public class beOrdenTrabajo
    {
        public int Id_OT { get; set; }
        public string Numero_OT { get; set; }
        public DateTime Fecha_OT { get; set; }
        public string Estado_OT { get; set; }
        public string Descripcion_OT { get; set; }
    }
}
