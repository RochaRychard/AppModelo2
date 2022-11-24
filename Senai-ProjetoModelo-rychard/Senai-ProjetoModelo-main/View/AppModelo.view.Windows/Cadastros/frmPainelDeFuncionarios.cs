using AppModelo.Controller.Cadastros;
using System.Windows.Forms;

namespace AppModelo.view.Windows.Cadastros
{
    public partial class frmPainelDeFuncionarios : Form
    {
        private FuncionarioController _funcionarioController = new FuncionarioController();
        public frmPainelDeFuncionarios()
        {
            InitializeComponent();
            var listaDeFuncionarios = _funcionarioController.ObterFuncionarios();
            dgPainelDeFuncionarios.DataSource = listaDeFuncionarios;
            gerirDataDridView();
        }

        public void gerirDataDridView()
        {
            dgPainelDeFuncionarios.Columns[0].HeaderText = "Id";
            dgPainelDeFuncionarios.Columns[1].HeaderText = "Nome";
            dgPainelDeFuncionarios.Columns[2].HeaderText = "DataNascimento";
            dgPainelDeFuncionarios.Columns[3].HeaderText = "Sexo";
            dgPainelDeFuncionarios.Columns[4].HeaderText = "Cpf";
            dgPainelDeFuncionarios.Columns[5].HeaderText = "Nacionalidade";
            dgPainelDeFuncionarios.Columns[6].HeaderText = "Naturalidade";
            dgPainelDeFuncionarios.Columns[7].HeaderText = "Email";
            dgPainelDeFuncionarios.Columns[8].HeaderText = "Telefone";
            dgPainelDeFuncionarios.Columns[9].HeaderText = "TelefoneContato";
            dgPainelDeFuncionarios.Columns[10].HeaderText = "Cep";
            dgPainelDeFuncionarios.Columns[11].HeaderText = "Logradouro";
            dgPainelDeFuncionarios.Columns[12].HeaderText = "Numero";
            dgPainelDeFuncionarios.Columns[13].HeaderText = "Complemento";
            dgPainelDeFuncionarios.Columns[14].HeaderText = "Bairro";
            dgPainelDeFuncionarios.Columns[15].HeaderText = "Municipio";
            dgPainelDeFuncionarios.Columns[16].HeaderText = "Uf";

            dgPainelDeFuncionarios.Columns[2].Visible = false;
            dgPainelDeFuncionarios.Columns[3].Visible = false;
            dgPainelDeFuncionarios.Columns[4].Visible = false;
            dgPainelDeFuncionarios.Columns[5].Visible = false;
            dgPainelDeFuncionarios.Columns[6].Visible = false;
            dgPainelDeFuncionarios.Columns[1].Visible = false;
            dgPainelDeFuncionarios.Columns[1].Visible = false;
            dgPainelDeFuncionarios.Columns[1].Visible = false;
            dgPainelDeFuncionarios.Columns[1].Visible = false;
            dgPainelDeFuncionarios.Columns[1].Visible = false;
            dgPainelDeFuncionarios.Columns[1].Visible = false;
            dgPainelDeFuncionarios.Columns[1].Visible = false;
        }
    }
}
