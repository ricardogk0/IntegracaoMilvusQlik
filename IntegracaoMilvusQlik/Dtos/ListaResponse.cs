using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using IntegracaoMilvusQlik.Models;

namespace IntegracaoMilvusQlik.Dtos
{
   public class ListaResponse
    {
        public int Id { get; set; }
        public string? CategoriaPrimaria { get; set; }
        public string? CategoriaSecundaria { get; set; }
        public string? TotalAvaliacao { get; set; }
        public string? DescricaoAvaliacao { get; set; }
        public string? Tecnico { get; set; }
        public string? MesaTrabalho { get; set; }
        public DateTime? DataSolucao { get; set; }
        public string? ServicoRealizado { get; set; }
        public DateTime? DataAgendamento { get; set; }
        public DateTime? DataResposta { get; set; }
        public string? EquipamentoRetirado { get; set; }
        public string? MaterialUtilizado { get; set; }
        public string? Setor { get; set; }
        public string? TipoTicket { get; set; }
        public string? Prioridade { get; set; }
        public int? Codigo { get; set; }
        public string? Cliente { get; set; }
        public string? ClienteToken { get; set; }
        public string? Assunto { get; set; }
        public string? Descricao { get; set; }
        public string? Contato { get; set; }
        public string? EmailConferencia { get; set; }
        public string? Telefone { get; set; } 
        public DateTime? DataCriacao { get; set; } 
        public DateTime? DataModificacao { get; set; }
        public string? TotalHoras { get; set; }
        public string? Origem { get; set; }
        public string? Status { get; set; }
        public string? Impacto { get; set; }
        public string? Urgencia { get; set; }
        public string? StatusSlaResposta { get; set; }
        public string? StatusSlaSolucao { get; set; }
    }
}

