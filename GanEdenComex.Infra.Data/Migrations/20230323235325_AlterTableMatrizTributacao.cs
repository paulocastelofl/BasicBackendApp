using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AlterTableMatrizTributacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdNcm",
                table: "MatrizTributacao",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MatrizTributacao_IdNcm",
                table: "MatrizTributacao",
                column: "IdNcm");

            migrationBuilder.AddForeignKey(
                name: "FK_MatrizTributacao_Ncm_IdNcm",
                table: "MatrizTributacao",
                column: "IdNcm",
                principalTable: "Ncm",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MatrizTributacao_Ncm_IdNcm",
                table: "MatrizTributacao");

            migrationBuilder.DropIndex(
                name: "IX_MatrizTributacao_IdNcm",
                table: "MatrizTributacao");

            migrationBuilder.DropColumn(
                name: "IdNcm",
                table: "MatrizTributacao");
        }
    }
}
