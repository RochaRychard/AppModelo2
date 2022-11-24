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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgPainelDeFuncionarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgPainelDeFuncionarios)).BeginInit();
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
            this.dgPainelDeFuncionarios.Location = new System.Drawing.Point(12, 53);
            this.dgPainelDeFuncionarios.Name = "dgPainelDeFuncionarios";
            this.dgPainelDeFuncionarios.Size = new System.Drawing.Size(776, 360);
            this.dgPainelDeFuncionarios.TabIndex = 1;
            // 
            // frmPainelDeFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgPainelDeFuncionarios);
            this.Controls.Add(this.panel1);
            this.Name = "frmPainelDeFuncionarios";
            this.Text = "frmPainelDeFuncionarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgPainelDeFuncionarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgPainelDeFuncionarios;
    }
}