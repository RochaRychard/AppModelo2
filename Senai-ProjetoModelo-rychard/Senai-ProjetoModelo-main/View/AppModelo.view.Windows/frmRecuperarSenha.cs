using AppModelo.Controller.Seguranca;
using AppModelo.Model.Domain.Validator;
using System.Windows.Forms;

namespace AppModelo.view.Windows
{
    public partial class frmRecuperarSenha : Form
    {
        public frmRecuperarSenha()
        {
            InitializeComponent();
        }

        private void btnRecuperarAcesso_Click(object sender, System.EventArgs e)
        {
            
            var email = txtRecuperarEmail.Text;
            var emailEhValido = Validadores.EmailEValido(email);

            if (emailEhValido is false)
            {
                errorProvider1.SetError(txtRecuperarEmail, "Email Inválido!");
                txtRecuperarEmail.Focus();
                return;
            }
            errorProvider1.Clear();

            var controller = new UsuarioController();
            var resultado = controller.RecuperarSenha(txtRecuperarEmail.Text);
            MessageBox.Show(resultado);
            
        }
    }
}

