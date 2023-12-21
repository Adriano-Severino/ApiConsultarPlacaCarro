using CSTPlaca.CrossCutting.Model;

namespace CSTPlaca.CrossCutting.Interface
{
    public interface IApiPlacaService
    {
        public Task<ApiPlacaModel> GetPlacaAsync(string placa);
    }
}
