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
    /// Descripción breve de WebServiceLOC
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceLOC : System.Web.Services.WebService
    {

        [WebMethod]
        public void agregarTorneoService(Torneo torneo, Tipo_Torneo tp)
        {
            NegocioTorneo auxNegocio = new NegocioTorneo();
            auxNegocio.agregarTorneo(torneo, tp);
        }

        [WebMethod]
        public DataSet listarTorneoService()
        {
            NegocioTorneo auxNegocio = new NegocioTorneo();
            return auxNegocio.listarTorneo();
        }

        [WebMethod]
        public void modificarTorneoService(Torneo torneo, Tipo_Torneo tp)
        {
            NegocioTorneo auxNegocio = new NegocioTorneo();
            auxNegocio.modificarTorneo(torneo, tp);
        }

        [WebMethod]
        public DataSet buscarTorneoService(Tipo_Torneo TP)
        {
            NegocioTorneo auxNegocio = new NegocioTorneo();
            return auxNegocio.buscarTorneo(TP);

        }

        [WebMethod]
        public void eliminarTorneoService(Torneo torneo)
        {
            NegocioTorneo auxNegocio = new NegocioTorneo();
            auxNegocio.eliminarTorneo(torneo);
        }

        [WebMethod]
        public DataSet buscarIdTorneo()
        {
            NegocioTorneo auxNegocio = new NegocioTorneo();
            return auxNegocio.buscarIdTorneo();
        }

        [WebMethod]
        public Torneo TraerDatosTorneoService(Torneo torneo)
        {
            NegocioTorneo auxNegocio = new NegocioTorneo();
            return auxNegocio.TraerDatosTorneo(torneo);
        }

    }
}
