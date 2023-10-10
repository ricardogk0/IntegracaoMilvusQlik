using AutoMapper;
using IntegracaoMilvusQlik.Dtos;
using IntegracaoMilvusQlik.Models;

namespace IntegracaoMilvusQlik.Mappings
{
    public class RespostaMapping : Profile
    {
        public RespostaMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<RespostaResponse, Resposta>();
            CreateMap<Resposta, RespostaResponse>();
        }
    }
}