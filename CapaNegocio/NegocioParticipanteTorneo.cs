using CapaConexion;
using CapaDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegocioParticipanteTorneo
    {
        private Conexion conex;

        public Conexion Conex { get => conex; set => conex = value; }

        public void configurarConexion()
        {
            this.Conex = new Conexion();
            this.Conex.NombreBaseDeDatos = "LOC";
            this.Conex.CadenaConexion = "Data Source=LAPTOP-F102RHF9\\SQLEXPRESS;Initial Catalog=LOC;Integrated Security=True";
        }

        public void agregarParticipanteTorneo(Participante participante, Torneo torneo)
        {
            {
                this.configurarConexion();
                this.Conex.CadenaSQL =
                "INSERT INTO Torneo_Participante " +
                "(Id_Torneo, " +
                "Id_Participante " +
                ") " +
                "VALUES (" +
                torneo.Id_Torneo1 + ", " +
                participante.Id_Participante1 + ") ;";


                this.Conex.EsSelect = false;
                this.Conex.conectar();
            }
        }
    }
}
