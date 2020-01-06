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
    public partial class PantallaTorneos : Form
    {
        public PantallaTorneos()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Registrar regis = new Registrar();
            this.Visible = false;
            regis.ShowDialog();
        }

        private void PantallaTorneos_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
            PantallaMenu pantM = new PantallaMenu();
            pantM.ShowDialog();
        }

        private void PantallaTorneos_FormClosed(object sender, FormClosedEventArgs e)
        {
            PantallaMenu pantM = new PantallaMenu();
            this.Dispose();
            pantM.ShowDialog();
        }
    }
}
