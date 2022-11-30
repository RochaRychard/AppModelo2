namespace AppModelo.view.Windows.Cadastros
{
    partial class frmPainelDeFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPainelDeFuncionarios));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgPainelDeFuncionarios = new System.Windows.Forms.DataGridView();
            this.btnExcluirFuncionario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdFuncionario = new System.Windows.Forms.TextBox();
            this.btnAtualizarPainelFuncionario = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgPainelDeFuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 47);
            this.panel1.TabIndex = 0;
            // 
            // dgPainelDeFuncionarios
            // 
            this.dgPainelDeFuncionarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgPainelDeFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPainelDeFuncionarios.Location = new System.Drawing.Point(12, 119);
            this.dgPainelDeFuncionarios.Name = "dgPainelDeFuncionarios";
            this.dgPainelDeFuncionarios.Size = new System.Drawing.Size(776, 319);
            this.dgPainelDeFuncionarios.TabIndex = 1;
            // 
            // btnExcluirFuncionario
            // 
            this.btnExcluirFuncionario.BackColor = System.Drawing.Color.AliceBlue;
            this.btnExcluirFuncionario.Location = new System.Drawing.Point(238, 77);
            this.btnExcluirFuncionario.Name = "btnExcluirFuncionario";
            this.btnExcluirFuncionario.Size = new System.Drawing.Size(182, 23);
            this.btnExcluirFuncionario.TabIndex = 0;
            this.btnExcluirFuncionario.Text = "Excluir Funcionário\r\n";
            this.btnExcluirFuncionario.UseVisualStyleBackColor = false;
            this.btnExcluirFuncionario.Click += new System.EventHandler(this.btnExcluirFuncionario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id";
            // 
            // txtIdFuncionario
            // 
            this.txtIdFuncionario.Location = new System.Drawing.Point(15, 80);
            this.txtIdFuncionario.Name = "txtIdFuncionario";
            this.txtIdFuncionario.Size = new System.Drawing.Size(58, 20);
            this.txtIdFuncionario.TabIndex = 3;
            // 
            // btnAtualizarPainelFuncionario
            // 
            this.btnAtualizarPainelFuncionario.BackColor = System.Drawing.Color.AliceBlue;
            this.btnAtualizarPainelFuncionario.Location = new System.Drawing.Point(540, 77);
            this.btnAtualizarPainelFuncionario.Name = "btnAtualizarPainelFuncionario";
            this.btnAtualizarPainelFuncionario.Size = new System.Drawing.Size(182, 23);
            this.btnAtualizarPainelFuncionario.TabIndex = 4;
            this.btnAtualizarPainelFuncionario.Text = "Atualizar";
            this.btnAtualizarPainelFuncionario.UseVisualStyleBackColor = false;
            this.btnAtualizarPainelFuncionario.Click += new System.EventHandler(this.btnAtualizarPainelFuncionario_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmPainelDeFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAtualizarPainelFuncionario);
            this.Controls.Add(this.txtIdFuncionario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcluirFuncionario);
            this.Controls.Add(this.dgPainelDeFuncionarios);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPainelDeFuncionarios";
            this.Text = "frmPainelDeFuncionarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgPainelDeFuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgPainelDeFuncionarios;
        private System.Windows.Forms.Button btnExcluirFuncionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdFuncionario;
        private System.Windows.Forms.Button btnAtualizarPainelFuncionario;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}