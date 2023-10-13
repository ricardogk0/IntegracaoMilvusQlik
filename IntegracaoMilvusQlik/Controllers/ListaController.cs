using System.Net;
using AutoMapper;
using IntegracaoMilvusQlik.Data;
using IntegracaoMilvusQlik.Dtos;
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
        private readonly IntegracaoMilvusQlikContext _context;
        private readonly IMapper _mapper;

        public ListaController(IListaService listaService, IntegracaoMilvusQlikContext context, IMapper mapper)
        {
            _listaService = listaService;
            _context = context;
            _mapper = mapper;
        }

        [HttpPost("buscar")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarChamados(string? codigo, string apiKey)
        {

            var response = await _listaService.BuscarChamados(codigo, apiKey);       
            var dadosMapeados = _mapper.Map<List<Lista>>(response.DadosRetorno);
            foreach(var item in dadosMapeados)
            {
                _context.Listas.Add(item);
                await _context.SaveChangesAsync();
            }
            
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
            var dadosMapeados = _mapper.Map<List<Lista>>(response.DadosRetorno);
            foreach(var item in dadosMapeados)
            {
                _context.Listas.Add(item);
                await _context.SaveChangesAsync();
            }
            
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