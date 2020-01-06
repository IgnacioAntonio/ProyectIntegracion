namespace CapaGUI
{
    partial class PantallaListarParticipantes
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
            this.dataGridParticipante = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParticipante)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridParticipante
            // 
            this.dataGridParticipante.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridParticipante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridParticipante.Location = new System.Drawing.Point(112, 24);
            this.dataGridParticipante.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridParticipante.Name = "dataGridParticipante";
            this.dataGridParticipante.ReadOnly = true;
            this.dataGridParticipante.RowTemplate.Height = 24;
            this.dataGridParticipante.Size = new System.Drawing.Size(328, 211);
            this.dataGridParticipante.TabIndex = 0;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(147, 266);
            this.btnListar.Margin = new System.Windows.Forms.Padding(2);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(56, 19);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(357, 266);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(56, 19);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar Participante";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // PantallaListarParticipantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dataGridParticipante);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PantallaListarParticipantes";
            this.Text = "PantallaListarParticipantes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PantallaListarParticipantes_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParticipante)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridParticipante;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnEliminar;
    }
}