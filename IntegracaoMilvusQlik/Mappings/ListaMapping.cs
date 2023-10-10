using AutoMapper;
using IntegracaoMilvusQlik.Dtos;
using IntegracaoMilvusQlik.Models;

namespace IntegracaoMilvusQlik.Mappings
{
    public class ListaMapping : Profile
    {
        public ListaMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<ListaResponse, Lista>();
            CreateMap<Lista, ListaResponse>();
        }
    }
}