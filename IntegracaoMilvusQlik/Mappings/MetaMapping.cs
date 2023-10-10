using AutoMapper;
using IntegracaoMilvusQlik.Dtos;
using IntegracaoMilvusQlik.Models;

namespace IntegracaoMilvusQlik.Mappings
{
    public class MetaMapping : Profile
    {
        public MetaMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<MetaResponse, Meta>();
            CreateMap<Meta, MetaResponse>();
        }
    }
}