using AppModelo.Controller.Seguranca;
using AppModelo.Model.Domain.Validator;
using AppModelo.view.Windows.Cadastros;
using System.Windows.Forms;

namespace AppModelo.view.Windows
{
    public partial class frmLogin : Form
    {
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

        
     
    }   
}

