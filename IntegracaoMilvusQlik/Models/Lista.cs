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
        [Column("total_avaliacao")]
        public string? TotalAvaliacao { get; set; }

        [JsonProperty("descricao_avaliacao")]
        [Column("descricao_avaliacao")]
        public string? DescricaoAvaliacao { get; set; }

        [JsonProperty("tecnico")]
        [Column("tecnico")]
        public string? Tecnico { get; set; }

        [JsonProperty("mesa_trabalho")]
        [Column("mesa_trabalho")]
        public string? MesaTrabalho { get; set; }

        [JsonProperty("data_solucao")]
        [Column("data_solucao")]
        public DateTime? DataSolucao { get; set; }

        [JsonProperty("servico_realizado")]
        [Column("servico_realizado")]
        public string? ServicoRealizado { get; set; }

        [JsonProperty("data_agendamento")]
        [Column("data_agendamento")]
        public DateTime? DataAgendamento { get; set; }

        [JsonProperty("data_resposta")]
        [Column("data_resposta")]
        public DateTime? DataResposta { get; set; }

        [JsonProperty("equipamento_retirado")]
        [Column("equipamento_retirado")]
        public string? EquipamentoRetirado { get; set; }

        [JsonProperty("material_utilizado")]
        [Column("material_utilizado")]
        public string? MaterialUtilizado { get; set; }

        [JsonProperty("setor")]
        [Column("setor")]
        public string? Setor { get; set; }

        [JsonProperty("tipo_ticket")]
        [Column("tipo_ticket")]
        public string? TipoTicket { get; set; }

        [JsonProperty("prioridade")]
        [Column("prioridade")]
        public string? Prioridade { get; set; }

        [JsonProperty("codigo")]
        [Column("codigo")]
        public int? Codigo { get; set; }

        [JsonProperty("cliente")]
        [Column("cliente")]
        public string? Cliente { get; set; }

        [JsonProperty("cliente_token")]
        [Column("cliente_token")]
        public string? ClienteToken { get; set; }

        [JsonProperty("assunto")]
        [Column("assunto")]
        public string? Assunto { get; set; }

        [JsonProperty("descricao")]
        [Column("descricao")]
        public string? Descricao { get; set; }

        [JsonProperty("contato")]
        [Column("contato")]
        public string? Contato { get; set; }

        [JsonProperty("email_conferencia")]
        [Column("email_conferencia")]
        public string? EmailConferencia { get; set; }

        [JsonProperty("telefone")]
        [Column("telefone")]
        public string? Telefone { get; set; } 

        [JsonProperty("data_criacao")]
        [Column("data_criacao")]
        public DateTime? DataCriacao { get; set; } 

        [JsonProperty("data_modificacao")]
        [Column("data_modificacao")]
        public DateTime? DataModificacao { get; set; }

        [JsonProperty("total_horas")]
        [Column("total_horas")]
        public string? TotalHoras { get; set; }

        [JsonProperty("origem")]
        [Column("origem")]
        public string? Origem { get; set; }

        [JsonProperty("status")]
        [Column("status")]
        public string? Status { get; set; }

        [JsonProperty("impacto")]
        [Column("impacto")]
        public string? Impacto { get; set; }

        [JsonProperty("urgencia")]
        [Column("urgencia")]
        public string? Urgencia { get; set; }

        [JsonProperty("status_sla_resposta")]
        [Column("status_sla_resposta")]
        public string? StatusSlaResposta { get; set; }

        [JsonProperty("status_sla_solucao")]
        [Column("status_sla_solucao")]
        public string? StatusSlaSolucao { get; set; }
    }
}
