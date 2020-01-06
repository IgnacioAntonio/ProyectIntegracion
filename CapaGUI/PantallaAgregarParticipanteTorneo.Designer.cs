namespace CapaGUI
{
    partial class PantallaAgregarParticipanteTorneo
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
            this.btnMenu = new System.Windows.Forms.Button();
            this.txtIdParticipante = new System.Windows.Forms.TextBox();
            this.txtIdTorneo = new System.Windows.Forms.TextBox();
            this.btnAgregarParticipante = new System.Windows.Forms.Button();
            this.btnListarParticipante = new System.Windows.Forms.Button();
            this.btnListarTorneo = new System.Windows.Forms.Button();
            this.dataGridParticipante = new System.Windows.Forms.DataGridView();
            this.dataGridTorneo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParticipante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTorneo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(614, 380);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(56, 19);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // txtIdParticipante
            // 
            this.txtIdParticipante.Location = new System.Drawing.Point(479, 28);
            this.txtIdParticipante.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdParticipante.Name = "txtIdParticipante";
            this.txtIdParticipante.Size = new System.Drawing.Size(76, 20);
            this.txtIdParticipante.TabIndex = 23;
            // 
            // txtIdTorneo
            // 
            this.txtIdTorneo.Location = new System.Drawing.Point(122, 28);
            this.txtIdTorneo.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdTorneo.Name = "txtIdTorneo";
            this.txtIdTorneo.Size = new System.Drawing.Size(76, 20);
            this.txtIdTorneo.TabIndex = 22;
            // 
            // btnAgregarParticipante
            // 
            this.btnAgregarParticipante.Location = new System.Drawing.Point(283, 319);
            this.btnAgregarParticipante.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarParticipante.Name = "btnAgregarParticipante";
            this.btnAgregarParticipante.Size = new System.Drawing.Size(128, 19);
            this.btnAgregarParticipante.TabIndex = 21;
            this.btnAgregarParticipante.Text = "AgregarParticipante";
            this.btnAgregarParticipante.UseVisualStyleBackColor = true;
            this.btnAgregarParticipante.Click += new System.EventHandler(this.btnAgregarParticipante_Click);
            // 
            // btnListarParticipante
            // 
            this.btnListarParticipante.Location = new System.Drawing.Point(489, 319);
            this.btnListarParticipante.Margin = new System.Windows.Forms.Padding(2);
            this.btnListarParticipante.Name = "btnListarParticipante";
            this.btnListarParticipante.Size = new System.Drawing.Size(56, 19);
            this.btnListarParticipante.TabIndex = 20;
            this.btnListarParticipante.Text = "Listar Participante";
            this.btnListarParticipante.UseVisualStyleBackColor = true;
            this.btnListarParticipante.Click += new System.EventHandler(this.btnListarParticipante_Click_1);
            // 
            // btnListarTorneo
            // 
            this.btnListarTorneo.Location = new System.Drawing.Point(132, 319);
            this.btnListarTorneo.Margin = new System.Windows.Forms.Padding(2);
            this.btnListarTorneo.Name = "btnListarTorneo";
            this.btnListarTorneo.Size = new System.Drawing.Size(56, 19);
            this.btnListarTorneo.TabIndex = 19;
            this.btnListarTorneo.Text = "Listar Torneos";
            this.btnListarTorneo.UseVisualStyleBackColor = true;
            this.btnListarTorneo.Click += new System.EventHandler(this.btnListarTorneo_Click);
            // 
            // dataGridParticipante
            // 
            this.dataGridParticipante.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridParticipante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridParticipante.Location = new System.Drawing.Point(374, 80);
            this.dataGridParticipante.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridParticipante.Name = "dataGridParticipante";
            this.dataGridParticipante.ReadOnly = true;
            this.dataGridParticipante.RowTemplate.Height = 24;
            this.dataGridParticipante.Size = new System.Drawing.Size(274, 199);
            this.dataGridParticipante.TabIndex = 18;
            this.dataGridParticipante.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridParticipante_CellContentClick);
            this.dataGridParticipante.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridParticipante_CellMouseClick);
            // 
            // dataGridTorneo
            // 
            this.dataGridTorneo.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridTorneo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTorneo.Location = new System.Drawing.Point(39, 80);
            this.dataGridTorneo.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridTorneo.Name = "dataGridTorneo";
            this.dataGridTorneo.ReadOnly = true;
            this.dataGridTorneo.RowTemplate.Height = 24;
            this.dataGridTorneo.Size = new System.Drawing.Size(280, 199);
            this.dataGridTorneo.TabIndex = 17;
            this.dataGridTorneo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTorneo_CellContentClick);
            this.dataGridTorneo.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridTorneo_CellMouseClick);
            // 
            // PantallaAgregarParticipanteTorneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(703, 421);
            this.Controls.Add(this.txtIdParticipante);
            this.Controls.Add(this.txtIdTorneo);
            this.Controls.Add(this.btnAgregarParticipante);
            this.Controls.Add(this.btnListarParticipante);
            this.Controls.Add(this.btnListarTorneo);
            this.Controls.Add(this.dataGridParticipante);
            this.Controls.Add(this.dataGridTorneo);
            this.Controls.Add(this.btnMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PantallaAgregarParticipanteTorneo";
            this.Text = "PantallaAgregarParticipanteTorneo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParticipante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTorneo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.TextBox txtIdParticipante;
        private System.Windows.Forms.TextBox txtIdTorneo;
        private System.Windows.Forms.Button btnAgregarParticipante;
        private System.Windows.Forms.Button btnListarParticipante;
        private System.Windows.Forms.Button btnListarTorneo;
        private System.Windows.Forms.DataGridView dataGridParticipante;
        private System.Windows.Forms.DataGridView dataGridTorneo;
    }
}