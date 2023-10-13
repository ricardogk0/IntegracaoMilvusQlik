using System.Dynamic;
using System.Text;
using System.Text.Json;
using IntegracaoMilvusQlik.Dtos;
using IntegracaoMilvusQlik.Interfaces;
using IntegracaoMilvusQlik.Models;
using Newtonsoft.Json;

namespace IntegracaoMilvusQlik.Rest
{
    public class MilvusApiRest : IMilvusApi
    {
        
        public async Task<ResponseGenerico<List<Lista>>> BuscarChamados(string? codigo, string apiKey)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, $"https://apiintegracao.milvus.com.br/api/chamado/listagem");
            var response = new ResponseGenerico<List<Lista>>();
            request.Headers.Add("Authorization", apiKey);
            
            var pesquisa = new FiltroBodyWrapper {
                FiltroBody = new FiltroBody{
                    Codigo = codigo
                }
            };

            request.Content = new StringContent(JsonConvert.SerializeObject(pesquisa), Encoding.UTF8, "application/json");          

            using(var client = new HttpClient())
            {
                var responseMilvusApi = await client.SendAsync(request);
                var contentResponse = await responseMilvusApi.Content.ReadAsStringAsync();   

                if(responseMilvusApi.IsSuccessStatusCode)
                {
                    response.CodigoHttp = responseMilvusApi.StatusCode;
                    var objResponse = JsonConvert.DeserializeObject<Root>(contentResponse);

                    response.DadosRetorno = objResponse.Lista;
                }
                else
                {
                    response.CodigoHttp = responseMilvusApi.StatusCode;
                    response.ErroRetorno = contentResponse;
                }

                return response;
            }
        }

        public async Task<ResponseGenerico<List<Lista>>> BuscarPorData(string? dataInicial, string? dataFinal, string apiKey)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, $"https://apiintegracao.milvus.com.br/api/chamado/listagem");
            var response = new ResponseGenerico<List<Lista>>();
            request.Headers.Add("Authorization", apiKey);

            var pesquisa = new FiltroBodyWrapper{
                FiltroBody = new FiltroBody{
                    DataHoraCriacaoInicial = dataInicial,
                    DataHoraCriacaoFinal = dataFinal
                }
            };

            request.Content = new StringContent(JsonConvert.SerializeObject(pesquisa), Encoding.UTF8, "application/json");     

            using(var client = new HttpClient())
            {
                var responseMilvusApi = await client.SendAsync(request);
                var contentResponse = await responseMilvusApi.Content.ReadAsStringAsync();   

                if(responseMilvusApi.IsSuccessStatusCode)
                {
                    response.CodigoHttp = responseMilvusApi.StatusCode;
                    var objResponse = JsonConvert.DeserializeObject<Root>(contentResponse);

                    response.DadosRetorno = objResponse.Lista;
                }
                else
                {
                    response.CodigoHttp = responseMilvusApi.StatusCode;
                    response.ErroRetorno = contentResponse;
                }

                return response;
            } 
        }
    }
}