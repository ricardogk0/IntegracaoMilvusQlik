using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace IntegracaoMilvusQlik.Models
{
    public class Root
    {
        [JsonProperty("meta")]
        public Meta? Meta { get; set; }

        [JsonProperty("lista")]
        public List<Lista>? Lista { get; set; }
    }
}