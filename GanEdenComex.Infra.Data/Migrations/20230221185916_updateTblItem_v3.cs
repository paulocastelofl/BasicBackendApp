using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateTblItemv3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "codigoInterno",
                table: "Item",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "descricaoItemNfe",
                table: "Item",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "unidadeOrganizacional",
                table: "Item",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "codigoInterno",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "descricaoItemNfe",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "unidadeOrganizacional",
                table: "Item");
        }
    }
}
