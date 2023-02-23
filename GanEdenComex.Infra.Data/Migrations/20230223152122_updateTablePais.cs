using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateTablePais : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome_Pais",
                table: "Pais",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "Codigo_Pais",
                table: "Pais",
                newName: "Iso3166_3");

            migrationBuilder.AddColumn<string>(
                name: "CdNfe",
                table: "Pais",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Codigo",
                table: "Pais",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DtModificacao",
                table: "Pais",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Iso3166",
                table: "Pais",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ordem",
                table: "Pais",
                type: "integer",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CdNfe",
                table: "Pais");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Pais");

            migrationBuilder.DropColumn(
                name: "DtModificacao",
                table: "Pais");

            migrationBuilder.DropColumn(
                name: "Iso3166",
                table: "Pais");

            migrationBuilder.DropColumn(
                name: "Ordem",
                table: "Pais");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Pais",
                newName: "Nome_Pais");

            migrationBuilder.RenameColumn(
                name: "Iso3166_3",
                table: "Pais",
                newName: "Codigo_Pais");
        }
    }
}
