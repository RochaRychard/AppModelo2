using AppModelo.Controller.Cadastros;
using AppModelo.Controller.Seguranca;
using AppModelo.Model.Domain.Validator;
using AppModelo.view.Windows.Cadastros;
using System.Windows.Forms;

namespace AppModelo.view.Windows
{
    public partial class frmLogin : Form
    {
        private UsuarioController _UsuarioController = new UsuarioController();
        public frmLogin()
        {
            InitializeComponent();
            txtEmail.Text = "admin@admin.com";
            txtSenha.Text = "0000";
        }

        private void btnEntrar_Click(object sender, System.EventArgs e)
        { 
            var email = txtEmail.Text;
            var emailEhValido = Validadores.EmailEValido(email);

            if (emailEhValido is false)
            {
                errorProvider1.SetError(txtEmail, "Email Inválido!");
                txtEmail.Focus();
                return;
            }
            errorProvider1.Clear();

            var controller = new UsuarioController();
            var usuarioEncontrado = controller.EfetuarLogin(txtEmail.Text, txtSenha.Text);
            if (usuarioEncontrado)
            {
                var form = new frmPrincipal();
                form.Show();
                //form.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha não encontrado!");
            }
        }

        private void lblEsqueciMinhaSenha_Click(object sender, System.EventArgs e)
        {
            var form = new frmRecuperarSenha();
            form.ShowDialog();
        }

        private void btnCadastrarLogin_Click(object sender, System.EventArgs e)
        {

            var temNumero = Helpers.Componentes.ExisteNumeroNoTexto(txtEmail.Text);
            if (temNumero)
            {
                errorProvider1.SetError(txtEmail, "Email Inválido!");
                txtEmail.Focus();
                return;
            }
            else
            {

                var salvou = _UsuarioController.CadastrarLogin(txtEmail.Text, txtSenha.Text);
                if (salvou)
                {
                    MessageBox.Show("Cadastro incluído com sucesso!");
                    txtEmail.Text = string.Empty;
                    txtSenha.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Houve um erro ao salvar no banco de dados!");
                }


            }

        }

    }
}   


