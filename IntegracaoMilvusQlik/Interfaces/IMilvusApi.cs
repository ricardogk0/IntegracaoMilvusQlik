using IntegracaoMilvusQlik.Dtos;
using IntegracaoMilvusQlik.Models;

namespace IntegracaoMilvusQlik.Interfaces
{
    public interface IMilvusApi
    {
        Task<ResponseGenerico<List<Lista>>> BuscarChamados(string? codigo, string apiKey);
        Task<ResponseGenerico<List<Lista>>> BuscarPorData(string? dataInicial, string? dataFinal, string apiKey);
    }
}