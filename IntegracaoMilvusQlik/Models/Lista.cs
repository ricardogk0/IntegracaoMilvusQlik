using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace IntegracaoMilvusQlik.Models
{
    [Table("lista")]
    public class Lista
    {
        [Key]
        [JsonProperty("id")]
        [Column("id")]
        public int Id { get; set; }

        [Column("categoria_primaria")]
        [JsonProperty("categoria_primaria")]
        public string? CategoriaPrimaria { get; set; }

        [Column("categoria_secundaria")]
        [JsonProperty("categoria_secundaria")]
        public string? CategoriaSecundaria { get; set; }

        [JsonProperty("total_avaliacao")]
        public string? TotalAvaliacao { get; set; }

        [JsonProperty("descricao_avaliacao")]
        public string? DescricaoAvaliacao { get; set; }

        [JsonProperty("tecnico")]
        public string? Tecnico { get; set; }

        [JsonProperty("mesa_trabalho")]
        public string? MesaTrabalho { get; set; }

        [JsonProperty("data_solucao")]
        public DateTime? DataSolucao { get; set; }

        [JsonProperty("servico_realizado")]
        public string? ServicoRealizado { get; set; }

        [JsonProperty("data_agendamento")]
        public DateTime? DataAgendamento { get; set; }

        [JsonProperty("data_resposta")]
        public DateTime? DataResposta { get; set; }

        [JsonProperty("equipamento_retirado")]
        public string? EquipamentoRetirado { get; set; }

        [JsonProperty("material_utilizado")]
        public string? MaterialUtilizado { get; set; }

        [JsonProperty("setor")]
        public string? Setor { get; set; }

        [JsonProperty("tipo_ticket")]
        public string? TipoTicket { get; set; }

        [JsonProperty("prioridade")]
        public string? Prioridade { get; set; }

        [JsonProperty("codigo")]
        public int? Codigo { get; set; }

        [JsonProperty("cliente")]
        public string? Cliente { get; set; }

        [JsonProperty("cliente_token")]
        public string? ClienteToken { get; set; }

        [JsonProperty("assunto")]
        public string? Assunto { get; set; }

        [JsonProperty("descricao")]
        public string? Descricao { get; set; }

        [JsonProperty("contato")]
        public string? Contato { get; set; }

        [JsonProperty("email_conferencia")]
        public string? EmailConferencia { get; set; }

        [JsonProperty("telefone")]
        public string? Telefone { get; set; } 

        [JsonProperty("data_criacao")]
        public DateTime? DataCriacao { get; set; } 

        [JsonProperty("data_modificacao")]
        public DateTime? DataModificacao { get; set; }

        [JsonProperty("total_horas")]
        public string? TotalHoras { get; set; }

        [JsonProperty("origem")]
        public string? Origem { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("impacto")]
        public string? Impacto { get; set; }

        [JsonProperty("urgencia")]
        public string? Urgencia { get; set; }

        [JsonProperty("status_sla_resposta")]
        public string? StatusSlaResposta { get; set; }

        [JsonProperty("status_sla_solucao")]
        public string? StatusSlaSolucao { get; set; }
    }
}

