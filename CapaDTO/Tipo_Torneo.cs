using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Tipo_Torneo
    {
        private Int64 Id_Tipo_Torneo;
        private String Nombre_Tipo_torneo;
        private String Descripcion_Tipo_Torneo;

        public long Id_Tipo_Torneo1 { get => Id_Tipo_Torneo; set => Id_Tipo_Torneo = value; }
        public string Nombre_Tipo_torneo1 { get => Nombre_Tipo_torneo; set => Nombre_Tipo_torneo = value; }
        public string Descripcion_Tipo_Torneo1 { get => Descripcion_Tipo_Torneo; set => Descripcion_Tipo_Torneo = value; }
    }
}
