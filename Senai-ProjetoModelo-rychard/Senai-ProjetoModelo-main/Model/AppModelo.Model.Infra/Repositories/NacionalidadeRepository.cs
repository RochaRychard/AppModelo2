using AppModelo.Model.Domain.Entities;
using Dapper;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;


namespace AppModelo.Model.Infra.Repositories
{
    public class NacionalidadeRepository
    {
        

        //CRUD - create - read - update- delete
        //       insert - select - update - delete
        public bool Inserir(string descricao) 
         {
            //STRING INTERPOLATION
            var sql = $"INSERT INTO nacionalidades(Descricao) VALUES('{descricao}')";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var resultado = conexaoBd.Execute(sql);

            return resultado > 0;
        }

        public bool Atualizar(string descricao, int id)
        {
            var sql = $"UPDATE nacionalidades SET Descricao = '{descricao}' WHERE Id = {id}";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;
        }

        public bool Remover(int id) 
        {
            var sql = $" DELETE FROM nacionalidades WHERE Id = {id}";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;
        }

        public IEnumerable<NacionalidadeEntity> ObterTodos()
        {
            var sql = "SELECT Id, Descricao FROM nacionalidades ORDER BY descricao ASC";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var resultado = conexaoBd.Query<NacionalidadeEntity>(sql);

            return resultado;
        }

        public NacionalidadeEntity ObterPorDescricao(string descricao)
        {
            //STRING INTERPOLATION
            var sql = $"SELECT Id, Descricao FROM nacionalidades WHERE Descricao = '{descricao}' ";


            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var resultado = conexaoBd.QuerySingleOrDefault<NacionalidadeEntity>(sql);

            return resultado;
        }

        public NacionalidadeEntity ObterPorId() 
         {
            return new NacionalidadeEntity();
         }
    }
}
