using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace IntegracaoMilvusQlik.Models
{
    public class Sla
    {
        [JsonProperty("is_sla_pausada")]
        public bool IsSlaPausada { get; set; }

        [JsonProperty("total_sla_resposta_programado")]
        public string? TotalSlaRespostaProgramado { get; set; }

        [JsonProperty("total_sla_solucao_programado")]
        public string? TotalSlaSolucaoProgramado { get; set; }

        [JsonProperty("total_pausas_sla")]
        public int TotalPausasSla { get; set; }

        [JsonProperty("data_expiracao_sla")]
        public string? DataExpiracaoSla { get; set; }

        [JsonProperty("status_sla_resposta")]
        public string? StatusSlaResposta { get; set; }

        [JsonProperty("status_sla_solucao")]
        public string? StatusSlaSolucao { get; set; }

        [JsonProperty("resposta")]
        public Resposta? Resposta { get; set; }

        [JsonProperty("solucao")]
        public Solucao? Solucao { get; set; }
    }
}