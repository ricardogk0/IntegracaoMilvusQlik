using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace IntegracaoMilvusQlik.Models
{
    public class FiltroBodyWrapper
    {
        [JsonProperty("filtro_body")]
        public FiltroBody? FiltroBody { get; set; }
    }
}