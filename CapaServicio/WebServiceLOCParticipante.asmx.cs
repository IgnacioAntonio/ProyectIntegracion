using CapaDTO;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CapaServicio
{
    /// <summary>
    /// Descripción breve de WebServiceLOCParticipante
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceLOCParticipante : System.Web.Services.WebService
    {

        [WebMethod]
        public void agregarParticipanteService(Participante participante, Comuna comuna, Sexo sexo, Estado_Participante estado)
        {
            NegocioParticipante auxNegocio = new NegocioParticipante();
            auxNegocio.agregarParticipante(participante, comuna, sexo, estado);
        }

        [WebMethod]
        public DataSet listarParticipanteService()
        {
            NegocioParticipante auxNegocio = new NegocioParticipante();
            return auxNegocio.listarParticipante();
        }

        [WebMethod]
        public void eliminarParticipanteService(Participante participante)
        {
            NegocioParticipante auxNegocio = new NegocioParticipante();
            auxNegocio.eliminarParticipante(participante);
        }

        [WebMethod]
        public Participante buscarRut(Participante participante)
        {
            NegocioParticipante auxNegocio = new NegocioParticipante();
            return auxNegocio.buscarRut(participante);

        }

        [WebMethod]
        public void modificarParticipanteService(Participante participante, Comuna comuna, Sexo sexo, Estado_Participante estado)
        {
            NegocioParticipante auxNegocio = new NegocioParticipante();
            auxNegocio.modificarParticipante(participante, comuna, sexo, estado);
        }

        [WebMethod]
        public DataSet buscarIdParticipanteServie()
        {
            NegocioParticipante auxNegocio = new NegocioParticipante();
            return auxNegocio.buscarIdParticipante();
        }
    }
}
