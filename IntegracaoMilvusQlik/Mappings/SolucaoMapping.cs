using AutoMapper;
using IntegracaoMilvusQlik.Dtos;
using IntegracaoMilvusQlik.Models;

namespace IntegracaoMilvusQlik.Mappings
{
    public class SolucaoMapping : Profile
    {
        public SolucaoMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<SolucaoResponse, Solucao>();
            CreateMap<Solucao, SolucaoResponse>();
        }
    }
}