using System.Text.Json.Serialization;

namespace IntegracaoMilvusQlik.Dtos
{
    public class SolucaoResponse
    {
        public string? Status { get; set; }
        public string? TempoGasto { get; set; }
        public string? TempoRestante { get; set; }
        public string? Porcentagem { get; set; }
    }
}
