using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDocumentoImportacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_DocumentoImportacao_IdProcesso",
                table: "DocumentoImportacao",
                column: "IdProcesso");

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentoImportacao_ProcessoImportacao_IdProcesso",
                table: "DocumentoImportacao",
                column: "IdProcesso",
                principalTable: "ProcessoImportacao",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DocumentoImportacao_ProcessoImportacao_IdProcesso",
                table: "DocumentoImportacao");

            migrationBuilder.DropIndex(
                name: "IX_DocumentoImportacao_IdProcesso",
                table: "DocumentoImportacao");
        }
    }
}
