namespace AppModelo.view.Windows
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblEsqueciMinhaSenha = new System.Windows.Forms.Label();
            this.lblSuporteEContato = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCadastrarLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(15, 78);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(251, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(15, 144);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(251, 20);
            this.txtSenha.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(15, 266);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(251, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblEsqueciMinhaSenha
            // 
            this.lblEsqueciMinhaSenha.AutoSize = true;
            this.lblEsqueciMinhaSenha.Location = new System.Drawing.Point(158, 167);
            this.lblEsqueciMinhaSenha.Name = "lblEsqueciMinhaSenha";
            this.lblEsqueciMinhaSenha.Size = new System.Drawing.Size(108, 13);
            this.lblEsqueciMinhaSenha.TabIndex = 5;
            this.lblEsqueciMinhaSenha.Text = "Esqueci minha senha";
            this.lblEsqueciMinhaSenha.Click += new System.EventHandler(this.lblEsqueciMinhaSenha_Click);
            // 
            // lblSuporteEContato
            // 
            this.lblSuporteEContato.AutoSize = true;
            this.lblSuporteEContato.Location = new System.Drawing.Point(95, 301);
            this.lblSuporteEContato.Name = "lblSuporteEContato";
            this.lblSuporteEContato.Size = new System.Drawing.Size(93, 13);
            this.lblSuporteEContato.TabIndex = 6;
            this.lblSuporteEContato.Text = "Suporte e Contato";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 47);
            this.panel1.TabIndex = 7;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnCadastrarLogin
            // 
            this.btnCadastrarLogin.Location = new System.Drawing.Point(15, 211);
            this.btnCadastrarLogin.Name = "btnCadastrarLogin";
            this.btnCadastrarLogin.Size = new System.Drawing.Size(251, 23);
            this.btnCadastrarLogin.TabIndex = 8;
            this.btnCadastrarLogin.Text = "Cadastrar";
            this.btnCadastrarLogin.UseVisualStyleBackColor = true;
            this.btnCadastrarLogin.Click += new System.EventHandler(this.btnCadastrarLogin_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 323);
            this.Controls.Add(this.btnCadastrarLogin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSuporteEContato);
            this.Controls.Add(this.lblEsqueciMinhaSenha);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblEsqueciMinhaSenha;
        private System.Windows.Forms.Label lblSuporteEContato;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnCadastrarLogin;
    }
}