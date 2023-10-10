using AutoMapper;
using IntegracaoMilvusQlik.Dtos;
using IntegracaoMilvusQlik.Models;

namespace IntegracaoMilvusQlik.Mappings
{
    public class PaginateMapping : Profile
    {
        public PaginateMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<PaginateResponse, Paginate>();
            CreateMap<Paginate, PaginateResponse>();
        }
    }
}