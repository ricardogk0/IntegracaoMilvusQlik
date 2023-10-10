using System.Text.Json.Serialization;

namespace IntegracaoMilvusQlik.Dtos
{
    public class RootResponse
    {
        public MetaResponse? Meta { get; set; }
        public List<ListaResponse>? Lista { get; set; }
    }
}