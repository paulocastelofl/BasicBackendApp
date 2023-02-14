using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class TblIncotermsv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "codigo",
                table: "Incoterms",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "dtModificacao",
                table: "Incoterms",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nome",
                table: "Incoterms",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "codigo",
                table: "Incoterms");

            migrationBuilder.DropColumn(
                name: "dtModificacao",
                table: "Incoterms");

            migrationBuilder.DropColumn(
                name: "nome",
                table: "Incoterms");
        }
    }
}
