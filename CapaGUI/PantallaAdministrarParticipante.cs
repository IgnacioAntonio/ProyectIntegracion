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
    public partial class PantallaAdministrarParticipante : Form
    {
        public PantallaAdministrarParticipante()
        {
            InitializeComponent();
        }

        private void BtnModificarParticipante_Click(object sender, EventArgs e)
        {
            PantallaModificarParticipante pantMP = new PantallaModificarParticipante();

            this.Dispose();
            pantMP.ShowDialog();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            PantallaMenu pantM = new PantallaMenu();
            this.Dispose();
            pantM.ShowDialog();


        }

        private void PantallaAdministrarParticipante_FormClosed(object sender, FormClosedEventArgs e)
        {
            PantallaMenu pantM = new PantallaMenu();
            this.Dispose();
            pantM.ShowDialog();
        }

        private void BtnListarParticipante_Click(object sender, EventArgs e)
        {
            PantallaListarParticipantes pantLP = new PantallaListarParticipantes();
            this.Dispose();
            pantLP.ShowDialog();
        }
    }
}
