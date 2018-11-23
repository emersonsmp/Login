using System;
using System.Collections.Generic;
using System.Text;

using Login.Servico.Modelo;
using System.Net;
using Newtonsoft.Json;

namespace Login.Servico
{
    public class LoginServico
    {
        //Link Local Host: localhost/ApiLogin/api.php?login={0}/{1}

        //Link Servidor:
        private static string EnderecoURL = "https://SeuSite/api.php?login={0}/{1}";

        //RECEBE CEP DIGITADO
        public static Resposta LoginJson(string email, string senha)
        {
            //COLOCA CEP NA URL
            string NovoEnderecoURL = string.Format(EnderecoURL, email, senha);
            WebClient wc = new WebClient();

            //TODO - RECEBE JSON
            string Conteudo = wc.DownloadString(NovoEnderecoURL);

            //DESERIALIZA, CONVERTE P/ OBJ
            Resposta end = JsonConvert.DeserializeObject<Resposta>(Conteudo);

            return end;
        }
    }
}
   

