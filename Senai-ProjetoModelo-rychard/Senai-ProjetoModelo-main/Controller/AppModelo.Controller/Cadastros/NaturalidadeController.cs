using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Infra.Repositories;
using System.Collections.Generic;


namespace AppModelo.Controller.Cadastros
{
    public class NaturalidadeController
    {
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


        public bool Atualizar(string descricao, int id)
        {
            var repositorio = new NaturalidadeRepository();
            var atualizar = repositorio.Atualizar(descricao, id);
            return atualizar;
        }

        public bool Remover(int id)
        {
            var repositorio = new NaturalidadeRepository();
            var remover = repositorio.Remover(id);
            return remover;
        }
    }
}
