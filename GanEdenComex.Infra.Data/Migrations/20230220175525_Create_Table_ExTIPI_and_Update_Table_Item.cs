using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableExTIPIandUpdateTableItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdExTarifario",
                table: "Item",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "extarifarioId",
                table: "Item",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ExTIPI",
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
                    table.PrimaryKey("PK_ExTIPI", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Item_extarifarioId",
                table: "Item",
                column: "extarifarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_ExTarifario_extarifarioId",
                table: "Item",
                column: "extarifarioId",
                principalTable: "ExTarifario",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_ExTarifario_extarifarioId",
                table: "Item");

            migrationBuilder.DropTable(
                name: "ExTIPI");

            migrationBuilder.DropIndex(
                name: "IX_Item_extarifarioId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "IdExTarifario",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "extarifarioId",
                table: "Item");
        }
    }
}
