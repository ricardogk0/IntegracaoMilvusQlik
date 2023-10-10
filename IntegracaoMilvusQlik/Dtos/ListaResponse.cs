using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using IntegracaoMilvusQlik.Models;

namespace IntegracaoMilvusQlik.Dtos
{
   public class ListaResponse
    {
        [Key]
        public int Id { get; set; }
        public string? CategoriaPrimaria { get; set; }
        public string? CategoriaSecundaria { get; set; }
        public object? Tecnico { get; set; }
        public string? MesaTrabalho { get; set; }
        public object? DataSolucao { get; set; }
        public object? ServicoRealizado { get; set; }
        public object? DataAgendamento { get; set; }
        public object? DataResposta { get; set; }
        public object? Setor { get; set; }
        public object? TipoTicket { get; set; }
        public string? Prioridade { get; set; }
        public int Codigo { get; set; }
        public string? Cliente { get; set; }
        public string? ClienteToken { get; set; }
        public string? Assunto { get; set; }
        public string? Descricao { get; set; }
        public string? Contato { get; set; }
        public string? EmailConferencia { get; set; }
        public string? Telefone { get; set; }
        public DateTime? DataCriacao { get; set; }
        public string? DataModificacao { get; set; }
        public object? TotalHoras { get; set; }
        public string? Origem { get; set; }
        public string? Status { get; set; }
        public string? Impacto { get; set; }
        public string? Urgencia { get; set; }
        public SlaResponse? Sla { get; set; }
        public string? StatusSlaResposta { get; set; }
        public string? StatusSlaSolucao { get; set; }
    }
}

