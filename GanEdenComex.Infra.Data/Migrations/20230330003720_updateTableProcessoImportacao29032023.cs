using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateTableProcessoImportacao29032023 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoDeDeclaracao",
                table: "ProcessoImportacao");

            migrationBuilder.AddColumn<int>(
                name: "IdTipoDeDeclaracao",
                table: "ProcessoImportacao",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProcessoImportacao_IdTipoDeDeclaracao",
                table: "ProcessoImportacao",
                column: "IdTipoDeDeclaracao");

            migrationBuilder.AddForeignKey(
                name: "FK_ProcessoImportacao_TipoDeclaracao_IdTipoDeDeclaracao",
                table: "ProcessoImportacao",
                column: "IdTipoDeDeclaracao",
                principalTable: "TipoDeclaracao",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProcessoImportacao_TipoDeclaracao_IdTipoDeDeclaracao",
                table: "ProcessoImportacao");

            migrationBuilder.DropIndex(
                name: "IX_ProcessoImportacao_IdTipoDeDeclaracao",
                table: "ProcessoImportacao");

            migrationBuilder.DropColumn(
                name: "IdTipoDeDeclaracao",
                table: "ProcessoImportacao");

            migrationBuilder.AddColumn<string>(
                name: "TipoDeDeclaracao",
                table: "ProcessoImportacao",
                type: "text",
                nullable: true);
        }
    }
}
