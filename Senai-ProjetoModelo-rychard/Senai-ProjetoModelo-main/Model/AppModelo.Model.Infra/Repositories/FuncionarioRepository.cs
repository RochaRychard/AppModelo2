using AppModelo.Model.Domain.Entities;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using static AppModelo.Model.Domain.Validator.Validadores;

namespace AppModelo.Model.Infra.Repositories
{
    public class FuncionarioRepository
    {

        //CRUD - create - read - update- delete
        //       insert - select - update - delete
        public bool Inserir(string Nome, DateTime Data_Nascimento, bool Sexo, string Cpf, int Nacionalidade, int Naturalidade, string Email, string Telefone, string Telefone_Contato, string Cep, string Logradouro, int Numero, string Complemento, string Bairro, string Municipio, string Uf)
        {
            var dataConvertida = Data_Nascimento.ToString("yyyy-mm-dd");

            //STRING INTERPOLATION
            var sql = $"INSERT INTO funcionarios(Nome, Data_Nascimento, Sexo, Cpf, " +
                      $"Nacionalidade, Naturalidade, Email, Telefone, " +
                      $"Telefone_Contato, Cep, Logradouro, Numero, Complemento, Bairro, Municipio, Uf) VALUES('{Nome}', '{Data_Nascimento}'," +
                      $" {Sexo}, '{Cpf}' ,'{Nacionalidade}', '{Naturalidade}', '{Email}', '{Telefone}', '{Telefone_Contato}', '{Cep}', '{Logradouro}'," +
                      $" '{Numero}', '{Complemento}', '{Bairro}', '{Municipio}', '{Uf}')";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var resultado = conexaoBd.Execute(sql);

            return resultado > 0;
        }

        public bool Remover(int id)
        {
            var sql = $" DELETE FROM funcionarios WHERE Id = {id}";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;
        }

        public bool Atualizar(string descricao, int id)
        {
            var sql = $"UPDATE naturalidade SET Descricao = '{descricao}' WHERE Id = {id}";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;
        }


        public IEnumerable<FuncionarioEntity> ObterTodos()
        {
            var sql = "SELECT Id, Descricao FROM nacionalidades ORDER BY descricao ASC";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var resultado = conexaoBd.Query<FuncionarioEntity>(sql);

            return resultado;
        }

        public FuncionarioEntity ObterPorId()
        {
            return new FuncionarioEntity();
        }

        public IEnumerable<FuncionarioEntity> ObterTodosFuncionarios()
        {
            var sql = "SELECT * FROM funcionarios";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var resultado = conexaoBd.Query<FuncionarioEntity>(sql);

            return resultado;
        }
    }
}

