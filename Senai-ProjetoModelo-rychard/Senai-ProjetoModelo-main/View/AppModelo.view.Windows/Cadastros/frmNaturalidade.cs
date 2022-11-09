using AppModelo.Controller.Cadastros;
using System;
using System.Windows.Forms;

namespace AppModelo.view.Windows.Cadastros
{
    public partial class frmNaturalidade : Form
    {

        private NaturalidadeController _naturalidadeController = new NaturalidadeController();

        public frmNaturalidade()
        {
            InitializeComponent();
            var listaDeNaturalidade = _naturalidadeController.ObterTodasNaturalidades();
            dgNaturalidade.DataSource = listaDeNaturalidade;
        }

        private void btnSalvarDescricaoNaturalidade_Click(object sender, EventArgs e)
        {
           

            var temNumero = Helpers.Componentes.ExisteNumeroNoTexto(txtDescricaoNaturalidade.Text);
            if (temNumero)
            {
                errorProvider1.SetError(txtDescricaoNaturalidade, "Naturalidade não pode conter números!");
                txtDescricaoNaturalidade.Focus();
                return;
            }
            else
            {
                
                var salvou = _naturalidadeController.Cadastrar(txtDescricaoNaturalidade.Text, chkStatus.Checked);
                if (salvou)
                {
                    MessageBox.Show("Naturalidade incluída com sucesso!");
                    txtDescricaoNaturalidade.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Houve um erro ao salvar no banco de dados!");
                }
                

            }
            var controler = new NaturalidadeController();
            var descricaoMaiuscula = txtDescricaoNaturalidade.Text.ToUpper();

            var resposta = controler.Cadastrar(descricaoMaiuscula, chkStatus.Checked);
        }
    }
}

