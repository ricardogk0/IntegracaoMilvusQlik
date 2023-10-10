using System.Text.Json.Serialization;

namespace IntegracaoMilvusQlik.Dtos
{
    public class SlaResponse
    {
        public bool IsSlaPausada { get; set; }
        public string? TotalSlaRespostaProgramado { get; set; }
        public string? TotalSlaSolucaoProgramado { get; set; }
        public int TotalPausasSla { get; set; }
        public string? DataExpiracaoSla { get; set; }
        public string? StatusSlaResposta { get; set; }
        public string? StatusSlaSolucao { get; set; }
        public RespostaResponse? Resposta { get; set; }
        public SolucaoResponse? Solucao { get; set; }
    }
}