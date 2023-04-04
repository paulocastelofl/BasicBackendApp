using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class TableDocumentoImportacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DocumentoImportacao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Documento = table.Column<string>(type: "text", nullable: true),
                    CaminhoDocumento = table.Column<string>(type: "text", nullable: true),
                    Tipo = table.Column<string>(type: "text", nullable: true),
                    Versao = table.Column<string>(type: "text", nullable: true),
                    Numero = table.Column<string>(type: "text", nullable: true),
                    Recebimento = table.Column<string>(type: "text", nullable: true),
                    DtCriacao = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IdProcesso = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentoImportacao", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProcessoImportacao_IdDespachantePonta",
                table: "ProcessoImportacao",
                column: "IdDespachantePonta");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessoImportacao_IdDespanchante",
                table: "ProcessoImportacao",
                column: "IdDespanchante");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessoImportacao_IdEmpresa",
                table: "ProcessoImportacao",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessoImportacao_IdUrfdeChegada",
                table: "ProcessoImportacao",
                column: "IdUrfdeChegada");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessoImportacao_IdUrfdeDespacho",
                table: "ProcessoImportacao",
                column: "IdUrfdeDespacho");

            migrationBuilder.AddForeignKey(
                name: "FK_ProcessoImportacao_Empresa_IdDespachantePonta",
                table: "ProcessoImportacao",
                column: "IdDespachantePonta",
                principalTable: "Empresa",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProcessoImportacao_Empresa_IdDespanchante",
                table: "ProcessoImportacao",
                column: "IdDespanchante",
                principalTable: "Empresa",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProcessoImportacao_Empresa_IdEmpresa",
                table: "ProcessoImportacao",
                column: "IdEmpresa",
                principalTable: "Empresa",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProcessoImportacao_Urf_IdUrfdeChegada",
                table: "ProcessoImportacao",
                column: "IdUrfdeChegada",
                principalTable: "Urf",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProcessoImportacao_Urf_IdUrfdeDespacho",
                table: "ProcessoImportacao",
                column: "IdUrfdeDespacho",
                principalTable: "Urf",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProcessoImportacao_Empresa_IdDespachantePonta",
                table: "ProcessoImportacao");

            migrationBuilder.DropForeignKey(
                name: "FK_ProcessoImportacao_Empresa_IdDespanchante",
                table: "ProcessoImportacao");

            migrationBuilder.DropForeignKey(
                name: "FK_ProcessoImportacao_Empresa_IdEmpresa",
                table: "ProcessoImportacao");

            migrationBuilder.DropForeignKey(
                name: "FK_ProcessoImportacao_Urf_IdUrfdeChegada",
                table: "ProcessoImportacao");

            migrationBuilder.DropForeignKey(
                name: "FK_ProcessoImportacao_Urf_IdUrfdeDespacho",
                table: "ProcessoImportacao");

            migrationBuilder.DropTable(
                name: "DocumentoImportacao");

            migrationBuilder.DropIndex(
                name: "IX_ProcessoImportacao_IdDespachantePonta",
                table: "ProcessoImportacao");

            migrationBuilder.DropIndex(
                name: "IX_ProcessoImportacao_IdDespanchante",
                table: "ProcessoImportacao");

            migrationBuilder.DropIndex(
                name: "IX_ProcessoImportacao_IdEmpresa",
                table: "ProcessoImportacao");

            migrationBuilder.DropIndex(
                name: "IX_ProcessoImportacao_IdUrfdeChegada",
                table: "ProcessoImportacao");

            migrationBuilder.DropIndex(
                name: "IX_ProcessoImportacao_IdUrfdeDespacho",
                table: "ProcessoImportacao");
        }
    }
}
