using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Comuna
    {
        private Int64 Id_Comuna;
        private String Nombre_Comuna;
        private String Sigla_Comuna;

        public long Id_Comuna1 { get => Id_Comuna; set => Id_Comuna = value; }
        public string Nombre_Comuna1 { get => Nombre_Comuna; set => Nombre_Comuna = value; }
        public string Sigla_Comuna1 { get => Sigla_Comuna; set => Sigla_Comuna = value; }
    }
}
