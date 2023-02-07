using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AlterTableProduto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdNCM",
                table: "Produto",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produto_IdNCM",
                table: "Produto",
                column: "IdNCM");

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_NCM_IdNCM",
                table: "Produto",
                column: "IdNCM",
                principalTable: "NCM",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produto_NCM_IdNCM",
                table: "Produto");

            migrationBuilder.DropIndex(
                name: "IX_Produto_IdNCM",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "IdNCM",
                table: "Produto");
        }
    }
}
