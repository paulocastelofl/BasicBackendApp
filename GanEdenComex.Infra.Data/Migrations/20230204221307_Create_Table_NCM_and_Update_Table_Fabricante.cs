using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableNCMandUpdateTableFabricante : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "Fabricante",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CEP",
                table: "Fabricante",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Fabricante",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Complemento",
                table: "Fabricante",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Fabricante",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Logradouro",
                table: "Fabricante",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Numero",
                table: "Fabricante",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tipo_Fabricante",
                table: "Fabricante",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "Fabricante");

            migrationBuilder.DropColumn(
                name: "CEP",
                table: "Fabricante");

            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "Fabricante");

            migrationBuilder.DropColumn(
                name: "Complemento",
                table: "Fabricante");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Fabricante");

            migrationBuilder.DropColumn(
                name: "Logradouro",
                table: "Fabricante");

            migrationBuilder.DropColumn(
                name: "Numero",
                table: "Fabricante");

            migrationBuilder.DropColumn(
                name: "Tipo_Fabricante",
                table: "Fabricante");
        }
    }
}
