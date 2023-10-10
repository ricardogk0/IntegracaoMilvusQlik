using AutoMapper;
using IntegracaoMilvusQlik.Dtos;
using IntegracaoMilvusQlik.Models;

namespace IntegracaoMilvusQlik.Mappings
{
    public class UltimaLogMapping : Profile
    {
        public UltimaLogMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<UltimaLogResponse, UltimaLog>();
            CreateMap<UltimaLog, UltimaLogResponse>();
        }
    }
}