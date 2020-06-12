namespace Fast9Pneus
{
    partial class Fast9Pneus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fast9Pneus));
            this.Usuario = new System.Windows.Forms.Label();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.Senha = new System.Windows.Forms.Label();
            this.btn_logar = new System.Windows.Forms.Button();
            this.Apresentacao = new System.Windows.Forms.Label();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.Redefenir_senha = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Usuario
            // 
            resources.ApplyResources(this.Usuario, "Usuario");
            this.Usuario.Name = "Usuario";
            // 
            // txt_senha
            // 
            resources.ApplyResources(this.txt_senha, "txt_senha");
            this.txt_senha.Name = "txt_senha";
            // 
            // txt_usuario
            // 
            resources.ApplyResources(this.txt_usuario, "txt_usuario");
            this.txt_usuario.Name = "txt_usuario";
            // 
            // Senha
            // 
            resources.ApplyResources(this.Senha, "Senha");
            this.Senha.Name = "Senha";
            // 
            // btn_logar
            // 
            resources.ApplyResources(this.btn_logar, "btn_logar");
            this.btn_logar.Name = "btn_logar";
            this.btn_logar.UseVisualStyleBackColor = true;
            this.btn_logar.Click += new System.EventHandler(this.btn_logar_Click);
            // 
            // Apresentacao
            // 
            resources.ApplyResources(this.Apresentacao, "Apresentacao");
            this.Apresentacao.Name = "Apresentacao";
            // 
            // btn_registrar
            // 
            resources.ApplyResources(this.btn_registrar, "btn_registrar");
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            // 
            // Redefenir_senha
            // 
            resources.ApplyResources(this.Redefenir_senha, "Redefenir_senha");
            this.Redefenir_senha.Name = "Redefenir_senha";
            this.Redefenir_senha.TabStop = true;
            // 
            // Fast9Pneus
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Redefenir_senha);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.Apresentacao);
            this.Controls.Add(this.btn_logar);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.Usuario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Fast9Pneus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.Button btn_logar;
        private System.Windows.Forms.Label Apresentacao;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.LinkLabel Redefenir_senha;
    }
}

