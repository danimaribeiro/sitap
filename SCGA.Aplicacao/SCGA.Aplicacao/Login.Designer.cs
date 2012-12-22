namespace SCGA.Aplicacao
{
    partial class Login
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
            this.GrpLogin = new System.Windows.Forms.GroupBox();
            this.LnkEsqueciMinhaSenha = new System.Windows.Forms.LinkLabel();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnLogar = new System.Windows.Forms.Button();
            this.PcbImagem = new System.Windows.Forms.PictureBox();
            this.GrpLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpLogin
            // 
            this.GrpLogin.Controls.Add(this.LnkEsqueciMinhaSenha);
            this.GrpLogin.Controls.Add(this.BtnCancelar);
            this.GrpLogin.Controls.Add(this.TxtPassword);
            this.GrpLogin.Controls.Add(this.label2);
            this.GrpLogin.Controls.Add(this.BtnLogar);
            this.GrpLogin.Controls.Add(this.TxtUsername);
            this.GrpLogin.Controls.Add(this.label1);
            this.GrpLogin.Location = new System.Drawing.Point(147, 12);
            this.GrpLogin.Name = "GrpLogin";
            this.GrpLogin.Size = new System.Drawing.Size(285, 130);
            this.GrpLogin.TabIndex = 11;
            this.GrpLogin.TabStop = false;
            this.GrpLogin.Text = "Identificação ";
            // 
            // LnkEsqueciMinhaSenha
            // 
            this.LnkEsqueciMinhaSenha.AutoSize = true;
            this.LnkEsqueciMinhaSenha.Location = new System.Drawing.Point(162, 77);
            this.LnkEsqueciMinhaSenha.Name = "LnkEsqueciMinhaSenha";
            this.LnkEsqueciMinhaSenha.Size = new System.Drawing.Size(111, 13);
            this.LnkEsqueciMinhaSenha.TabIndex = 4;
            this.LnkEsqueciMinhaSenha.TabStop = true;
            this.LnkEsqueciMinhaSenha.Text = "Esqueci Minha Senha";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(66, 50);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(207, 20);
            this.TxtPassword.TabIndex = 1;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha :";
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(66, 22);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(207, 20);
            this.TxtUsername.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuário :";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = global::SCGA.Aplicacao.Properties.Resources.Cancel;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(198, 98);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 25);
            this.BtnCancelar.TabIndex = 3;
            this.BtnCancelar.Text = "    Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnLogar
            // 
            this.BtnLogar.Image = global::SCGA.Aplicacao.Properties.Resources.apply;
            this.BtnLogar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogar.Location = new System.Drawing.Point(102, 98);
            this.BtnLogar.Name = "BtnLogar";
            this.BtnLogar.Size = new System.Drawing.Size(75, 25);
            this.BtnLogar.TabIndex = 2;
            this.BtnLogar.Text = "OK";
            this.BtnLogar.UseVisualStyleBackColor = true;
            this.BtnLogar.Click += new System.EventHandler(this.BtnLogar_Click);
            // 
            // PcbImagem
            // 
            this.PcbImagem.Image = global::SCGA.Aplicacao.Properties.Resources.Login;
            this.PcbImagem.Location = new System.Drawing.Point(11, 12);
            this.PcbImagem.Name = "PcbImagem";
            this.PcbImagem.Size = new System.Drawing.Size(130, 130);
            this.PcbImagem.TabIndex = 9;
            this.PcbImagem.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 155);
            this.Controls.Add(this.GrpLogin);
            this.Controls.Add(this.PcbImagem);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCGA - Login";
            this.GrpLogin.ResumeLayout(false);
            this.GrpLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpLogin;
        private System.Windows.Forms.LinkLabel LnkEsqueciMinhaSenha;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnLogar;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PcbImagem;

    }
}

