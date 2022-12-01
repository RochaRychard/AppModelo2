using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Infra.Repositories;
using System.Collections.Generic;

namespace AppModelo.Controller.Cadastros
{
    public class NacionalidadeController
    {
        /// <summary>
        /// MÉTODO RESPONSÁVEL POR CADASTRAR NOVA NACIONALIDADE
        /// </summary>
        /// <param name="descricao"></param>
        /// <returns></returns>
        public bool Cadastrar(string descricao)
        {
            var repositorio = new NacionalidadeRepository();

            
            var nacionalidade = repositorio.ObterPorDescricao(descricao);
            if (nacionalidade is not null) return false;

            var resposta = repositorio.Inserir(descricao);
            return resposta;
        }


        public List<NacionalidadeEntity> ObterTodasNacionalidades()
        {
            var repositorio = new NacionalidadeRepository();
            var resposta = repositorio.ObterTodos();
            return (List<NacionalidadeEntity>)resposta;
        }

        /// <summary>
        /// MÉTODO RESPONSÁVEL POR ATUALIZAR TABELA DE NACIONALIDADE
        /// </summary>
        /// <param name="descricao"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Atualizar(string descricao, int id)
        {
            var repositorio = new NacionalidadeRepository();
            var atualizar = repositorio.Atualizar(descricao, id);
            return atualizar;
        }

        /// <summary>
        /// MÉTODO RESPONSÁVEL POR REMOVER NACIONALIDADE POR ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Remover(int id)
        {   var repositorio = new NacionalidadeRepository();
            var remover = repositorio.Remover(id);
            return remover;
        }
            
    }
}
