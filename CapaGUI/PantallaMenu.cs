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
    public partial class PantallaMenu : Form
    {
        public PantallaMenu()
        {
            InitializeComponent();
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void LlaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void TorneoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void AdministrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaTorneoLlave pantTL = new PantallaTorneoLlave();
            this.Dispose();
            pantTL.ShowDialog();
            
        }

        private void AgregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaRegistrarTorneo pantRT = new PantallaRegistrarTorneo();
            this.Dispose();
            System.GC.Collect();
            pantRT.ShowDialog();
            
        }

        private void ParticipantesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AgregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PantallaAgregarParticipante pantAP = new PantallaAgregarParticipante();
            this.Dispose();
            pantAP.ShowDialog();
        }

        private void PantallaMenu_Load(object sender, EventArgs e)
        {

        }

        private void AdministrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PantallaAdministrarParticipante pantAP = new PantallaAdministrarParticipante();
            this.Dispose();
            pantAP.ShowDialog();
        }

        private void PantallaMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
