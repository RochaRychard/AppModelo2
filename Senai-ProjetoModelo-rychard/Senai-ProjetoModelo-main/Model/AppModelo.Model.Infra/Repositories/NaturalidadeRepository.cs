using AppModelo.Model.Domain.Entities;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace AppModelo.Model.Infra.Repositories
{
    public class NaturalidadeRepository
    {
        //CRUD - create - read - update- delete
        //       insert - select - update - delete
        public bool Inserir(string descricao, bool status)
        {
            //STRING INTERPOLATION
            var agora = DateTime.Now.ToString("u");
            var sql = $"INSERT INTO naturalidade(Descricao, DataCriacao, DataAlteracao, Ativo) VALUES('{descricao}','{agora}', '{agora}', {status})";

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

        public bool Remover(int id)
        {
            var sql = $" DELETE FROM naturalidade WHERE Id = {id}";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;
        }

        public IEnumerable<NaturalidadeEntity> ObterTodosAtivos()
        {
            var sql = "SELECT Id, Descricao FROM naturalidade WHERE ativo = true";
            
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var resultado = conexaoBd.Query<NaturalidadeEntity>(sql);

            return resultado;

        }
        public NaturalidadeEntity ObterPorId()
        {
            return new NaturalidadeEntity();
        }

        public NaturalidadeEntity ObterPorDescricao(string descricao)
        {
            //STRING INTERPOLATION
            var sql = $"SELECT Id, Descricao FROM naturalidade WHERE Descricao = '{descricao}' "; 


            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var resultado = conexaoBd.QuerySingleOrDefault<NaturalidadeEntity>(sql);

            return resultado;
        }
        public IEnumerable<NaturalidadeEntity> ObterTodos()
        {
            var sql = "SELECT Id, Descricao FROM naturalidade ORDER BY descricao ASC";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var resultado = conexaoBd.Query<NaturalidadeEntity>(sql);

            return resultado;

        }

    }
}

