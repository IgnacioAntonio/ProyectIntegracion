namespace CapaGUI
{
    partial class PantallaModificarTorneo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeTorneo = new System.Windows.Forms.DateTimePicker();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTipoTorneo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreTorneo = new System.Windows.Forms.TextBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.cboId = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Torneo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha Torneo";
            // 
            // dateTimeTorneo
            // 
            this.dateTimeTorneo.Location = new System.Drawing.Point(300, 179);
            this.dateTimeTorneo.Name = "dateTimeTorneo";
            this.dateTimeTorneo.Size = new System.Drawing.Size(200, 20);
            this.dateTimeTorneo.TabIndex = 5;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(303, 280);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 211);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo Torneo";
            // 
            // cboTipoTorneo
            // 
            this.cboTipoTorneo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoTorneo.FormattingEnabled = true;
            this.cboTipoTorneo.Location = new System.Drawing.Point(300, 228);
            this.cboTipoTorneo.Margin = new System.Windows.Forms.Padding(2);
            this.cboTipoTorneo.Name = "cboTipoTorneo";
            this.cboTipoTorneo.Size = new System.Drawing.Size(92, 21);
            this.cboTipoTorneo.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nombre Torneo";
            // 
            // txtNombreTorneo
            // 
            this.txtNombreTorneo.Location = new System.Drawing.Point(299, 132);
            this.txtNombreTorneo.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreTorneo.Name = "txtNombreTorneo";
            this.txtNombreTorneo.Size = new System.Drawing.Size(149, 20);
            this.txtNombreTorneo.TabIndex = 12;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(636, 366);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(56, 19);
            this.btnMenu.TabIndex = 13;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // cboId
            // 
            this.cboId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboId.FormattingEnabled = true;
            this.cboId.Location = new System.Drawing.Point(29, 36);
            this.cboId.Margin = new System.Windows.Forms.Padding(2);
            this.cboId.Name = "cboId";
            this.cboId.Size = new System.Drawing.Size(83, 21);
            this.cboId.TabIndex = 14;
            this.cboId.SelectedIndexChanged += new System.EventHandler(this.cboId_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Id Torneo";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(299, 79);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 16;
            // 
            // PantallaModificarTorneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboId);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.txtNombreTorneo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboTipoTorneo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dateTimeTorneo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "PantallaModificarTorneo";
            this.Text = "PantallaModificarTorneo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PantallaModificarTorneo_FormClosed);
            this.Load += new System.EventHandler(this.PantallaModificarTorneo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeTorneo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTipoTorneo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreTorneo;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.ComboBox cboId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
    }
}