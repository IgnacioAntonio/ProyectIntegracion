namespace CapaGUI
{
    partial class PantallaModificarParticipante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdParticipante = new System.Windows.Forms.TextBox();
            this.dateTimeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtRutParticipante = new System.Windows.Forms.TextBox();
            this.txtNombreParticipante = new System.Windows.Forms.TextBox();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.cboEstadoParticipante = new System.Windows.Forms.ComboBox();
            this.cboComuna = new System.Windows.Forms.ComboBox();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboIDParticipante = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(131, 324);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(56, 19);
            this.btnModificar.TabIndex = 0;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(412, 324);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(56, 19);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 168);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rut Pariticpante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Comuna";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID Participantes Registrados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Estado Participante";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 235);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fecha Nacimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 230);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Apellido Materno";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(243, 163);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Apellido Paterno";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(243, 96);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Nombre Participante";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 101);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Id Participante";
            // 
            // txtIdParticipante
            // 
            this.txtIdParticipante.Location = new System.Drawing.Point(36, 131);
            this.txtIdParticipante.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdParticipante.Name = "txtIdParticipante";
            this.txtIdParticipante.Size = new System.Drawing.Size(76, 20);
            this.txtIdParticipante.TabIndex = 11;
            // 
            // dateTimeNacimiento
            // 
            this.dateTimeNacimiento.Location = new System.Drawing.Point(36, 265);
            this.dateTimeNacimiento.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeNacimiento.Name = "dateTimeNacimiento";
            this.dateTimeNacimiento.Size = new System.Drawing.Size(151, 20);
            this.dateTimeNacimiento.TabIndex = 12;
            // 
            // txtRutParticipante
            // 
            this.txtRutParticipante.Location = new System.Drawing.Point(36, 198);
            this.txtRutParticipante.Margin = new System.Windows.Forms.Padding(2);
            this.txtRutParticipante.Name = "txtRutParticipante";
            this.txtRutParticipante.Size = new System.Drawing.Size(76, 20);
            this.txtRutParticipante.TabIndex = 13;
            // 
            // txtNombreParticipante
            // 
            this.txtNombreParticipante.Location = new System.Drawing.Point(243, 126);
            this.txtNombreParticipante.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreParticipante.Name = "txtNombreParticipante";
            this.txtNombreParticipante.Size = new System.Drawing.Size(76, 20);
            this.txtNombreParticipante.TabIndex = 14;
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Location = new System.Drawing.Point(243, 193);
            this.txtApellidoPaterno.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(76, 20);
            this.txtApellidoPaterno.TabIndex = 15;
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Location = new System.Drawing.Point(243, 260);
            this.txtApellidoMaterno.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(76, 20);
            this.txtApellidoMaterno.TabIndex = 16;
            // 
            // cboEstadoParticipante
            // 
            this.cboEstadoParticipante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoParticipante.FormattingEnabled = true;
            this.cboEstadoParticipante.Location = new System.Drawing.Point(409, 128);
            this.cboEstadoParticipante.Margin = new System.Windows.Forms.Padding(2);
            this.cboEstadoParticipante.Name = "cboEstadoParticipante";
            this.cboEstadoParticipante.Size = new System.Drawing.Size(92, 21);
            this.cboEstadoParticipante.TabIndex = 17;
            // 
            // cboComuna
            // 
            this.cboComuna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboComuna.FormattingEnabled = true;
            this.cboComuna.Items.AddRange(new object[] {
            "Cerrillos",
            "Cerro Navia",
            "Conchali",
            "El Bosque",
            "Estacion Central",
            "Huechuraba",
            "Independencia",
            "La Cisterna",
            "La Granja",
            "La Florida",
            "La Pintana",
            "La Reina",
            "Las Condes",
            "Lo Barnechea",
            "Lo Espejo",
            "Lo Prado",
            "Macul",
            "Maipu",
            "Ñuñoa",
            "Pedro Aguirre Cerda",
            "Peñalolen",
            "Providencia",
            "Pudahuel",
            "Quilicura",
            "Quinta Normal",
            "Recoleta",
            "Renca",
            "San Miguel",
            "San Joaquin",
            "San Ramon",
            "Santiago",
            "Vitacura"});
            this.cboComuna.Location = new System.Drawing.Point(409, 190);
            this.cboComuna.Margin = new System.Windows.Forms.Padding(2);
            this.cboComuna.Name = "cboComuna";
            this.cboComuna.Size = new System.Drawing.Size(92, 21);
            this.cboComuna.TabIndex = 18;
            // 
            // cboSexo
            // 
            this.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Location = new System.Drawing.Point(409, 252);
            this.cboSexo.Margin = new System.Windows.Forms.Padding(2);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(92, 21);
            this.cboSexo.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(409, 225);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Sexo";
            // 
            // cboIDParticipante
            // 
            this.cboIDParticipante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIDParticipante.FormattingEnabled = true;
            this.cboIDParticipante.Location = new System.Drawing.Point(334, 39);
            this.cboIDParticipante.Name = "cboIDParticipante";
            this.cboIDParticipante.Size = new System.Drawing.Size(121, 21);
            this.cboIDParticipante.TabIndex = 21;
            this.cboIDParticipante.SelectedIndexChanged += new System.EventHandler(this.cboIDParticipante_SelectedIndexChanged);
            // 
            // PantallaModificarParticipante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.cboIDParticipante);
            this.Controls.Add(this.cboSexo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboComuna);
            this.Controls.Add(this.cboEstadoParticipante);
            this.Controls.Add(this.txtApellidoMaterno);
            this.Controls.Add(this.txtApellidoPaterno);
            this.Controls.Add(this.txtNombreParticipante);
            this.Controls.Add(this.txtRutParticipante);
            this.Controls.Add(this.dateTimeNacimiento);
            this.Controls.Add(this.txtIdParticipante);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnModificar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PantallaModificarParticipante";
            this.Text = "PantallaModificarParticipante";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PantallaModificarParticipante_FormClosed);
            this.Load += new System.EventHandler(this.PantallaModificarParticipante_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIdParticipante;
        private System.Windows.Forms.DateTimePicker dateTimeNacimiento;
        private System.Windows.Forms.TextBox txtRutParticipante;
        private System.Windows.Forms.TextBox txtNombreParticipante;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.ComboBox cboEstadoParticipante;
        private System.Windows.Forms.ComboBox cboComuna;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboIDParticipante;
    }
}