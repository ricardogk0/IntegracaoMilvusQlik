using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Text;

namespace IntegracaoMilvusQlik.Models
{
    public class UltimaLogNaoPossui : UltimaLog
    {
        public string? UltimaLog { get; set; }
    }
}