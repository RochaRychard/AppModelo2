namespace AppModelo.view.Windows.Cadastros
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nacionalidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.naturalidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.painelDeFuncionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionáriosToolStripMenuItem,
            this.nacionalidadeToolStripMenuItem,
            this.naturalidadeToolStripMenuItem,
            this.painelDeFuncionáriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(661, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.funcionáriosToolStripMenuItem.Text = "Cadastrar Funcionário";
            this.funcionáriosToolStripMenuItem.Click += new System.EventHandler(this.funcionáriosToolStripMenuItem_Click);
            // 
            // nacionalidadeToolStripMenuItem
            // 
            this.nacionalidadeToolStripMenuItem.Name = "nacionalidadeToolStripMenuItem";
            this.nacionalidadeToolStripMenuItem.Size = new System.Drawing.Size(153, 20);
            this.nacionalidadeToolStripMenuItem.Text = "Cadastrar Nacionalidades";
            this.nacionalidadeToolStripMenuItem.Click += new System.EventHandler(this.nacionalidadeToolStripMenuItem_Click);
            // 
            // naturalidadeToolStripMenuItem
            // 
            this.naturalidadeToolStripMenuItem.Name = "naturalidadeToolStripMenuItem";
            this.naturalidadeToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.naturalidadeToolStripMenuItem.Text = "Cadastrar Naturalidades";
            this.naturalidadeToolStripMenuItem.Click += new System.EventHandler(this.naturalidadeToolStripMenuItem_Click);
            // 
            // painelDeFuncionáriosToolStripMenuItem
            // 
            this.painelDeFuncionáriosToolStripMenuItem.Name = "painelDeFuncionáriosToolStripMenuItem";
            this.painelDeFuncionáriosToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.painelDeFuncionáriosToolStripMenuItem.Text = "Painel de Funcionários";
            this.painelDeFuncionáriosToolStripMenuItem.Click += new System.EventHandler(this.painelDeFuncionáriosToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 28);
            this.panel1.TabIndex = 2;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(661, 354);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nacionalidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem naturalidadeToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem painelDeFuncionáriosToolStripMenuItem;
    }
}