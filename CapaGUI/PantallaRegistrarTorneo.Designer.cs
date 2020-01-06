namespace CapaGUI
{
    partial class PantallaRegistrarTorneo
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescripcionTorneo = new System.Windows.Forms.TextBox();
            this.txtNombreTorneo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTipoTorneo = new System.Windows.Forms.ComboBox();
            this.dateTimeFechaTorneo = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(358, 260);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(130, 23);
            this.btnAgregar.TabIndex = 29;
            this.btnAgregar.Text = "Agregar Participante";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(140, 260);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 28;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(356, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Tipo Torneo";
            // 
            // txtDescripcionTorneo
            // 
            this.txtDescripcionTorneo.Location = new System.Drawing.Point(116, 172);
            this.txtDescripcionTorneo.Name = "txtDescripcionTorneo";
            this.txtDescripcionTorneo.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcionTorneo.TabIndex = 24;
            // 
            // txtNombreTorneo
            // 
            this.txtNombreTorneo.Location = new System.Drawing.Point(116, 124);
            this.txtNombreTorneo.Name = "txtNombreTorneo";
            this.txtNombreTorneo.Size = new System.Drawing.Size(100, 20);
            this.txtNombreTorneo.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Fecha Inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Descripcion Torneo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nombre Torneo";
            // 
            // cboTipoTorneo
            // 
            this.cboTipoTorneo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoTorneo.FormattingEnabled = true;
            this.cboTipoTorneo.Location = new System.Drawing.Point(358, 180);
            this.cboTipoTorneo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTipoTorneo.Name = "cboTipoTorneo";
            this.cboTipoTorneo.Size = new System.Drawing.Size(92, 21);
            this.cboTipoTorneo.TabIndex = 30;
            // 
            // dateTimeFechaTorneo
            // 
            this.dateTimeFechaTorneo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaTorneo.Location = new System.Drawing.Point(358, 126);
            this.dateTimeFechaTorneo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimeFechaTorneo.Name = "dateTimeFechaTorneo";
            this.dateTimeFechaTorneo.Size = new System.Drawing.Size(92, 20);
            this.dateTimeFechaTorneo.TabIndex = 31;
            // 
            // PantallaRegistrarTorneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dateTimeFechaTorneo);
            this.Controls.Add(this.cboTipoTorneo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDescripcionTorneo);
            this.Controls.Add(this.txtNombreTorneo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PantallaRegistrarTorneo";
            this.Text = "PantallaRegistrarTorneo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PantallaRegistrarTorneo_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescripcionTorneo;
        private System.Windows.Forms.TextBox txtNombreTorneo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTipoTorneo;
        private System.Windows.Forms.DateTimePicker dateTimeFechaTorneo;
    }
}