using AppModelo.Controller.Cadastros;
using System;
using System.Windows.Forms;

namespace AppModelo.view.Windows.Cadastros
{
    public partial class frmNacionalidades : Form
    {
        private NacionalidadeController _nacionalidadeController = new NacionalidadeController();

        public frmNacionalidades()
        {
            InitializeComponent();
            var listaDeNacionalidades = _nacionalidadeController.ObterTodasNacionalidades();
            gvNacionalidades.DataSource = listaDeNacionalidades;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            
            var temNumero = Helpers.Componentes.ExisteNumeroNoTexto(txtDescricaoNacionalidade.Text);
            if (temNumero)
            {
                errorProvider1.SetError(txtDescricaoNacionalidade, "Nacionalidade não pode conter números!");
                txtDescricaoNacionalidade.Focus();
                return;
            }
            else
            { 

                var salvou = _nacionalidadeController.Cadastrar(txtDescricaoNacionalidade.Text);
                if (salvou)
                {
                    MessageBox.Show("Nacionalidade incluída com sucesso!");
                    txtDescricaoNacionalidade.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Houve um erro ao salvar no banco de dados!");
                }

                var descricaoMaiuscula = txtDescricaoNacionalidade.Text.ToUpper();
                var controler = new NaturalidadeController();
                var resposta = controler.Cadastrar(descricaoMaiuscula, chkStatus.Checked);

                
            }
            
        }
    }
}
