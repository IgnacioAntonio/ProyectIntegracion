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
    public partial class PantallaTorneoLlave : Form
    {
        public PantallaTorneoLlave()
        {
            InitializeComponent();
        }

        private void Llave4_Click(object sender, EventArgs e)
        {
            PantallaBusquedaAdministrar pantBA = new PantallaBusquedaAdministrar();
            this.Dispose();
            pantBA.ShowDialog();
        }

        private void Llave8_Click(object sender, EventArgs e)
        {
            PantallaModificarTorneo pantMT = new PantallaModificarTorneo();
            this.Dispose();
            pantMT.ShowDialog();
        }

        private void Llave16_Click(object sender, EventArgs e)
        {
            PantallaBusquedaAdministrar pantBA = new PantallaBusquedaAdministrar();
            this.Dispose();
            pantBA.ShowDialog();
        }

        private void PantallaTorneoLlave_Load(object sender, EventArgs e)
        {

        }

        private void SalirL_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
            PantallaMenu pantM = new PantallaMenu();
            pantM.ShowDialog();
        }

        private void PantallaTorneoLlave_FormClosed(object sender, FormClosedEventArgs e)
        {
            PantallaMenu pantM = new PantallaMenu();
            this.Dispose();
            pantM.ShowDialog();
        }
    }
}
