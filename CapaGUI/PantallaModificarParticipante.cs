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
    public partial class PantallaModificarParticipante : Form
    {
        public PantallaModificarParticipante()
        {
            InitializeComponent();

            cboSexo.Items.Add("Masculino");
            cboSexo.Items.Add("Femenino");
            cboSexo.Items.Add("Otro");

            cboEstadoParticipante.Items.Add("Activo");
            cboEstadoParticipante.Items.Add("Descalificado");
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            PantallaMenu pantM = new PantallaMenu();
            this.Dispose();
            pantM.ShowDialog();
        }

        private void PantallaModificarParticipante_FormClosed(object sender, FormClosedEventArgs e)
        {
            PantallaAdministrarParticipante pantAP = new PantallaAdministrarParticipante();
            this.Dispose();
            pantAP.ShowDialog();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

        }
        private void btnModificar_Click_1(object sender, EventArgs e)
        {
                ServiceLOCParticipante.WebServiceLOCParticipanteSoapClient auxServicePartici = new ServiceLOCParticipante.WebServiceLOCParticipanteSoapClient();

                ServiceLOCParticipante.Participante auxPartici = new ServiceLOCParticipante.Participante();
                ServiceLOCParticipante.Comuna auxComuna = new ServiceLOCParticipante.Comuna();
                ServiceLOCParticipante.Sexo auxSexo = new ServiceLOCParticipante.Sexo();
                ServiceLOCParticipante.Estado_Participante auxEstado = new ServiceLOCParticipante.Estado_Participante();

                if (txtRutParticipante.Text.Length < 11 && txtRutParticipante.Text.Length > 8)
                {
                    if (txtNombreParticipante.Text.Length < 15 && txtNombreParticipante.Text.Length > 3)
                    {
                        if (txtApellidoPaterno.Text.Length < 15 && txtApellidoPaterno.Text.Length > 2)
                        {
                            if (txtApellidoMaterno.Text.Length < 15 && txtApellidoMaterno.Text.Length > 2)
                            {
                                if (cboComuna.SelectedIndex + 1 > 0)
                                {
                                    if (cboSexo.SelectedIndex + 1 > 0)
                                    {
                                        if (dateTimeNacimiento.Value < DateTime.Today)
                                        {
                                            try
                                            {
                                            auxPartici.Id_Participante1 = Convert.ToInt64(this.txtIdParticipante.Text);
                                                auxPartici.Rut_Participante1 = this.txtRutParticipante.Text;
                                                auxPartici.Nombre_Participante1 = this.txtNombreParticipante.Text;
                                                auxPartici.Apellido_Patreno_Participante1 = this.txtApellidoPaterno.Text;
                                                auxPartici.Apellido_Materno_Participante1 = this.txtApellidoMaterno.Text;
                                                auxPartici.Fecha_Nacimiento_Participante1 = dateTimeNacimiento.Value;
                                                auxComuna.Id_Comuna1 = cboComuna.SelectedIndex + 1;
                                                auxSexo.Id_Sexo1 = cboSexo.SelectedIndex + 1;
                                                auxEstado.Id_Estado_Comuna1 = cboEstadoParticipante.SelectedIndex + 1;


                                                auxServicePartici.modificarParticipanteService(auxPartici, auxComuna, auxSexo, auxEstado);


                                                MessageBox.Show("Datos guardados", "Mensaje de sistema");
                                            }
                                            catch (Exception ex)
                                            {
                                                MessageBox.Show("Datos no guardados" + ex.Message, "Mensaje de sistema");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Debe ingresar una fecha de nacimiento valida");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Debe seleccionar sexo");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Debe seleccionar una Comuna");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Apellido de Participante debe ser de entre 2 y 50 caracteres");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Apellido de Participante debe ser de entre 2 y 50 caracteres");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nombre de Participante debe ser entre 2 y 50 caracteres");
                    }
                }
                else
                {
                    MessageBox.Show("Rut de Participante debe ser entre 9 y 10 caracteres");
                }

            
        }

        private void PantallaModificarParticipante_Load(object sender, EventArgs e)
        {
            ServiceLOCParticipante.WebServiceLOCParticipanteSoapClient auxService = new ServiceLOCParticipante.WebServiceLOCParticipanteSoapClient();

            cboIDParticipante.DataSource = auxService.buscarIdParticipanteServie().Tables[0].DefaultView;
            cboIDParticipante.DisplayMember = "Participante";
            cboIDParticipante.ValueMember = "Id_Participante";
        }

        private void cboIDParticipante_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = cboIDParticipante.Text.ToString();
            this.txtIdParticipante.Text = id;
        }
    }
}
