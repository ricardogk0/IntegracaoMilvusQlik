using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace IntegracaoMilvusQlik.Migrations
{
    /// <inheritdoc />
    public partial class initial1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "lista",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    categoria_primaria = table.Column<string>(type: "text", nullable: true),
                    categoria_secundaria = table.Column<string>(type: "text", nullable: true),
                    TotalAvaliacao = table.Column<string>(type: "text", nullable: true),
                    DescricaoAvaliacao = table.Column<string>(type: "text", nullable: true),
                    Tecnico = table.Column<string>(type: "text", nullable: true),
                    MesaTrabalho = table.Column<string>(type: "text", nullable: true),
                    DataSolucao = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DispositivoVinculado = table.Column<string>(type: "text", nullable: true),
                    ServicoRealizado = table.Column<string>(type: "text", nullable: true),
                    DataAgendamento = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DataResposta = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    EquipamentoRetirado = table.Column<string>(type: "text", nullable: true),
                    MaterialUtilizado = table.Column<string>(type: "text", nullable: true),
                    Setor = table.Column<string>(type: "text", nullable: true),
                    TipoTicket = table.Column<string>(type: "text", nullable: true),
                    Prioridade = table.Column<string>(type: "text", nullable: true),
                    Codigo = table.Column<int>(type: "integer", nullable: true),
                    Cliente = table.Column<string>(type: "text", nullable: true),
                    ClienteToken = table.Column<string>(type: "text", nullable: true),
                    Assunto = table.Column<string>(type: "text", nullable: true),
                    Descricao = table.Column<string>(type: "text", nullable: true),
                    Contato = table.Column<string>(type: "text", nullable: true),
                    EmailConferencia = table.Column<string>(type: "text", nullable: true),
                    Telefone = table.Column<string>(type: "text", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    TotalHoras = table.Column<string>(type: "text", nullable: true),
                    Origem = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: true),
                    Impacto = table.Column<string>(type: "text", nullable: true),
                    Urgencia = table.Column<string>(type: "text", nullable: true),
                    StatusSlaResposta = table.Column<string>(type: "text", nullable: true),
                    StatusSlaSolucao = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lista", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "lista");
        }
    }
}
