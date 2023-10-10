using System.Net;
using IntegracaoMilvusQlik.Interfaces;
using IntegracaoMilvusQlik.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace IntegracaoMilvusQlik.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ListaController : ControllerBase
    {
        public readonly IListaService _listaService;

        public ListaController(IListaService listaService)
        {
            _listaService = listaService;
        }

        [HttpPost("buscar")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarChamados(string? codigo, string apiKey)
        {

            var response = await _listaService.BuscarChamados(codigo, apiKey);
            
            if (response.CodigoHttp == HttpStatusCode.OK)
            {
                return Ok(response.DadosRetorno);
            }
            else
            {
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
            }
        }

        [HttpPost("data")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarPorData(string? dataInicial, string? dataFinal, string apiKey)
        {

            var response = await _listaService.BuscarPorData(dataInicial, dataFinal, apiKey);
            
            if (response.CodigoHttp == HttpStatusCode.OK)
            {
                return Ok(response.DadosRetorno);
            }
            else
            {
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
            }
        }
    }
}