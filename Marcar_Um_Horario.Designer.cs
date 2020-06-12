namespace Fast9Pneus
{
    partial class Tela_de_opcoes
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
            this.Oficinas_credenciadas = new System.Windows.Forms.ComboBox();
            this.Horarios_disponiveis = new System.Windows.Forms.ComboBox();
            this.bnt_marcar = new System.Windows.Forms.Button();
            this.Oficina = new System.Windows.Forms.Label();
            this.Horarios = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Oficinas_credenciadas
            // 
            this.Oficinas_credenciadas.FormattingEnabled = true;
            this.Oficinas_credenciadas.Location = new System.Drawing.Point(31, 29);
            this.Oficinas_credenciadas.Name = "Oficinas_credenciadas";
            this.Oficinas_credenciadas.Size = new System.Drawing.Size(260, 21);
            this.Oficinas_credenciadas.TabIndex = 0;
            // 
            // Horarios_disponiveis
            // 
            this.Horarios_disponiveis.FormattingEnabled = true;
            this.Horarios_disponiveis.Location = new System.Drawing.Point(31, 108);
            this.Horarios_disponiveis.Name = "Horarios_disponiveis";
            this.Horarios_disponiveis.Size = new System.Drawing.Size(260, 21);
            this.Horarios_disponiveis.TabIndex = 1;
            // 
            // bnt_marcar
            // 
            this.bnt_marcar.Location = new System.Drawing.Point(89, 145);
            this.bnt_marcar.Name = "bnt_marcar";
            this.bnt_marcar.Size = new System.Drawing.Size(165, 50);
            this.bnt_marcar.TabIndex = 2;
            this.bnt_marcar.Text = "Marcar";
            this.bnt_marcar.UseVisualStyleBackColor = true;
            // 
            // Oficina
            // 
            this.Oficina.AutoSize = true;
            this.Oficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Oficina.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Oficina.Location = new System.Drawing.Point(51, 9);
            this.Oficina.Name = "Oficina";
            this.Oficina.Size = new System.Drawing.Size(223, 17);
            this.Oficina.TabIndex = 3;
            this.Oficina.Text = "Escolha Uma Oficina Credenciada";
            // 
            // Horarios
            // 
            this.Horarios.AutoSize = true;
            this.Horarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Horarios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Horarios.Location = new System.Drawing.Point(51, 76);
            this.Horarios.Name = "Horarios";
            this.Horarios.Size = new System.Drawing.Size(203, 17);
            this.Horarios.TabIndex = 4;
            this.Horarios.Text = "Escolha Um Horario Disponivel";
            // 
            // Tela_de_opcoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 261);
            this.Controls.Add(this.Horarios);
            this.Controls.Add(this.Oficina);
            this.Controls.Add(this.bnt_marcar);
            this.Controls.Add(this.Horarios_disponiveis);
            this.Controls.Add(this.Oficinas_credenciadas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tela_de_opcoes";
            this.Text = "Tela_de_opcoes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Oficinas_credenciadas;
        private System.Windows.Forms.ComboBox Horarios_disponiveis;
        private System.Windows.Forms.Button bnt_marcar;
        private System.Windows.Forms.Label Oficina;
        private System.Windows.Forms.Label Horarios;
    }
}