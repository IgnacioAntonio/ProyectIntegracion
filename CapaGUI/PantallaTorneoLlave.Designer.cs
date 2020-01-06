namespace CapaGUI
{
    partial class PantallaTorneoLlave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaTorneoLlave));
            this.Llave4 = new System.Windows.Forms.Button();
            this.Llave8 = new System.Windows.Forms.Button();
            this.SalirL = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Llave4
            // 
            this.Llave4.Location = new System.Drawing.Point(180, 262);
            this.Llave4.Margin = new System.Windows.Forms.Padding(2);
            this.Llave4.Name = "Llave4";
            this.Llave4.Size = new System.Drawing.Size(56, 19);
            this.Llave4.TabIndex = 0;
            this.Llave4.Text = "Listar ";
            this.Llave4.UseVisualStyleBackColor = true;
            this.Llave4.Click += new System.EventHandler(this.Llave4_Click);
            // 
            // Llave8
            // 
            this.Llave8.Location = new System.Drawing.Point(351, 262);
            this.Llave8.Margin = new System.Windows.Forms.Padding(2);
            this.Llave8.Name = "Llave8";
            this.Llave8.Size = new System.Drawing.Size(56, 19);
            this.Llave8.TabIndex = 1;
            this.Llave8.Text = "Modificar";
            this.Llave8.UseVisualStyleBackColor = true;
            this.Llave8.Click += new System.EventHandler(this.Llave8_Click);
            // 
            // SalirL
            // 
            this.SalirL.Location = new System.Drawing.Point(267, 302);
            this.SalirL.Margin = new System.Windows.Forms.Padding(2);
            this.SalirL.Name = "SalirL";
            this.SalirL.Size = new System.Drawing.Size(56, 19);
            this.SalirL.TabIndex = 3;
            this.SalirL.Text = "Salir";
            this.SalirL.UseVisualStyleBackColor = true;
            this.SalirL.Click += new System.EventHandler(this.SalirL_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(180, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 227);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // PantallaTorneoLlave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SalirL);
            this.Controls.Add(this.Llave8);
            this.Controls.Add(this.Llave4);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PantallaTorneoLlave";
            this.Text = " ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PantallaTorneoLlave_FormClosed);
            this.Load += new System.EventHandler(this.PantallaTorneoLlave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Llave4;
        private System.Windows.Forms.Button Llave8;
        private System.Windows.Forms.Button SalirL;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}