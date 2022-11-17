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
            btnSalvarDescricaoNaturalidade.Enabled = false;
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
                
                var salvou = _naturalidadeController.Cadastrar(txtDescricaoNaturalidade.Text.ToUpper(), chkStatus.Checked);
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
           
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            var numero = int.Parse(txtIdNaturalidade.Text);
            var atualizou = _naturalidadeController.Atualizar(txtDescricaoNaturalidade.Text.ToUpper(), numero);
            if (atualizou)
            {
                MessageBox.Show("Naturalidade atualizada com sucesso!");
                txtDescricaoNaturalidade.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Houve um erro ao atualizar no banco de dados!");
            }

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            var numero = int.Parse(txtIdNaturalidade.Text);
            var removeu = _naturalidadeController.Remover(numero);
            if (removeu)
            {
                MessageBox.Show("Naturalidade removidada com sucesso!");
                txtDescricaoNaturalidade.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Houve um erro ao remover do banco de dados!");
            }
        }

        private void txtDescricaoNaturalidade_TextChanged(object sender, EventArgs e)
        {
            if (txtDescricaoNaturalidade.Text != string.Empty)
            {
                btnSalvarDescricaoNaturalidade.Enabled = true;
            }
            else
            {
                errorProvider1.SetError(txtDescricaoNaturalidade, "Preencher o campo Descrição!");
                txtDescricaoNaturalidade.Focus();
                btnSalvarDescricaoNaturalidade.Enabled = false;
            }
        }
    }
    
}

