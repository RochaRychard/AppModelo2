using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Infra.Repositories;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Runtime.Remoting.Messaging;

namespace AppModelo.Controller.Cadastros
{
    public class NacionalidadeController
    {
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

        public bool Atualizar(string descricao, int id)
        {
            var repositorio = new NacionalidadeRepository();
            var atualizar = repositorio.Atualizar(descricao, id);
            return atualizar;
        }

        public bool Remover(int id)
        {   var repositorio = new NacionalidadeRepository();
            var remover = repositorio.Remover(id);
            return remover;
        }
            
    }
}
