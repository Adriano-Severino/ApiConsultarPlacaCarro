using CSTPlaca.CrossCutting.Interface;
using CSTPlaca.CrossCutting.Model;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Net;

namespace CSTPlaca.CrossCutting.Service.ApiPlacas
{
    public class ApiPlacaService : ApiPlacaServiceBase, IApiPlacaService
    {
        private IConfiguration _configuration; // Injetar a interface IConfiguration

        public ApiPlacaService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<ApiPlacaModel> GetPlacaAsync(string placa)
        {
            try
            {
                var token = _configuration["ApiToken:Token"];
                ApiToken.Token = token;

                HttpResponseMessage response = await _client.GetAsync($"{GetUriServiceAsync(placa)}");
                response.EnsureSuccessStatusCode();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var responseService = JsonConvert.DeserializeObject<ApiPlacaModel[]>(response.Content.ReadAsStringAsync().Result);

                    return responseService.FirstOrDefault(); //TODO: remover esse FirstOrDefault quando tiver o url da api real e nao a fake

                }
                return new ApiPlacaModel();

            }
            catch (Exception ex)
            {
                throw new Exception($"Aconteceu um erro ao tentar buscar os dados da api publica erro:{ex.Message}");
            }
        }
    }
}
