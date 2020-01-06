namespace CapaGUI
{
    partial class PantallaAdministrarParticipante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaAdministrarParticipante));
            this.btnModificarParticipante = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnListarParticipante = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificarParticipante
            // 
            this.btnModificarParticipante.Location = new System.Drawing.Point(183, 260);
            this.btnModificarParticipante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificarParticipante.Name = "btnModificarParticipante";
            this.btnModificarParticipante.Size = new System.Drawing.Size(56, 19);
            this.btnModificarParticipante.TabIndex = 0;
            this.btnModificarParticipante.Text = "Modificar";
            this.btnModificarParticipante.UseVisualStyleBackColor = true;
            this.btnModificarParticipante.Click += new System.EventHandler(this.BtnModificarParticipante_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(250, 312);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(56, 19);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnListarParticipante
            // 
            this.btnListarParticipante.Location = new System.Drawing.Point(328, 260);
            this.btnListarParticipante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListarParticipante.Name = "btnListarParticipante";
            this.btnListarParticipante.Size = new System.Drawing.Size(56, 19);
            this.btnListarParticipante.TabIndex = 3;
            this.btnListarParticipante.Text = "Listar";
            this.btnListarParticipante.UseVisualStyleBackColor = true;
            this.btnListarParticipante.Click += new System.EventHandler(this.BtnListarParticipante_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(183, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 200);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // PantallaAdministrarParticipante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnListarParticipante);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificarParticipante);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PantallaAdministrarParticipante";
            this.Text = "PantallaAdministrarParticipante";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PantallaAdministrarParticipante_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModificarParticipante;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnListarParticipante;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}