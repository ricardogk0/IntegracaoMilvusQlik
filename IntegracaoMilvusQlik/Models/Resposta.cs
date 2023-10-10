using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace IntegracaoMilvusQlik.Models
{
    public class Resposta
    {
        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("tempo_gasto")]
        public string? TempoGasto { get; set; }

        [JsonProperty("tempo_restante")]
        public string? TempoRestante { get; set; }

        [JsonProperty("porcentagem")]
        public string? Porcentagem { get; set; }
    } 
}