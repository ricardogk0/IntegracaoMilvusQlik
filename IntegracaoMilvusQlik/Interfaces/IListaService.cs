using IntegracaoMilvusQlik.Dtos;

namespace IntegracaoMilvusQlik.Interfaces
{
    public interface IListaService
    {
        Task<ResponseGenerico<List<ListaResponse>>> BuscarChamados(string? codigo, string apiKey);
        Task<ResponseGenerico<List<ListaResponse>>> BuscarPorData(string? dataInicial, string? dataFinal, string apiKey);
    }
}