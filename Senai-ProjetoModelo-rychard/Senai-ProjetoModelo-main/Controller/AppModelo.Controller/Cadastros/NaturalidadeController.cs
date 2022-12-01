using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Infra.Repositories;
using System.Collections.Generic;


namespace AppModelo.Controller.Cadastros
{
    public class NaturalidadeController
    {

        /// <summary>
        /// MÉTODO RESPONSÁVEL POR CADASTRAR NOVA NATURALIDADE
        /// </summary>
        /// <param name="descricao"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public bool Cadastrar(string descricao,bool status)
        {
            var repositorio = new NaturalidadeRepository();

            var naturalidade = repositorio.ObterPorDescricao(descricao);
            if(naturalidade is not null) return false;

            var resposta = repositorio.Inserir(descricao, status);
            return resposta;
        }

        public List<NaturalidadeEntity> ObterTodasNaturalidades()
        {
            var repositorio = new NaturalidadeRepository();
            var resposta = repositorio.ObterTodosAtivos();
            return (List<NaturalidadeEntity>)resposta;
        }

        /// <summary>
        /// MÉTODO RESPONSÁVEL POR ATUALIZAR TABELA DE NATURALIDADE
        /// </summary>
        /// <param name="descricao"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Atualizar(string descricao, int id)
        {
            var repositorio = new NaturalidadeRepository();
            var atualizar = repositorio.Atualizar(descricao, id);
            return atualizar;
        }

        /// <summary>
        /// MÉTODO RESPONSÁVEL POR REMOVER NATURALIDADE POR ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Remover(int id)
        {
            var repositorio = new NaturalidadeRepository();
            var remover = repositorio.Remover(id);
            return remover;
        }
    }
}
