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
    public class NegocioParticipante
    {
        private Conexion conex;

        public Conexion Conex { get => conex; set => conex = value; }

        public void configurarConexion()
        {
            this.Conex = new Conexion();
            this.Conex.NombreBaseDeDatos = "LOC";
            this.Conex.CadenaConexion = "Data Source=LAPTOP-F102RHF9\\SQLEXPRESS;Initial Catalog=LOC;Integrated Security=True";
        }

        public void agregarParticipante(Participante participante,  Comuna comuna, Sexo sexo, Estado_Participante estado)
        {
            this.configurarConexion();
            this.Conex.CadenaSQL =
                "INSERT INTO Participante " +
                "(Rut_Participante, " +
                "Nombre_Participante, " +
                "Apellido_Paterno_Participante, " +
                "Apellido_Materno_Participante, " +
                "Fecha_Nacimiento_Participante, " +
                "Id_Comuna, " +
                "Id_Sexo, " +
                "Id_Estado_Participante) " +
                "VALUES ('" +
                participante.Rut_Participante1 + "', '" +
                participante.Nombre_Participante1 + "', '" +
                participante.Apellido_Patreno_Participante1 + "', '" +
                participante.Apellido_Materno_Participante1 + "', CONVERT(DATETIME,'" +
                participante.Fecha_Nacimiento_Participante1 + "',103), " +
                comuna.Id_Comuna1 + ", " +
                sexo.Id_Sexo1 + ", " +
                estado.Id_Estado_Comuna1 + ");";
            this.Conex.EsSelect = false;
            this.Conex.conectar();
        }

        public DataSet listarParticipante()
        {
            this.configurarConexion();
            this.Conex.NombreTabla = "Participante";
            this.Conex.CadenaSQL =
                "SELECT * FROM Participante ";
            this.Conex.EsSelect = true;
            this.Conex.conectar();
            return this.Conex.DbDataSet;
        }

        public void eliminarParticipante(Participante participante)
        {
            this.configurarConexion();
            this.Conex.CadenaSQL =
                "DELETE FROM Participante WHERE Id_Participante = '" +
                participante.Id_Participante1 + "';";
            this.Conex.EsSelect = false;
            this.Conex.conectar();
        }

        public Participante buscarRut(Participante participante)
        {
            this.configurarConexion();
            this.Conex.NombreTabla = "Participante";
            this.Conex.CadenaSQL =
                "SELECT * FROM Participante WHERE Rut_Participante = " + participante.Rut_Participante1 + ";";
            this.Conex.EsSelect = true;
            this.Conex.conectar();
            DataTable dt = new DataTable();
            dt = this.conex.DbDataSet.Tables["Participante"];

            Participante auxParticipante = new Participante();
            try
            { 
                auxParticipante.Rut_Participante1 = (String)dt.Rows[0]["Rut_Participante"];
                
            }
            catch
            {
                auxParticipante.Rut_Participante1 = String.Empty;
            }
            return auxParticipante;
        }

        public void modificarParticipante(Participante participante, Comuna comuna, Sexo sexo, Estado_Participante estado)
        {
            this.configurarConexion();
            this.Conex.CadenaSQL =
                "UPDATE Participante SET Rut_Participante = '" +
                participante.Rut_Participante1 + "'," +
                "Nombre_Participante = '" + participante.Nombre_Participante1 + " ', " +
                "Apellido_Paterno_Participante = '" + participante.Apellido_Patreno_Participante1 + "'," +
                "Apellido_Materno_Participante = '" + participante.Apellido_Materno_Participante1 + "' ," +
                "Fecha_Nacimiento_Participante = CONVERT(DATETIME,'" + participante.Fecha_Nacimiento_Participante1 + "',103)," +
                "Id_Comuna = '" + comuna.Id_Comuna1 + "' ," +
                "Id_Estado_Participante = '" + estado.Id_Estado_Comuna1 + "' ," +
                "Id_Sexo = '" + sexo.Id_Sexo1 + "'" +
                "WHERE Id_Participante = '" + participante.Id_Participante1 + "';";
            this.Conex.EsSelect = false;
            this.Conex.conectar();
        }

        public DataSet buscarIdParticipante()
        {
            this.configurarConexion();
            this.Conex.NombreTabla = "Participante";
            this.Conex.CadenaSQL =
                "SELECT Id_Participante FROM Participante;";
            this.Conex.EsSelect = true;
            this.Conex.conectar();
            return this.Conex.DbDataSet;
        }
    }
}
