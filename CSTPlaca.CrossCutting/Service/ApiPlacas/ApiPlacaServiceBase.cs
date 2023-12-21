using System.Text.RegularExpressions;

namespace CSTPlaca.CrossCutting.Service.ApiPlacas
{
    public class ApiPlacaServiceBase
    {
        protected HttpClient _client;

        private string BaseApiUrl { get; set; }
        public ApiPlacaServiceBase()
        {
            _client = new HttpClient();
        }

        public string GetUriServiceAsync(string placa)
        {
            placa = Regex.Replace(placa, "[^a-zA-Z0-9]", ""); // Substitui tudo que não for letra ou número por ""

            //TODO:   //BaseApiUrl = $"https://wdapi2.com.br/consulta/{placa.ToUpper()}/{ApiToken.Token}";  //Endereço da api real
            BaseApiUrl = $"http://localhost:3000/placa"; //Endereço da api fake
            return BaseApiUrl;
        }
    }


}