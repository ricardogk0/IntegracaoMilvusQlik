using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace IntegracaoMilvusQlik.Models
{
        public class Meta
    {
        [JsonProperty("paginate")]
        public Paginate? Paginate { get; set; }
    }
}