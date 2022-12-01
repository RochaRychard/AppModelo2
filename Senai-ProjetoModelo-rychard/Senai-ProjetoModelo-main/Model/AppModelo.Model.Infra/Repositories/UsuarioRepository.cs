using AppModelo.Model.Domain.Entities;
using Dapper;
using MySql.Data.MySqlClient;
using System.Data;

namespace AppModelo.Model.Infra.Repositories
{
    public class UsuarioRepository
    {
        /// <summary>
        /// MÉTODO PARA OBTER DADOS DE EMAIL E SENHA DO USUÁRIO NO BANCO DE DADOS
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="senha"></param>
        /// <returns></returns>
        public UsuarioEntity obter(string usuario, string senha)
        {
            var sql = $"SELECT Email, Senha FROM usuarios WHERE Email = '{usuario}' AND Senha = '{senha}';";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var resultado = conexaoBd.QuerySingleOrDefault<UsuarioEntity>(sql);

            return resultado;
        }

        /// <summary>
        /// MÉTODO PARA OBTER O EMAIL NO BANCO DE DADOS
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public UsuarioEntity ObterPorEmail(string email)
        {
            var sql = $"SELECT Email FROM usuarios WHERE Email = '{email}' ";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var resultado = conexaoBd.QuerySingleOrDefault<UsuarioEntity>(sql);

            return resultado;
        }

        /// <summary>
        /// MÉTODO PARA ATUALIZAR EMAIL E NOVA SENHA NO BANCO DE DADOS
        /// </summary>
        /// <param name="novaSenha"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool AtualizarSenha(string novaSenha, string email)
        {
            var sql = $"UPDATE usuarios SET Senha = '{novaSenha}' WHERE email = '{email}'";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var resultado = conexaoBd.Execute(sql);

            return resultado > 0;
        }

        /// <summary>
        /// MÉTODO PARA INSERIR EMAIL E SENHA NO BANCO DE DADOS
        /// </summary>
        /// <param name="email"></param>
        /// <param name="senha"></param>
        /// <returns></returns>
        public bool Inserir(string email, string senha)
        {
            
            var sql = $"INSERT INTO usuarios(Email, Senha) VALUES('{email}','{senha}')";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var resultado = conexaoBd.Execute(sql);

            return resultado > 0;
        }
    }
}
