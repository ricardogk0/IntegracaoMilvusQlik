using AutoMapper;
using IntegracaoMilvusQlik.Dtos;
using IntegracaoMilvusQlik.Models;

namespace IntegracaoMilvusQlik.Mappings
{
    public class SlaMapping : Profile
    {
        public SlaMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<SlaResponse, Sla>();
            CreateMap<Sla, SlaResponse>();
        }
    }
}