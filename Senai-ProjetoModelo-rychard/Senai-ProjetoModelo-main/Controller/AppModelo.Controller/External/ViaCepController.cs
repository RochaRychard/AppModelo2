using AppModelo.Model.Domain.Wrappers;
using AppModelo.Model.Infra.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Controller.External
{
    public class ViaCepController
    {
        //Retorna a classe ViaCepWrapper
        public ViaCepWrapper Obter(string cep)
        {
            var sevice = new ViaCepService();

            var viaCep = sevice.ObterDaApi(cep);
           

            return viaCep;
        }
    }
}
