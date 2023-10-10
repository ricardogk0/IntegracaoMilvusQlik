using IntegracaoMilvusQlik.Dtos;
using IntegracaoMilvusQlik.Models;

namespace IntegracaoMilvusQlik.Interfaces
{
    public interface IMilvusApi
    {
        Task<ResponseGenerico<Root>> BuscarChamados(string? codigo, string apiKey);
        Task<ResponseGenerico<Root>> BuscarPorData(string? dataInicial, string? dataFinal, string apiKey);
    }
}