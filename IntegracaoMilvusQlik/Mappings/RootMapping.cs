using AutoMapper;
using IntegracaoMilvusQlik.Dtos;
using IntegracaoMilvusQlik.Models;

namespace IntegracaoMilvusQlik.Mappings
{
    public class RootMapping : Profile
    {
        public RootMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<RootResponse, Root>();
            CreateMap<Root, RootResponse>();
        }
    }
}