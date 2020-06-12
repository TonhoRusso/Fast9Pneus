namespace Fast9Pneus
{
    partial class Horarios
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
            this.cbOficina = new System.Windows.Forms.ComboBox();
            this.lblEscolhaUmaOficina = new System.Windows.Forms.Label();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.lblEscolhaUmHorario = new System.Windows.Forms.Label();
            this.cbhorario = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbOficina
            // 
            this.cbOficina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOficina.FormattingEnabled = true;
            this.cbOficina.Location = new System.Drawing.Point(12, 56);
            this.cbOficina.Name = "cbOficina";
            this.cbOficina.Size = new System.Drawing.Size(487, 21);
            this.cbOficina.TabIndex = 0;
            // 
            // lblEscolhaUmaOficina
            // 
            this.lblEscolhaUmaOficina.AutoSize = true;
            this.lblEscolhaUmaOficina.Location = new System.Drawing.Point(12, 40);
            this.lblEscolhaUmaOficina.Name = "lblEscolhaUmaOficina";
            this.lblEscolhaUmaOficina.Size = new System.Drawing.Size(106, 13);
            this.lblEscolhaUmaOficina.TabIndex = 1;
            this.lblEscolhaUmaOficina.Text = "Escolha Uma Oficina";
            // 
            // btnAgendar
            // 
            this.btnAgendar.Location = new System.Drawing.Point(201, 196);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(75, 23);
            this.btnAgendar.TabIndex = 2;
            this.btnAgendar.Text = "Agendar";
            this.btnAgendar.UseVisualStyleBackColor = true;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // lblEscolhaUmHorario
            // 
            this.lblEscolhaUmHorario.AutoSize = true;
            this.lblEscolhaUmHorario.Location = new System.Drawing.Point(12, 95);
            this.lblEscolhaUmHorario.Name = "lblEscolhaUmHorario";
            this.lblEscolhaUmHorario.Size = new System.Drawing.Size(101, 13);
            this.lblEscolhaUmHorario.TabIndex = 4;
            this.lblEscolhaUmHorario.Text = "Escolha Um Horario";
            // 
            // cbhorario
            // 
            this.cbhorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbhorario.FormattingEnabled = true;
            this.cbhorario.Location = new System.Drawing.Point(12, 111);
            this.cbhorario.Name = "cbhorario";
            this.cbhorario.Size = new System.Drawing.Size(487, 21);
            this.cbhorario.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(104, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(298, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar Oficinas e Horarios Disponiveis";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btn_Buscar);
            // 
            // Horarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 240);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblEscolhaUmHorario);
            this.Controls.Add(this.cbhorario);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.lblEscolhaUmaOficina);
            this.Controls.Add(this.cbOficina);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Horarios";
            this.Text = "Horarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbOficina;
        private System.Windows.Forms.Label lblEscolhaUmaOficina;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.Label lblEscolhaUmHorario;
        private System.Windows.Forms.ComboBox cbhorario;
        private System.Windows.Forms.Button btnBuscar;
    }
}