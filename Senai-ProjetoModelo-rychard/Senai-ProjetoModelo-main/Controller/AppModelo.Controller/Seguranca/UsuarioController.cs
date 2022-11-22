using AppModelo.Model.Infra.Repositories;
using AppModelo.Model.Infra.Services;
using System;

namespace AppModelo.Controller.Seguranca
{
    public class UsuarioController
    {
        /// <summary>
        /// MÉTODO RESPONSÁVEL POR EFETUAR O LOGIN DE USUÁRIO
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="senha"></param>
        /// <returns></returns>
        public bool EfetuarLogin(string usuario, string senha)
        {
            var repositorio = new UsuarioRepository();
            var usuarioEncontrado = repositorio.obter(usuario, senha);

            if (usuarioEncontrado is not null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// MÉTODO RESPONSÁVEL POR RECUPERAR O LOGIN DE USUÁRIO
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public string RecuperarSenha(string email)
        {
            // 1 - VERIFICAR SE UM EMAIL É DE UM USUÁRIO
            var repository = new UsuarioRepository();
            var usuario = repository.ObterPorEmail(email);
            if (usuario is null)
            {
                return "Usuário não encontrado!";
            }
            // 2 - GERAR UMA NOVA SENHA E GRAVAR NO BANCO
            var novaSenha = Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();
            var atualizouSenha = repository.AtualizarSenha(email, novaSenha);
            if(atualizouSenha is false)
            {
                return "Erro ao recuperar senha, tente mais tarde!";
            }

            // 3 - MANDAR A NOVA SENHA PARA O EMAIL
            var emailService = new EmailService();
            var mensagemhtml = @"<p><b>Criamos uma nova senha para você! </p></b>
                                 <p>Sua nova senha é: <b>" + novaSenha + "</b></p>";
            
            var emailEnviado = emailService.EnviarEmail(usuario.Nome, usuario.Email, "Recuperação de senha", mensagemhtml);
            return "";
        }

        /// <summary>
        /// MÉTODO RESPONSÁVEL POR CADASTRAR NOVO USUÁRIO
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="senha"></param>
        /// <returns></returns>
        public bool CadastrarLogin(string usuario, string senha)
        {
            
            var repositorio = new UsuarioRepository();
       
            var resposta = repositorio.Inserir(usuario, senha);
            return resposta;


        }
    }
}
