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
    public partial class PantallaBusquedaAdministrar : Form
    {
        
        public PantallaBusquedaAdministrar()
        {
            InitializeComponent();

            cboTipoTorneo.Items.Add("Llave 4");
            cboTipoTorneo.Items.Add("Llave 8");
            cboTipoTorneo.Items.Add("Llave 16");
        }

        private void PantallaBusquedaAdministrar_Load(object sender, EventArgs e)
        {

        }
        

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            PantallaMenu pantM = new PantallaMenu();
            this.Dispose();

            pantM.ShowDialog();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            PantallaTorneo4 pantL4  = new PantallaTorneo4();
            PantallaLlave8 pantL8   = new PantallaLlave8();
            PantallaLlave16 pantL16 = new PantallaLlave16();


        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            ServiceLOC.WebServiceLOCSoapClient auxServiceLOC = new ServiceLOC.WebServiceLOCSoapClient();
            ServiceLOC.Tipo_Torneo auxTP = new ServiceLOC.Tipo_Torneo();

            if (cboTipoTorneo.SelectedIndex +1 >0 )
            {
                auxTP.Id_Tipo_Torneo1 = cboTipoTorneo.SelectedIndex + 1;

                this.dataGridTorneo.DataSource = auxServiceLOC.buscarTorneoService(auxTP);
                this.dataGridTorneo.DataMember = "Torneo";
            }
            else
            {
                MessageBox.Show("Porfavor seleccione un tipo torneo ", " No se ha podido buscar ");
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {

            ServiceLOC.WebServiceLOCSoapClient auxServiceLOC = new ServiceLOC.WebServiceLOCSoapClient();

            this.dataGridTorneo.DataSource = auxServiceLOC.listarTorneoService();
            this.dataGridTorneo.DataMember = "Torneo";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ServiceLOC.WebServiceLOCSoapClient auxServiceLOC = new ServiceLOC.WebServiceLOCSoapClient();
            ServiceLOC.Torneo auxTorneo = new ServiceLOC.Torneo();
            int idT;

            try
            {
                idT = Convert.ToInt32(dataGridTorneo.CurrentRow.Cells[0].Value);
                auxTorneo.Id_Torneo1 = idT;

                auxServiceLOC.eliminarTorneoService(auxTorneo);

                MessageBox.Show("Datos Eliminados" , "Mensaje de sistema");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos no Eliminados debido a que no selecciono la celda correcta " + ex.Message, " Mensaje Del Sistema ");
            }
        }
    }
}
