using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableExTarifarioandUpdateTableItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdNaladi",
                table: "Item",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "naladiId",
                table: "Item",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ExTarifario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    codigo = table.Column<string>(type: "text", nullable: true),
                    orgao = table.Column<string>(type: "text", nullable: true),
                    ato = table.Column<string>(type: "text", nullable: true),
                    ano = table.Column<string>(type: "text", nullable: true),
                    dtModificacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExTarifario", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Item_naladiId",
                table: "Item",
                column: "naladiId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Naladi_naladiId",
                table: "Item",
                column: "naladiId",
                principalTable: "Naladi",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Naladi_naladiId",
                table: "Item");

            migrationBuilder.DropTable(
                name: "ExTarifario");

            migrationBuilder.DropIndex(
                name: "IX_Item_naladiId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "IdNaladi",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "naladiId",
                table: "Item");
        }
    }
}
