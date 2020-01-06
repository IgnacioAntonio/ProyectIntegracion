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
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            PantallaAgregarParticipanteTorneo pantAPT = new PantallaAgregarParticipanteTorneo();
            pantAPT.ShowDialog();
          
        }

        private void Registrar_FormClosed(object sender, FormClosedEventArgs e)
        {
            PantallaMenu pantM = new PantallaMenu();
            this.Dispose();
            //System.GC.Collect();
            pantM.ShowDialog();
        }
    }
}
