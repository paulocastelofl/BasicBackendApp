using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateTableEmpresa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Despachante",
                table: "Empresa",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Exportador",
                table: "Empresa",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Importador",
                table: "Empresa",
                type: "boolean",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Despachante",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "Exportador",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "Importador",
                table: "Empresa");
        }
    }
}
