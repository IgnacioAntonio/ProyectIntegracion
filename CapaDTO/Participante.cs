using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Participante
    {

        private Int64 Id_Participante;
        private String Rut_Participante;
        private String Nombre_Participante;
        private String Apellido_Patreno_Participante;
        private String Apellido_Materno_Participante;
        private DateTime Fecha_Nacimiento_Participante;

        public long Id_Participante1 { get => Id_Participante; set => Id_Participante = value; }
        public string Rut_Participante1 { get => Rut_Participante; set => Rut_Participante = value; }
        public string Nombre_Participante1 { get => Nombre_Participante; set => Nombre_Participante = value; }
        public string Apellido_Patreno_Participante1 { get => Apellido_Patreno_Participante; set => Apellido_Patreno_Participante = value; }
        public string Apellido_Materno_Participante1 { get => Apellido_Materno_Participante; set => Apellido_Materno_Participante = value; }
        public DateTime Fecha_Nacimiento_Participante1 { get => Fecha_Nacimiento_Participante; set => Fecha_Nacimiento_Participante = value; }
    }
}
