using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace IntegracaoMilvusQlik.Models
{    
    public class Paginate
    {
        [JsonProperty("current_page")]
        public string? CurrentPage { get; set; }

        [JsonProperty("total")]
        public int? Total { get; set; }

        [JsonProperty("to")]
        public int? To { get; set; }

        [JsonProperty("from")]
        public int? From { get; set; }

        [JsonProperty("last_page")]
        public int? LastPage { get; set; }

        [JsonProperty("per_page")]
        public int? PerPage { get; set; }
    }
}