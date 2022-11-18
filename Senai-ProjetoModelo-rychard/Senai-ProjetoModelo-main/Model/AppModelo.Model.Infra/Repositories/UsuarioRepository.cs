using AppModelo.Model.Domain.Entities;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace AppModelo.Model.Infra.Repositories
{
    public class UsuarioRepository
    {
        public UsuarioEntity obter(string usuario, string senha)
        {
            var sql = $"SELECT Email, Senha FROM usuarios WHERE Email = '{usuario}' AND Senha = '{senha}';";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var resultado = conexaoBd.QuerySingleOrDefault<UsuarioEntity>(sql);

            return resultado;
        }
        public UsuarioEntity ObterPorEmail(string email)
        {
            var sql = $"SELECT Email FROM usuarios WHERE Email = '{email}' ";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var resultado = conexaoBd.QuerySingleOrDefault<UsuarioEntity>(sql);

            return resultado;
        }
        public bool AtualizarSenha(string novaSenha, string email)
        {
            var sql = $"UPDATE usuarios SET Senha = '{novaSenha}' WHERE email = '{email}'";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var resultado = conexaoBd.Execute(sql);

            return resultado > 0;
        }
        public bool Inserir(string email, string senha)
        {
            
            var sql = $"INSERT INTO usuarios(Email, Senha) VALUES('{email}','{senha}')";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var resultado = conexaoBd.Execute(sql);

            return resultado > 0;
        }
    }
}
