using IntegracaoMilvusQlik.Dtos;
using IntegracaoMilvusQlik.Models;

namespace IntegracaoMilvusQlik.Interfaces
{
    public interface IListaService
    {
        Task<ResponseGenerico<RootResponse>> BuscarChamados(string? codigo, string apiKey);
        Task<ResponseGenerico<RootResponse>> BuscarPorData(string? dataInicial, string? dataFinal, string apiKey);
    }
}