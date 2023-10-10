using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace IntegracaoMilvusQlik.Models
{
    public class FiltroBody
    {
        [JsonProperty("codigo")]
        public string? Codigo { get; set; }
        [JsonProperty("data_hora_criacao_inicial")]
        public string? DataHoraCriacaoInicial { get; set; }
        [JsonProperty("data_hora_criacao_final")]
        public string? DataHoraCriacaoFinal { get; set; }
    }
}