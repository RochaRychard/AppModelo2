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

        /// <summary>
        /// EVENTO DE MUDANÇA DE TELA PARA O FORMULÁRIO DE CADASTRO DE NATURALIDADE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void naturalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmNaturalidade();
            form.MdiParent = this;
            form.Show();
        }

        /// <summary>
        /// EVENTO DE MUDANÇA DE TELA PARA O FORMULÁRIO DE CADASTRO DE NACIONALIDADE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nacionalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmNacionalidades();
            form.MdiParent = this;
            form.Show();
        }

        /// <summary>
        /// EVENTO DE MUDANÇA DE TELA PARA O FORMULÁRIO DE CADASTRO DE FUNCIONÁRIOS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmCadastroFuncionario();
            form.MdiParent = this;
            form.Show();
        }

        /// <summary>
        /// EVENTO DE MUDANÇA DE TELA PARA O PAINEL DE FUNCIONÁRIOS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void painelDeFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmPainelDeFuncionarios();
            form.MdiParent = this;
            form.Show();
        }
    }
}
