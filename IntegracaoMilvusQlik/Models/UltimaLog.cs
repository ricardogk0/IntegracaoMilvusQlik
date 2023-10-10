using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Text;

namespace IntegracaoMilvusQlik.Models
{
    public class UltimaLog
        {
            [JsonProperty("tecnico")]
            public string? Tecnico { get; set; }

            [JsonProperty("texto")]
            public string? Texto { get; set; }

            [JsonProperty("texto_html")]
            public string? TextoHtml { get; set; }

            [JsonProperty("data")]
            public string? Data { get; set; }
        }
}

