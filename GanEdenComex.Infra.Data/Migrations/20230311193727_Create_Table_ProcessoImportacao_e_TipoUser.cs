using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableProcessoImportacaoeTipoUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProcessoImportacao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdDespanchante = table.Column<int>(type: "integer", nullable: true),
                    IdDespachantePonta = table.Column<int>(type: "integer", nullable: true),
                    Codigo = table.Column<string>(type: "text", nullable: true),
                    CentroDeCusto = table.Column<string>(type: "text", nullable: true),
                    DtCriacao = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DtModificacao = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DtUltimoEvento = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UltimoEvento = table.Column<string>(type: "text", nullable: true),
                    TipoDeDeclaracao = table.Column<string>(type: "text", nullable: true),
                    IdPais = table.Column<int>(type: "integer", nullable: true),
                    IdModal = table.Column<int>(type: "integer", nullable: true),
                    IdUrfdeChegada = table.Column<int>(type: "integer", nullable: true),
                    IdUrfdeDespacho = table.Column<int>(type: "integer", nullable: true),
                    TipoDeConsignatario = table.Column<string>(type: "text", nullable: true),
                    ModalidadeDeDespacho = table.Column<string>(type: "text", nullable: true),
                    NecessidadeImportador = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IdAnalistaImportador = table.Column<int>(type: "integer", nullable: true),
                    IdAnalistaDespachante = table.Column<int>(type: "integer", nullable: true),
                    OperacaoFundap = table.Column<bool>(type: "boolean", nullable: true),
                    ProcessoCritico = table.Column<bool>(type: "boolean", nullable: true),
                    InformacoesAdicionais = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessoImportacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProcessoImportacao_Modal_IdModal",
                        column: x => x.IdModal,
                        principalTable: "Modal",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProcessoImportacao_Pais_IdPais",
                        column: x => x.IdPais,
                        principalTable: "Pais",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TipoUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdUser = table.Column<int>(type: "integer", nullable: true),
                    nome = table.Column<string>(type: "text", nullable: true),
                    codigo = table.Column<string>(type: "text", nullable: true),
                    dtModificacao = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TipoUser_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProcessoImportacao_IdModal",
                table: "ProcessoImportacao",
                column: "IdModal");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessoImportacao_IdPais",
                table: "ProcessoImportacao",
                column: "IdPais");

            migrationBuilder.CreateIndex(
                name: "IX_TipoUser_IdUser",
                table: "TipoUser",
                column: "IdUser");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProcessoImportacao");

            migrationBuilder.DropTable(
                name: "TipoUser");
        }
    }
}
