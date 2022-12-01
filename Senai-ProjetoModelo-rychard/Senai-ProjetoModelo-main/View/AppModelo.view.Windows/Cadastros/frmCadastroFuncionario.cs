using AppModelo.Controller.Cadastros;
using AppModelo.Controller.External;
using AppModelo.Model.Domain.Validator;
using AppModelo.view.Windows.Helpers;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace AppModelo.view.Windows.Cadastros
{
    public partial class frmCadastroFuncionario : Form
    {
        private FuncionarioController _funcionarioController = new FuncionarioController();
        private NacionalidadeController _nacionalidadeController = new NacionalidadeController();
        private NaturalidadeController _naturalidadeController = new NaturalidadeController();
        public frmCadastroFuncionario()
        {
            InitializeComponent();
            Componentes.FormatarCamposObrigatorios(this);
            cmbNacionalidade.DataSource = _nacionalidadeController.ObterTodasNacionalidades();
            cmbNacionalidade.DisplayMember = "Descricao";
            cmbNacionalidade.ValueMember = "id";

            cmbNaturalidade.DataSource = _naturalidadeController.ObterTodasNaturalidades();
            cmbNaturalidade.DisplayMember = "Descricao";
            cmbNaturalidade.ValueMember = "id";

            btnCadastrarFuncionario.Enabled = false;

        }

        /// <summary>
        /// Evento para pesquisa de cep
        /// </summary>
        /// <param object="sender"></param>
        /// <param EventArgs="e"></param>
        private void btnPesquisarCep_Click(object sender, EventArgs e)
        {
            //CRIA A INSTÂNCIA DO CONTROLADOR
            var CepController = new ViaCepController();

            //RECEBE OS DADOS DO MÉTODO PARA OBTER O ENDEREÇO
            var endereco = CepController.Obter(txtEnderecoCep.Text);

            txtEnderecoBairro.Text = endereco.Bairro;
            txtEnderecoLogradouro.Text = endereco.Logradouro;
            txtEnderecoMunicipio.Text = endereco.Localidade;
            txtEnderecoUf.Text = endereco.Uf;
        }
        /// <summary>
        /// VALIDAÇÃO DE ERRO NO CAMPO DE NOME
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            //VERIFICA SE A QUANTIDADE DE LETRAS ESTÁ CORRETA
            if (txtNome.Text.Length < 6)
            {
                errorProvider.SetError(txtNome, "Digite seu nome completo!");
                return;
            }

            //VERIFICA SE DIGITOU ALGUM NÚMERO NO LUGAR DE LETRAS
            foreach (var letra in txtNome.Text)
            {
                if (char.IsNumber(letra))
                {
                    errorProvider.SetError(txtNome, "Seu nome parece errado!");
                    return;
                }
            }
            errorProvider.Clear();
        }

        /// <summary>
        /// VALIDAÇÃO DE ERRO NO CAMPO DE CPF
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCpf_Validating(object sender, CancelEventArgs e)
        {
            var cpf = txtCpf.Text;
            var cpfEhValido = Validadores.ValidarCPF(cpf);
            if (cpfEhValido is false)
            {
                errorProvider.SetError(txtCpf, "CPF Inválido!");
                return;
            }
            errorProvider.Clear();
        }

        /// <summary>
        /// VALIDAÇÃO DE ERRO NO CAMPO DE EMAIL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            var email = txtEmail.Text;
            var emailEhValido = Validadores.EmailEValido(email);

            if (emailEhValido is false)
            {
                errorProvider.SetError(txtEmail, "Email Inválido!");
                return;
            }
            errorProvider.Clear();
        }

        /// <summary>
        /// VALIDAÇÃO DE ERRO NO CAMPO DE DATA DE NASCIMENTO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDataNascimento_Validated(object sender, EventArgs e)
        {
            var dataNascimento = Convert.ToDateTime(txtDataNascimento.Text);
            var dataHoje = DateTime.Now;
            if (dataNascimento > dataHoje)
            {
                errorProvider.SetError(txtDataNascimento, "Você não pode informar a data de hoje");
                return;
            }

            errorProvider.Clear();
        }

        /// <summary>
        /// Evento para cadastrar funcionário 
        /// </summary>
        /// <param object="sender"></param>
        /// <param EventArgs="e"></param>
        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)

        {
            var Data_Nascimento = Convert.ToDateTime(txtDataNascimento.Text);

            var Numero = int.Parse(txtEnderecoNumero.Text);
            var nac = cmbNacionalidade.SelectedValue;
            var nat = cmbNaturalidade.SelectedValue;
            int nacionalidade = Convert.ToInt32(nac); 
            int naturalidade = Convert.ToInt32(nat);

            
            

            var salvou = _funcionarioController.Cadastrar(txtNome.Text, Data_Nascimento,
                rbMasculino.Checked, txtCpf.Text, nacionalidade, naturalidade, txtEmail.Text, txtTelefone.Text,
                txtTelefoneContato.Text, txtEnderecoCep.Text, txtEnderecoLogradouro.Text, Numero, txtEnderecoComplemento.Text,
                txtEnderecoBairro.Text, txtEnderecoMunicipio.Text, txtEnderecoUf.Text);

            if (salvou)
            {
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar Funcionário!");
            }
        }

       
    }
}


        


