using System;
using System.Windows.Forms;

namespace AppModelo.view.Windows.Cadastros
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void naturalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmNaturalidade();
            form.Show();
        }

        private void nacionalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmNacionalidades();
            form.Show();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmCadastroFuncionario();
            form.Show();
        }

        private void painelDeFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmPainelDeFuncionarios();
            form.Show();
        }
    }
}
