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


        /// <summary>
        /// MÉTODO PARA INSERIR A DESCRIÇÃO DA NATURALIDADE NO BANCO DE DADOS
        /// </summary>
        /// <param name="descricao"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public bool Inserir(string descricao, bool status)
        {
            //STRING INTERPOLATION
            var agora = DateTime.Now.ToString("u");
            var sql = $"INSERT INTO naturalidade(Descricao, DataCriacao, DataAlteracao, Ativo) VALUES('{descricao}','{agora}', '{agora}', {status})";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var resultado = conexaoBd.Execute(sql);

            return resultado > 0;
        }

        /// <summary>
        /// MÉTODO PARA ATUALIZAR NATURALIDADE NO BANCO DE DADOS
        /// </summary>
        /// <param name="descricao"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Atualizar(string descricao, int id)
        {
            var sql = $"UPDATE naturalidade SET Descricao = '{descricao}' WHERE Id = {id}";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;
        }

        /// <summary>
        /// MÉTODO PARA REMOVER NATURALIDADE NO BANCO DE DADOS
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Remover(int id)
        {
            var sql = $" DELETE FROM naturalidade WHERE Id = {id}";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;
        }

        /// <summary>
        /// OBTÉM TODOS IDs ATIVOS NO BANCO DE DADOS
        /// </summary>
        /// <returns></returns>
        public IEnumerable<NaturalidadeEntity> ObterTodosAtivos()
        {
            var sql = $"SELECT Id, Descricao FROM naturalidade WHERE ativo = {true}";
            
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var resultado = conexaoBd.Query<NaturalidadeEntity>(sql);

            return resultado;

        }

        
        public NaturalidadeEntity ObterPorId()
        {
            return new NaturalidadeEntity();
        }


        /// <summary>
        /// OBTÉM POR DESCRIÇÃO NO BANCO DE DADOS
        /// </summary>
        /// <param name="descricao"></param>
        /// <returns></returns>
        public NaturalidadeEntity ObterPorDescricao(string descricao)
        {
            //STRING INTERPOLATION
            var sql = $"SELECT Id, Descricao FROM naturalidade WHERE Descricao = {descricao}"; 


            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var resultado = conexaoBd.QuerySingleOrDefault<NaturalidadeEntity>(sql);

            return resultado;
        }

        /// <summary>
        /// OBTÉM POR ID NO BANCO DE DADOS
        /// </summary>
        /// <returns></returns>
        public IEnumerable<NaturalidadeEntity> ObterTodos()
        {
            var sql = "SELECT Id, Descricao FROM naturalidade ORDER BY descricao ASC";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var resultado = conexaoBd.Query<NaturalidadeEntity>(sql);

            return resultado;

        }

    }
}

