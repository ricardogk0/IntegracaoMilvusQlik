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
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    categoria_primaria = table.Column<string>(type: "text", nullable: true),
                    categoria_secundaria = table.Column<string>(type: "text", nullable: true),
                    total_avaliacao = table.Column<string>(type: "text", nullable: true),
                    descricao_avaliacao = table.Column<string>(type: "text", nullable: true),
                    tecnico = table.Column<string>(type: "text", nullable: true),
                    mesa_trabalho = table.Column<string>(type: "text", nullable: true),
                    data_solucao = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    servico_realizado = table.Column<string>(type: "text", nullable: true),
                    data_agendamento = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    data_resposta = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    equipamento_retirado = table.Column<string>(type: "text", nullable: true),
                    material_utilizado = table.Column<string>(type: "text", nullable: true),
                    setor = table.Column<string>(type: "text", nullable: true),
                    tipo_ticket = table.Column<string>(type: "text", nullable: true),
                    prioridade = table.Column<string>(type: "text", nullable: true),
                    codigo = table.Column<int>(type: "integer", nullable: true),
                    cliente = table.Column<string>(type: "text", nullable: true),
                    cliente_token = table.Column<string>(type: "text", nullable: true),
                    assunto = table.Column<string>(type: "text", nullable: true),
                    descricao = table.Column<string>(type: "text", nullable: true),
                    contato = table.Column<string>(type: "text", nullable: true),
                    email_conferencia = table.Column<string>(type: "text", nullable: true),
                    telefone = table.Column<string>(type: "text", nullable: true),
                    data_criacao = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    data_modificacao = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    total_horas = table.Column<string>(type: "text", nullable: true),
                    origem = table.Column<string>(type: "text", nullable: true),
                    status = table.Column<string>(type: "text", nullable: true),
                    impacto = table.Column<string>(type: "text", nullable: true),
                    urgencia = table.Column<string>(type: "text", nullable: true),
                    status_sla_resposta = table.Column<string>(type: "text", nullable: true),
                    status_sla_solucao = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lista", x => x.id);
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
