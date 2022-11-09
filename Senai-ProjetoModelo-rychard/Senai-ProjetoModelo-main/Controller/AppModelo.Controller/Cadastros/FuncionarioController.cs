using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Infra.Repositories;
using System;
using System.Collections.Generic;


namespace AppModelo.Controller.Cadastros
{
    public class FuncionarioController
    {
        
        public bool Cadastrar(string Nome, DateTime Data_Nascimento, bool Sexo, 
            int Nacionalidade, int Naturalidade, string Email, string 
            Telefone, string Telefone_Contato, string Cep, string Logradouro, 
            int Numero, string Complemento, string Bairro, string Municipio,
            string Uf)
        {
            var repositorio = new FuncionarioRepository();
            var resposta = repositorio.Inserir(Nome, Data_Nascimento,
                Sexo, Nacionalidade, Naturalidade, Email, Telefone,
                Telefone_Contato, Cep, Logradouro, Numero, Complemento,
                Bairro, Municipio, Uf);
            return resposta;
        }

        public IEnumerable<FuncionarioEntity> ObterTodasNacionalidades()
        {
            var repositorio = new FuncionarioRepository();
            var resposta = repositorio.ObterTodos();
            return (IEnumerable<FuncionarioEntity>)resposta;
        }
    }
}
