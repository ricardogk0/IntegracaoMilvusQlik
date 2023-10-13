using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace IntegracaoMilvusQlik.Models
{
    [Table("ticket")]
    public class Ticket
    {
        [Key]
        [JsonProperty("id")]
        public int Id;

        [JsonProperty("categoria_primaria")]
        public string? CategoriaPrimaria;

        [JsonProperty("categoria_secundaria")]
        public string? CategoriaSecundaria;

        [JsonProperty("total_avaliacao")]
        public object? TotalAvaliacao;

        [JsonProperty("descricao_avaliacao")]
        public object? DescricaoAvaliacao;

        [JsonProperty("tecnico")]
        public object? Tecnico;

        [JsonProperty("mesa_trabalho")]
        public string? MesaTrabalho;

        [JsonProperty("data_solucao")]
        public object? DataSolucao;

        [JsonProperty("dispositivo_vinculado")]
        public object? DispositivoVinculado;

        [JsonProperty("servico_realizado")]
        public object? ServicoRealizado;

        [JsonProperty("data_agendamento")]
        public object? DataAgendamento;

        [JsonProperty("data_resposta")]
        public object? DataResposta;

        [JsonProperty("equipamento_retirado")]
        public object? EquipamentoRetirado;

        [JsonProperty("material_utilizado")]
        public object? MaterialUtilizado;

        [JsonProperty("setor")]
        public object? Setor;

        [JsonProperty("tipo_ticket")]
        public object? TipoTicket;

        [JsonProperty("prioridade")]
        public string? Prioridade;

        [JsonProperty("codigo")]
        public int? Codigo;

        [JsonProperty("cliente")]
        public string? Cliente;

        [JsonProperty("cliente_token")]
        public string? ClienteToken;

        [JsonProperty("assunto")]
        public string? Assunto;

        [JsonProperty("descricao")]
        public string? Descricao;

        [JsonProperty("contato")]
        public string? Contato;

        [JsonProperty("email_conferencia")]
        public string? EmailConferencia;

        [JsonProperty("telefone")]
        public string? Telefone;

        [JsonProperty("data_criacao")]
        public DateTime? DataCriacao;

        [JsonProperty("data_modificacao")]
        public string? DataModificacao;

        [JsonProperty("total_horas")]
        public object? TotalHoras;

        [JsonProperty("origem")]
        public string? Origem;

        [JsonProperty("status")]
        public string? Status;

        [JsonProperty("impacto")]
        public string? Impacto;

        [JsonProperty("urgencia")]
        public string? Urgencia;

        [JsonProperty("ultima_log")]
        public object? UltimaLog;

        [JsonProperty("sla")]
        public Sla? Sla;

        [JsonProperty("status_sla_resposta")]
        public string? StatusSlaResposta;

        [JsonProperty("status_sla_solucao")]
        public string? StatusSlaSolucao;
    }
}

