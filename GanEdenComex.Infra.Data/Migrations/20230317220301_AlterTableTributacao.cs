using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AlterTableTributacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "aliquotaIcms",
                table: "Tributacao",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "aliquotaMva",
                table: "Tributacao",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "aliquotaReducao",
                table: "Tributacao",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "coeficienteLei2826",
                table: "Tributacao",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "coeficienteNormal",
                table: "Tributacao",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "aliquotaIcms",
                table: "Tributacao");

            migrationBuilder.DropColumn(
                name: "aliquotaMva",
                table: "Tributacao");

            migrationBuilder.DropColumn(
                name: "aliquotaReducao",
                table: "Tributacao");

            migrationBuilder.DropColumn(
                name: "coeficienteLei2826",
                table: "Tributacao");

            migrationBuilder.DropColumn(
                name: "coeficienteNormal",
                table: "Tributacao");
        }
    }
}
