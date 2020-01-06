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
    public partial class PantallaAgregarParticipante : Form
    {
        public PantallaAgregarParticipante()
        {
            InitializeComponent();

            cboSexo.Items.Add("Masculino");
            cboSexo.Items.Add("Femenino");
            cboSexo.Items.Add("Otro");

            cboEstadoParticipante.Items.Add("Activo");
            cboEstadoParticipante.Items.Add("Descalificado");

        }

        private void BtoAgregarP_Click(object sender, EventArgs e)
        {
            ServiceLOCParticipante.WebServiceLOCParticipanteSoapClient auxService = new ServiceLOCParticipante.WebServiceLOCParticipanteSoapClient();
            ServiceLOCParticipante.Participante auxParticipante = new ServiceLOCParticipante.Participante();
            ServiceLOCParticipante.Comuna auxComuna = new ServiceLOCParticipante.Comuna();
            ServiceLOCParticipante.Sexo auxSexo = new ServiceLOCParticipante.Sexo();
            ServiceLOCParticipante.Estado_Participante auxEstado = new ServiceLOCParticipante.Estado_Participante();

            if (txtRutParticipante.Text.Length<11 && txtRutParticipante.Text.Length > 8)
            {
                if (txtNombreParticipante.Text.Length < 15 && txtNombreParticipante.Text.Length > 3)
                {
                    if (txtApellidoParterno.Text.Length < 15 && txtApellidoParterno.Text.Length > 2)
                    {
                        if (txtApellidoMaterno.Text.Length < 15 && txtApellidoMaterno.Text.Length > 2)
                        {
                            if (cboComuna.SelectedIndex +1 >0)
                            {
                                if (cboSexo.SelectedIndex +1>0)
                                {
                                    if (dateTimeNacimiento.Value < DateTime.Today)
                                    {
                                        if (cboEstadoParticipante.SelectedIndex + 1 > 0)
                                        {
                                            if (existeRut()== false )
                                            {
                                            
                                                try
                                                {

                                                    auxParticipante.Rut_Participante1 = this.txtRutParticipante.Text;
                                                    auxParticipante.Nombre_Participante1 = this.txtNombreParticipante.Text;
                                                    auxParticipante.Apellido_Patreno_Participante1 = this.txtApellidoParterno.Text;
                                                    auxParticipante.Apellido_Materno_Participante1 = this.txtApellidoMaterno.Text;
                                                    auxParticipante.Fecha_Nacimiento_Participante1 = dateTimeNacimiento.Value;
                                                    auxComuna.Id_Comuna1 = cboComuna.SelectedIndex + 1;
                                                    auxSexo.Id_Sexo1 = cboSexo.SelectedIndex + 1;
                                                    auxEstado.Id_Estado_Comuna1 = cboEstadoParticipante.SelectedIndex + 1;


                                                    auxService.agregarParticipanteService(auxParticipante, auxComuna, auxSexo, auxEstado);


                                                    MessageBox.Show("Datos guardados", "Mensaje de sistema");
                                                }
                                                catch (Exception ex)
                                                {
                                                    MessageBox.Show("Datos no guardados" + ex.Message, "Mensaje de sistema");
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Datos no guardados", "El rut que intenta guardar ya existe");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Debe seleccionar estado de participante");
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

    

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            PantallaMenu pantM = new PantallaMenu();
            this.Dispose();
            pantM.ShowDialog();
        }

        private void PantallaAgregarParticipante_FormClosed(object sender, FormClosedEventArgs e)
        {
            PantallaMenu pantM = new PantallaMenu();
            this.Dispose();
            pantM.ShowDialog();
        }

        private Boolean existeRut()
        {
            ServiceLOCParticipante.WebServiceLOCParticipanteSoapClient auxService = new ServiceLOCParticipante.WebServiceLOCParticipanteSoapClient();
            ServiceLOCParticipante.Participante auxParticipante = new ServiceLOCParticipante.Participante();
            bool auxExiste;

            auxParticipante.Rut_Participante1 = this.txtRutParticipante.Text; 

            if (Convert.ToString(auxService.buscarRut(auxParticipante).Rut_Participante1) == txtRutParticipante.Text)
            {
                auxExiste = true;
            }
            else
            {
                auxExiste = false;
            }

            return auxExiste;
        }
    }
}
