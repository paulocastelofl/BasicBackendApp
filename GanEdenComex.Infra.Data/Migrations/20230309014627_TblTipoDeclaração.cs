using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class TblTipoDeclaração : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoDeclaracao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    saidaEntreposto = table.Column<bool>(type: "boolean", nullable: true),
                    entradaEntreposto = table.Column<bool>(type: "boolean", nullable: true),
                    admissaoTemporaria = table.Column<bool>(type: "boolean", nullable: true),
                    recolheAntidumpingRegistro = table.Column<bool>(type: "boolean", nullable: true),
                    entradaEizof = table.Column<bool>(type: "boolean", nullable: true),
                    nome = table.Column<string>(type: "text", nullable: true),
                    codigo = table.Column<string>(type: "text", nullable: true),
                    dtModificacao = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDeclaracao", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TipoDeclaracao");
        }
    }
}
