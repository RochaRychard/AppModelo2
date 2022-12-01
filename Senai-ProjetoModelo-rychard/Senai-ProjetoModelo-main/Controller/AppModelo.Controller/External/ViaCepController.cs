using AppModelo.Model.Domain.Wrappers;
using AppModelo.Model.Infra.Services;

namespace AppModelo.Controller.External
{
    public class ViaCepController
    {
        /// <summary>
        /// Retorna a classe ViaCepWrapper
        /// </summary>
        /// <param name="cep"></param>
        /// <returns></returns>
        public ViaCepWrapper Obter(string cep)
        {
            var sevice = new ViaCepService();

            var viaCep = sevice.ObterDaApi(cep);
           

            return viaCep;
        }
    }
}
