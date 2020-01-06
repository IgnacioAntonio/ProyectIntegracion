using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaGUI
{
    public partial class PantallaListarParticipantes : Form
    {
        public PantallaListarParticipantes()
        {
            InitializeComponent();
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            ServiceLOCParticipante.WebServiceLOCParticipanteSoapClient auxService = new ServiceLOCParticipante.WebServiceLOCParticipanteSoapClient();

            this.dataGridParticipante.DataSource = auxService.listarParticipanteService();
            this.dataGridParticipante.DataMember = "Participante";
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ServiceLOCParticipante.WebServiceLOCParticipanteSoapClient auxService = new ServiceLOCParticipante.WebServiceLOCParticipanteSoapClient();
            ServiceLOCParticipante.Participante auxParticipante = new ServiceLOCParticipante.Participante();
            int idP;

            try
            {
                idP = Convert.ToInt32(dataGridParticipante.CurrentRow.Cells[0].Value);
                auxParticipante.Id_Participante1 = idP; 

                auxService.eliminarParticipanteService(auxParticipante);

                MessageBox.Show("Datos Eliminados", "Mensaje de sistema");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos no Eliminados debido a que no selecciono la celda correcta " + ex.Message, " Mensaje Del Sistema ");
            }
        }

        private void PantallaListarParticipantes_FormClosed(object sender, FormClosedEventArgs e)
        {
            PantallaAdministrarParticipante pantAP = new PantallaAdministrarParticipante();
            this.Dispose();
            pantAP.ShowDialog();
        }
    }
}
