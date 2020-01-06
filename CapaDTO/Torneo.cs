using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Torneo
    {
        private Int64 Id_Torneo;
        private String Nombre_Torneo;
        private String Descripcion_Torneo;
        private DateTime Fecha_Torneo;
        private Int64 Cantidad_Participante;

        public long Id_Torneo1 { get => Id_Torneo; set => Id_Torneo = value; }
        public string Nombre_Torneo1 { get => Nombre_Torneo; set => Nombre_Torneo = value; }
        public string Descripcion_Torneo1 { get => Descripcion_Torneo; set => Descripcion_Torneo = value; }
        public DateTime Fecha_Torneo1 { get => Fecha_Torneo; set => Fecha_Torneo = value; }
        public long Cantidad_Participante1 { get => Cantidad_Participante; set => Cantidad_Participante = value; }
    }
}
