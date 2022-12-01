using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Infra.Repositories;
using System;
using System.Collections.Generic;

namespace AppModelo.Controller.Cadastros
{
    public class FuncionarioController
    {

        /// <summary>
        /// MÉTODO RESPONSÁVEL POR CADASTRAR NOVO FUNCIONÁRIO
        /// </summary>
        /// <param name="Nome"></param>
        /// <param name="Data_Nascimento"></param>
        /// <param name="Sexo"></param>
        /// <param name="Cpf"></param>
        /// <param name="Nacionalidade"></param>
        /// <param name="Naturalidade"></param>
        /// <param name="Email"></param>
        /// <param name="Telefone"></param>
        /// <param name="Telefone_Contato"></param>
        /// <param name="Cep"></param>
        /// <param name="Logradouro"></param>
        /// <param name="Numero"></param>
        /// <param name="Complemento"></param>
        /// <param name="Bairro"></param>
        /// <param name="Municipio"></param>
        /// <param name="Uf"></param>
        /// <returns></returns>
        public bool Cadastrar(string Nome, DateTime Data_Nascimento, bool Sexo, string Cpf,
            int Nacionalidade, int Naturalidade, string Email, string
            Telefone, string Telefone_Contato, string Cep, string Logradouro,
            int Numero, string Complemento, string Bairro, string Municipio,
            string Uf)
        {
            var repositorio = new FuncionarioRepository();
            var resposta = repositorio.Inserir(Nome, Data_Nascimento,
                Sexo, Cpf, Nacionalidade, Naturalidade, Email, Telefone,
                Telefone_Contato, Cep, Logradouro, Numero, Complemento,
                Bairro, Municipio, Uf);
            return resposta;
        }


        /// <summary>
        /// MÉTODO RESPONSÁVEL POR REMOVER FUNCIONÁRIO POR ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Remover(int id)
        {
            var repositorio = new FuncionarioRepository();
            var remover = repositorio.Remover(id);
            return remover;
        }

        public IEnumerable<FuncionarioEntity> ObterTodasNacionalidades()
        {
            var repositorio = new FuncionarioRepository();
            var resposta = repositorio.ObterTodos();
            return (IEnumerable<FuncionarioEntity>)resposta;
        }

        public IEnumerable<FuncionarioEntity> ObterFuncionarios()
        {
            var repositorio = new FuncionarioRepository();
            var resposta = repositorio.ObterTodosFuncionarios();
            return (IEnumerable<FuncionarioEntity>) resposta;
        }
    }
}
