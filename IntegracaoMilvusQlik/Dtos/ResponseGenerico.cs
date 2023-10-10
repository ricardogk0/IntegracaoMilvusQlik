using System.Dynamic;
using System.Net;

namespace IntegracaoMilvusQlik.Dtos
{
    public class ResponseGenerico<T> where T : class
    {
       public HttpStatusCode CodigoHttp { get; set; }
       public T? DadosRetorno { get; set; }
       public string? ErroRetorno { get; set; }
    }
}