using AutoMapper;
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

        public async Task<ResponseGenerico<RootResponse>> BuscarChamados(string? codigo, string apiKey)
        {
            var chamados = await _milvusApi.BuscarChamados(codigo, apiKey);
            return _mapper.Map<ResponseGenerico<RootResponse>>(chamados);
        }

        public async Task<ResponseGenerico<RootResponse>> BuscarPorData(string? dataInicial, string? dataFinal, string apiKey)
        {
            var chamados = await _milvusApi.BuscarPorData(dataInicial, dataFinal, apiKey);
            return _mapper.Map<ResponseGenerico<RootResponse>>(chamados);
        }
    }
}