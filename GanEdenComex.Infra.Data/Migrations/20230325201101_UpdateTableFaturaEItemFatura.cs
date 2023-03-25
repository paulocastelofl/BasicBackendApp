using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTableFaturaEItemFatura : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fatura",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    dtModificacao = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    dtEmissao = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    numeroFatura = table.Column<string>(type: "text", nullable: true),
                    localCondicao = table.Column<string>(type: "text", nullable: true),
                    IdFornecedor = table.Column<int>(type: "integer", nullable: true),
                    IdMoeda = table.Column<int>(type: "integer", nullable: true),
                    IdIncoterms = table.Column<int>(type: "integer", nullable: true),
                    IdMoedaFrete = table.Column<int>(type: "integer", nullable: true),
                    IdMoedaSeguro = table.Column<int>(type: "integer", nullable: true),
                    IdItemFatura = table.Column<int>(type: "integer", nullable: true),
                    IdModalidadePagamento = table.Column<int>(type: "integer", nullable: true),
                    IdCoberturaCambial = table.Column<int>(type: "integer", nullable: true),
                    IdFundamentoLegal = table.Column<int>(type: "integer", nullable: true),
                    numDiasPagamento = table.Column<int>(type: "integer", nullable: true),
                    valorTotal = table.Column<double>(type: "double precision", nullable: true),
                    pesoLiquido = table.Column<double>(type: "double precision", nullable: true),
                    tipoVinculoFornecedor = table.Column<string>(type: "text", nullable: true),
                    IdProcessoImportacao = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fatura", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fatura_CoberturaCambial_IdCoberturaCambial",
                        column: x => x.IdCoberturaCambial,
                        principalTable: "CoberturaCambial",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Fatura_Fornecedor_IdFornecedor",
                        column: x => x.IdFornecedor,
                        principalTable: "Fornecedor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Fatura_FundamentoLegal_IdFundamentoLegal",
                        column: x => x.IdFundamentoLegal,
                        principalTable: "FundamentoLegal",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Fatura_Incoterms_IdIncoterms",
                        column: x => x.IdIncoterms,
                        principalTable: "Incoterms",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Fatura_ModalidadePagamento_IdModalidadePagamento",
                        column: x => x.IdModalidadePagamento,
                        principalTable: "ModalidadePagamento",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Fatura_ProcessoImportacao_IdProcessoImportacao",
                        column: x => x.IdProcessoImportacao,
                        principalTable: "ProcessoImportacao",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ItemFatura",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdItem = table.Column<int>(type: "integer", nullable: true),
                    IdFatura = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemFatura", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemFatura_Fatura_IdFatura",
                        column: x => x.IdFatura,
                        principalTable: "Fatura",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemFatura_Item_IdItem",
                        column: x => x.IdItem,
                        principalTable: "Item",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fatura_IdCoberturaCambial",
                table: "Fatura",
                column: "IdCoberturaCambial");

            migrationBuilder.CreateIndex(
                name: "IX_Fatura_IdFornecedor",
                table: "Fatura",
                column: "IdFornecedor");

            migrationBuilder.CreateIndex(
                name: "IX_Fatura_IdFundamentoLegal",
                table: "Fatura",
                column: "IdFundamentoLegal");

            migrationBuilder.CreateIndex(
                name: "IX_Fatura_IdIncoterms",
                table: "Fatura",
                column: "IdIncoterms");

            migrationBuilder.CreateIndex(
                name: "IX_Fatura_IdModalidadePagamento",
                table: "Fatura",
                column: "IdModalidadePagamento");

            migrationBuilder.CreateIndex(
                name: "IX_Fatura_IdProcessoImportacao",
                table: "Fatura",
                column: "IdProcessoImportacao");

            migrationBuilder.CreateIndex(
                name: "IX_ItemFatura_IdFatura",
                table: "ItemFatura",
                column: "IdFatura");

            migrationBuilder.CreateIndex(
                name: "IX_ItemFatura_IdItem",
                table: "ItemFatura",
                column: "IdItem");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemFatura");

            migrationBuilder.DropTable(
                name: "Fatura");
        }
    }
}
