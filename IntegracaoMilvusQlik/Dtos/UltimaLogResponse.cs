using System.Text.Json.Serialization;

namespace IntegracaoMilvusQlik.Dtos
{
    public class UltimaLogResponse
        {
            public string? Tecnico { get; set; }
            public string? Texto { get; set; }
            public string? TextoHtml { get; set; }
            public string? Data { get; set; }
        }
}

