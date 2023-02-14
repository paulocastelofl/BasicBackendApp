using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AlterTableItemandEmpresa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AnoExTIPI",
                table: "Item",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AnoExTarifario",
                table: "Item",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AtoExTIPI",
                table: "Item",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AtoExTarifario",
                table: "Item",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CodigoExTIPI",
                table: "Item",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CodigoExTarifario",
                table: "Item",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Destaque",
                table: "Item",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrgaoExTIPI",
                table: "Item",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrgaoExTarifario",
                table: "Item",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoExTIPI",
                table: "Item",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoExTarifario",
                table: "Item",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LimiteDeValorFOB",
                table: "Empresa",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnoExTIPI",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "AnoExTarifario",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "AtoExTIPI",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "AtoExTarifario",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "CodigoExTIPI",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "CodigoExTarifario",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Destaque",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "OrgaoExTIPI",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "OrgaoExTarifario",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "TipoExTIPI",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "TipoExTarifario",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "LimiteDeValorFOB",
                table: "Empresa");
        }
    }
}
