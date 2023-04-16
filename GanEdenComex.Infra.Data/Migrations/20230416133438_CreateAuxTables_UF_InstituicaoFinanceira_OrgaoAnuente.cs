using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateAuxTablesUFInstituicaoFinanceiraOrgaoAnuente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InstituicaoFinanceira",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "text", nullable: true),
                    codigo = table.Column<string>(type: "text", nullable: true),
                    dtModificacao = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstituicaoFinanceira", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrgaoAnuente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CNPJ = table.Column<string>(type: "text", nullable: true),
                    nome = table.Column<string>(type: "text", nullable: true),
                    codigo = table.Column<string>(type: "text", nullable: true),
                    dtModificacao = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrgaoAnuente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Uf",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "text", nullable: true),
                    codigo = table.Column<string>(type: "text", nullable: true),
                    dtModificacao = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uf", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InstituicaoFinanceira");

            migrationBuilder.DropTable(
                name: "OrgaoAnuente");

            migrationBuilder.DropTable(
                name: "Uf");
        }
    }
}
