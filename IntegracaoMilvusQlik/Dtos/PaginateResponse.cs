using System.Text.Json.Serialization;

namespace IntegracaoMilvusQlik.Dtos
{    
    public class PaginateResponse
    {
        public string? CurrentPage { get; set; }
        public int? Total { get; set; }
        public int? To { get; set; }
        public int? From { get; set; }
        public int? LastPage { get; set; }
        public int? PerPage { get; set; }
    }
}