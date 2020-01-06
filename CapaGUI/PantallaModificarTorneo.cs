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
    public partial class PantallaModificarTorneo : Form
    {
        public PantallaModificarTorneo()
        {
            InitializeComponent();

            

            cboTipoTorneo.Items.Add("Llave 4");
            cboTipoTorneo.Items.Add("Llave 8");
            cboTipoTorneo.Items.Add("Llave 16");

            

        }

        private void PantallaModificarTorneo_FormClosed(object sender, FormClosedEventArgs e)
        {
            PantallaTorneoLlave pantBA = new PantallaTorneoLlave();
            this.Dispose();
            pantBA.ShowDialog();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            PantallaMenu pantM = new PantallaMenu();
            this.Dispose();
            pantM.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtNombreTorneo.Text.Length < 50 && txtNombreTorneo.Text.Length > 0)
            {
                if (cboTipoTorneo.SelectedIndex + 1 > 0)
                {
                    if (dateTimeTorneo.Value >= DateTime.Today)
                    {
                        try
                        {
                            ServiceLOC.WebServiceLOCSoapClient auxServiceLOC = new ServiceLOC.WebServiceLOCSoapClient();

                            ServiceLOC.Torneo auxTorneo = new ServiceLOC.Torneo();
                            ServiceLOC.Tipo_Torneo auxTP = new ServiceLOC.Tipo_Torneo();
                

                            auxTorneo.Id_Torneo1 = Convert.ToInt64(txtID.Text);
                            auxTorneo.Nombre_Torneo1 = this.txtNombreTorneo.Text;
                            auxTorneo.Fecha_Torneo1 = dateTimeTorneo.Value;
                            auxTP.Id_Tipo_Torneo1 = cboTipoTorneo.SelectedIndex + 1;
                            auxTorneo.Cantidad_Participante1 = cantidad();

                            auxServiceLOC.modificarTorneoService(auxTorneo, auxTP);


                            MessageBox.Show("Datos Eliminados", "Mensaje de sistema");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Datos no eliminados" + ex.Message, "Mensaje de sistema");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Fecha no puede ser anterior a hoy");
                    }
                }
                else
                {
                    MessageBox.Show("Debe Seleccionar un tipo de torneo");
                }
            }

            else
            {
                MessageBox.Show("El nombre del torneo debe contener entre 1 y 50 caracteres");
            }
        }

        private void PantallaModificarTorneo_Load(object sender, EventArgs e)
        {
            ServiceLOC.WebServiceLOCSoapClient auxServiceLOC = new ServiceLOC.WebServiceLOCSoapClient();

            cboId.DataSource = auxServiceLOC.buscarIdTorneo().Tables[0].DefaultView;
            cboId.DisplayMember = "Torneo";
            cboId.ValueMember = "Id_Torneo";
        }

        private void cboId_SelectedIndexChanged(object sender, EventArgs e)
        {
      
            string id = cboId.Text.ToString();
            this.txtID.Text = id;

        }

        public int cantidad()
        {
            int cantidad = 0;

            if (cboTipoTorneo.SelectedIndex == 0)
            {
                cantidad = 4;
            }
            if (cboTipoTorneo.SelectedIndex == 1)
            {
                cantidad = 8;
            }
            if (cboTipoTorneo.SelectedIndex == 2)
            {
                cantidad = 16;
            }

            return cantidad;
        }

        private void btoCargar_Click(object sender, EventArgs e)
        {
      
        }
    }
}
