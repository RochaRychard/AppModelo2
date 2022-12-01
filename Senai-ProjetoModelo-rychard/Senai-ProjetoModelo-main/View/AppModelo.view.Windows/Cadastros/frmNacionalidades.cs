using AppModelo.Controller.Cadastros;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace AppModelo.view.Windows.Cadastros
{
    public partial class frmNacionalidades : Form
    {
        private NacionalidadeController _nacionalidadeController = new NacionalidadeController();

        public frmNacionalidades()
        {
            InitializeComponent();
            btnSalvar.Enabled = false;
            var listaDeNacionalidades = _nacionalidadeController.ObterTodasNacionalidades();
            dgNacionalidades.DataSource = listaDeNacionalidades;
        }

        /// <summary>
        /// EVENTO QUE SALVA A NACIONALIDADE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                
                var salvou = _nacionalidadeController.Cadastrar(txtDescricaoNacionalidade.Text.ToUpper());
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

        /// <summary>
        /// EVENTO QUE ATUALIZA NACIONALIDADE DO FORMULÁRIO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAtualizar_Click(object sender, EventArgs e)
        {

            if (txtDescricaoNacionalidade.Text == string.Empty && txtId.Text != string.Empty)
            {
                errorProvider1.SetError(txtDescricaoNacionalidade, "Preencher o campo descrição!");
                return;
            }


            if (txtDescricaoNacionalidade.Text == string.Empty &&
                txtId.Text == string.Empty)
            {

                var listaDeNacionalidades = _nacionalidadeController.ObterTodasNacionalidades();
                dgNacionalidades.DataSource = listaDeNacionalidades;
            }
            else
            {
                int numero = int.Parse(txtId.Text);
                var listaAtualizada = _nacionalidadeController.ObterTodasNacionalidades();
                var atualizou = _nacionalidadeController.Atualizar(txtDescricaoNacionalidade.Text.ToUpper(), numero);
                if (atualizou)
                {

                    MessageBox.Show("Nacionalidade atualizada com sucesso!");
                    txtDescricaoNacionalidade.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Houve um erro ao atualizar no banco de dados!");
                }

                dgNacionalidades.DataSource = listaAtualizada;
            }
        }

        /// <summary>
        /// EVENTO QUE REMOVE A NACIONALIDADE DO FORMULÁRIO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemover_Click(object sender, EventArgs e)
        {
            var numero = int.Parse(txtId.Text);
            var removeu = _nacionalidadeController.Remover(numero);
            if (removeu)
            {
                MessageBox.Show("Nacionalidade removidada com sucesso!");
                txtDescricaoNacionalidade.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Houve um erro ao remover do banco de dados!");
            }
        }

        private void txtDescricaoNacionalidade_TextChanged(object sender, EventArgs e)
        {
            if (txtDescricaoNacionalidade.Text != string.Empty)
            {
                btnSalvar.Enabled = true;
            }
            else
            {
                errorProvider1.SetError(txtDescricaoNacionalidade, "Preencher o campo Descrição!");
                txtDescricaoNacionalidade.Focus();
                btnSalvar.Enabled = false;
            }
        }
    }
    
}
