using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class beEquipo
    {
        public int Id_Equipo{ get; set; }
        public string Descripcion_Equipo { get; set; }
        public int Id_Marca { get; set; }
        public string Descripcion_Marca { get; set; }
        public string Modelo_Equipo { get; set; }
        public string Serie_Equipo { get; set; }
        public int CantBase_Equipo { get; set; }
        public int CantComprometida_Equipo { get; set; }
        public int CantDisponible_Equipo { get; set; }
        public string Estado_Equipo { get; set; }
    }
}
