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
    public partial class PantallaRegistrarTorneo : Form
    {
        public PantallaRegistrarTorneo()
        {
            InitializeComponent();

            cboTipoTorneo.Items.Add("Llave 4");
            cboTipoTorneo.Items.Add("Llave 8");
            cboTipoTorneo.Items.Add("Llave 16");
        }
       
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            ServiceLOC.WebServiceLOCSoapClient auxServiceLOC = new ServiceLOC.WebServiceLOCSoapClient();

            ServiceLOC.Torneo auxTorneo = new ServiceLOC.Torneo();
            ServiceLOC.Tipo_Torneo auxTP = new ServiceLOC.Tipo_Torneo();

            if (txtNombreTorneo.Text.Length < 50 && txtNombreTorneo.Text.Length > 0)
            {
                if (txtDescripcionTorneo.Text.Length < 50 && txtDescripcionTorneo.Text.Length > 0)
                {
                    if (cboTipoTorneo.SelectedIndex + 1 > 0)
                    {
                        if (dateTimeFechaTorneo.Value >= DateTime.Today)
                        {

                            try
                            {
               

                                auxTorneo.Nombre_Torneo1 = this.txtNombreTorneo.Text;
                                auxTorneo.Descripcion_Torneo1 = this.txtDescripcionTorneo.Text;
                                auxTorneo.Fecha_Torneo1 = dateTimeFechaTorneo.Value;
                                auxTP.Id_Tipo_Torneo1 = cboTipoTorneo.SelectedIndex + 1;
                                auxTorneo.Cantidad_Participante1 = cantidad();
                

                                auxServiceLOC.agregarTorneoService(auxTorneo, auxTP);


                                 MessageBox.Show("Datos guardados", "Mensaje de sistema");
                            }
                            catch (Exception ex)
                            {
                                 MessageBox.Show("Datos no guardados" + ex.Message, "Mensaje de sistema");
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
                    MessageBox.Show("La Descripcion debe contener entre 1 y 50 caracteres");
                }


            }
            else
            {
                MessageBox.Show("El nombre del torneo debe contener entre 1 y 50 caracteres");
            }


        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            PantallaAgregarParticipanteTorneo pantAPT = new PantallaAgregarParticipanteTorneo();
            this.Dispose();
            pantAPT.ShowDialog();
        }

        private void PantallaRegistrarTorneo_FormClosed(object sender, FormClosedEventArgs e)
        {
            PantallaMenu pantM= new PantallaMenu();
            this.Dispose();
            pantM.ShowDialog();
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
    }
}
