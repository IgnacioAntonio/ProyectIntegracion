using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Region
    {
        private Int64 Id_Region;
        private String Nombre_Region;
        private String Sigla_Region;

        public long Id_Region1 { get => Id_Region; set => Id_Region = value; }
        public string Nombre_Region1 { get => Nombre_Region; set => Nombre_Region = value; }
        public string Sigla_Region1 { get => Sigla_Region; set => Sigla_Region = value; }
    }
}
