using CapaConexion;
using CapaDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegocioTorneo
    {
        private Conexion conex;

        public Conexion Conex { get => conex; set => conex = value; }

        public void configurarConexion()
        {
            this.Conex = new Conexion();
            this.Conex.NombreBaseDeDatos = "LOC";
            this.Conex.CadenaConexion = "Data Source=LAPTOP-F102RHF9\\SQLEXPRESS;Initial Catalog=LOC;Integrated Security=True";
        }

        public void agregarTorneo(Torneo torneo, Tipo_Torneo tp)
        {
            this.configurarConexion();
            this.Conex.CadenaSQL =
                "INSERT INTO Torneo " +
                "(Nombre_Torneo, " +
                "Descripcion_Torneo, " +
                "Fecha_Torneo, " +
                "Id_Tipo_Torneo, " +
                "Cantidad_Participante) " +
                "VALUES ('" +
                torneo.Nombre_Torneo1+ "', '" +
                torneo.Descripcion_Torneo1 + "', CONVERT(DATETIME,'" +
                torneo.Fecha_Torneo1 + "',103), " +
                tp.Id_Tipo_Torneo1 + ", '" +
                torneo.Cantidad_Participante1 + "');";
            this.Conex.EsSelect = false;
            this.Conex.conectar();
        }

        public DataSet listarTorneo()
        {
            this.configurarConexion();
            this.Conex.NombreTabla = "Torneo";
            this.Conex.CadenaSQL =
                "SELECT * FROM Torneo ";
            this.Conex.EsSelect = true;
            this.Conex.conectar();
            return this.Conex.DbDataSet;
        }

        public DataSet buscarTorneo(Tipo_Torneo TP)
        {
            this.configurarConexion();
            this.Conex.NombreTabla = "Torneo";
            this.Conex.CadenaSQL =
                "SELECT * FROM Torneo WHERE Id_Tipo_Torneo = " + TP.Id_Tipo_Torneo1 + ";";
            this.Conex.EsSelect = true;
            this.Conex.conectar();
            return this.Conex.DbDataSet;
        }

        public void modificarTorneo(Torneo torneo, Tipo_Torneo tp)
        {
            this.configurarConexion();
            this.Conex.CadenaSQL =
                "UPDATE Torneo SET Nombre_Torneo = '" +
                torneo.Nombre_Torneo1 + "', Fecha_Torneo = CONVERT(DATETIME,'" +
                torneo.Fecha_Torneo1 + "',103), Id_Tipo_Torneo = '" +
                tp.Id_Tipo_Torneo1 + "' WHERE Id_Torneo = '" + torneo.Id_Torneo1 + "';";
            this.Conex.EsSelect = false;
            this.Conex.conectar();
        }

        public void eliminarTorneo(Torneo torneo)
        {
            this.configurarConexion();
            this.Conex.CadenaSQL =
                "DELETE FROM Torneo WHERE Id_Torneo = '" +
                torneo.Id_Torneo1 +"';";
            this.Conex.EsSelect = false;
            this.Conex.conectar();
        }


        public DataSet buscarIdTorneo()
        {
            this.configurarConexion();
            this.Conex.NombreTabla = "Torneo";
            this.Conex.CadenaSQL =
                "SELECT Id_Torneo FROM Torneo;";
            this.Conex.EsSelect = true;
            this.Conex.conectar();
            return this.Conex.DbDataSet;
        }

        public Torneo TraerDatosTorneo(Torneo torneo)
        {
            this.configurarConexion();
            this.Conex.NombreTabla = "Torneo";
            this.conex.CadenaSQL = "SELECT * FROM Torneo Where Id_Torneo = '" + torneo.Id_Torneo1 + "';";
            this.conex.EsSelect = true;
            this.conex.conectar();

            DataTable dt = new DataTable();

            Torneo auxTorneo = new Torneo();
            Tipo_Torneo auxTP = new Tipo_Torneo();

            try
            {
                dt = this.conex.DbDataSet.Tables["Torneo"];
                auxTorneo.Nombre_Torneo1 = (string)dt.Rows[0]["Nombre_Torneo"];                
                auxTP.Id_Tipo_Torneo1 = (Int64)dt.Rows[0]["Id_Tipo_Torneo"];
    
            }
            catch (Exception ex)
            {
                
                auxTorneo.Nombre_Torneo1 = string.Empty;
                auxTP.Id_Tipo_Torneo1 = 0;

            }

            return auxTorneo;
        }

    }
}
