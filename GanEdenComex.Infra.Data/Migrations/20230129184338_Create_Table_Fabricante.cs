using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableFabricante : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdFabricante",
                table: "Produto",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Fabricante",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomeFabricante = table.Column<string>(name: "Nome_Fabricante", type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fabricante", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produto_IdFabricante",
                table: "Produto",
                column: "IdFabricante");

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Fabricante_IdFabricante",
                table: "Produto",
                column: "IdFabricante",
                principalTable: "Fabricante",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Fabricante_IdFabricante",
                table: "Produto");

            migrationBuilder.DropTable(
                name: "Fabricante");

            migrationBuilder.DropIndex(
                name: "IX_Produto_IdFabricante",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "IdFabricante",
                table: "Produto");
        }
    }
}
