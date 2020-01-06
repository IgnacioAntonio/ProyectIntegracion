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
    public partial class PantallaAgregarParticipanteTorneo : Form
    {
        public PantallaAgregarParticipanteTorneo()
        {
            InitializeComponent();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            PantallaMenu pantM = new PantallaMenu();
            this.Dispose();
            pantM.ShowDialog();
        }

        private void BtnListarParticipante_Click(object sender, EventArgs e)
        {
            
        }

        private void btnListarTorneo_Click(object sender, EventArgs e)
        {
            ServiceLOC.WebServiceLOCSoapClient auxServiceLOC = new ServiceLOC.WebServiceLOCSoapClient();

            this.dataGridTorneo.DataSource = auxServiceLOC.listarTorneoService();
            this.dataGridTorneo.DataMember = "Torneo";
        }

        private void dataGridParticipante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ServiceLOCTP.WebServiceLOCTPSoapClient auxServiceTP = new ServiceLOCTP.WebServiceLOCTPSoapClient();
            ServiceLOCTP.Participante auxParticipante = new ServiceLOCTP.Participante();
            ServiceLOCTP.Torneo auxTorneo = new ServiceLOCTP.Torneo();
            
            int id;

           
            id = Convert.ToInt32(dataGridParticipante.CurrentRow.Cells[0].Value);
            txtIdParticipante.Text = Convert.ToString(id);
        }

        private void btnAgregarParticipante_Click(object sender, EventArgs e)
        {


            ServiceLOCTP.WebServiceLOCTPSoapClient auxServiceTP = new ServiceLOCTP.WebServiceLOCTPSoapClient();
            ServiceLOCTP.Participante auxParticipante = new ServiceLOCTP.Participante();
            ServiceLOCTP.Torneo auxTorneo = new ServiceLOCTP.Torneo();

            if (txtIdParticipante.Text != String.Empty)
            {
                if (txtIdTorneo.Text != String.Empty)
                {

                    try
                    {
                        auxParticipante.Id_Participante1 = Convert.ToInt64(txtIdParticipante.Text);
                        auxTorneo.Id_Torneo1 = Convert.ToInt64(txtIdTorneo.Text);
                        auxServiceTP.agregarParticipanteTorneoService(auxParticipante, auxTorneo);


                        MessageBox.Show(" Se ha guardado correctamente");
                    }
                    catch
                    {
                        MessageBox.Show("No se ha guardado");
                    }
                }
                else
                {
                    MessageBox.Show("Porfavor seleccione un Torneo ","No se ha guardado");
                }
            }
            else
            {
                MessageBox.Show("Porfavor seleccione un Participante ", "No se ha guardado");
            }
        }

        private void dataGridTorneo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ServiceLOCTP.WebServiceLOCTPSoapClient auxServicePrticipanteTorneo = new ServiceLOCTP.WebServiceLOCTPSoapClient();
            ServiceLOCTP.Participante auxParticipante = new ServiceLOCTP.Participante();
            ServiceLOCTP.Torneo auxTorneo = new ServiceLOCTP.Torneo();
            
            int id;

            
            id = Convert.ToInt32(dataGridTorneo.CurrentRow.Cells[0].Value);
            txtIdTorneo.Text = Convert.ToString(id);
        }

        private void dataGridTorneo_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ServiceLOCTP.WebServiceLOCTPSoapClient auxServicePrticipanteTorneo = new ServiceLOCTP.WebServiceLOCTPSoapClient();
            ServiceLOCTP.Participante auxParticipante = new ServiceLOCTP.Participante();
            ServiceLOCTP.Torneo auxTorneo = new ServiceLOCTP.Torneo();
            
            int id;

            if (Convert.ToString(dataGridTorneo.CurrentCell.Value) != String.Empty)
            {

                id = Convert.ToInt32(dataGridTorneo.CurrentRow.Cells[0].Value);
                txtIdTorneo.Text = Convert.ToString(id);
            }
            else
            {
                MessageBox.Show("Porfavor Seleccione una celda con valores", "No se ha podido seleccionar");
            }

        }

        private void dataGridParticipante_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ServiceLOCTP.WebServiceLOCTPSoapClient auxServiceTP = new ServiceLOCTP.WebServiceLOCTPSoapClient();
            ServiceLOCTP.Participante auxParticipante = new ServiceLOCTP.Participante();
            ServiceLOCTP.Torneo auxTorneo = new ServiceLOCTP.Torneo();
            
            int id;

            if (Convert.ToString(dataGridParticipante.CurrentCell.Value) != String.Empty)
            {
                id = Convert.ToInt32(dataGridParticipante.CurrentRow.Cells[0].Value);
                txtIdParticipante.Text = Convert.ToString(id);
            }
            else
            {
                MessageBox.Show("Porfavor Seleccione una celda con valores", "No se ha podido seleccionar");
            }
        }

        private void btnListarParticipante_Click_1(object sender, EventArgs e)
        {
            ServiceLOCParticipante.WebServiceLOCParticipanteSoapClient auxService = new ServiceLOCParticipante.WebServiceLOCParticipanteSoapClient();

            this.dataGridParticipante.DataSource = auxService.listarParticipanteService();
            this.dataGridParticipante.DataMember = "Participante";
        }
    }
}
