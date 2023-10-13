using AutoMapper;
using IntegracaoMilvusQlik.Data;
using IntegracaoMilvusQlik.Dtos;
using IntegracaoMilvusQlik.Interfaces;
using IntegracaoMilvusQlik.Models;

namespace IntegracaoMilvusQlik.Services
{
    public class ListaService : IListaService
    {
        private readonly IMapper _mapper;
        private readonly IMilvusApi _milvusApi;

        public ListaService(IMapper mapper, IMilvusApi milvusApi)
        {
            _mapper = mapper;
            _milvusApi = milvusApi;
        }

        public async Task<ResponseGenerico<List<ListaResponse>>> BuscarChamados(string? codigo, string apiKey)
        {
            var chamados = await _milvusApi.BuscarChamados(codigo, apiKey);
            return _mapper.Map<ResponseGenerico<List<ListaResponse>>>(chamados);
        }

        public async Task<ResponseGenerico<List<ListaResponse>>> BuscarPorData(string? dataInicial, string? dataFinal, string apiKey)
        {
            var chamados = await _milvusApi.BuscarPorData(dataInicial, dataFinal, apiKey);
            return _mapper.Map<ResponseGenerico<List<ListaResponse>>>(chamados);
        }
    }
}