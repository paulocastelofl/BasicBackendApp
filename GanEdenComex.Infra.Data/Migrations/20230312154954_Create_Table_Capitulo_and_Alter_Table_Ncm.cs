using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableCapituloandAlterTableNcm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdCapitulo",
                table: "Ncm",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdEmpresa",
                table: "MatrizTributacao",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Capitulo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VlIi = table.Column<double>(type: "double precision", nullable: true),
                    VlIiMercosul = table.Column<double>(type: "double precision", nullable: true),
                    VlIpi = table.Column<double>(type: "double precision", nullable: true),
                    VlPis = table.Column<double>(type: "double precision", nullable: true),
                    VlCofins = table.Column<double>(type: "double precision", nullable: true),
                    dtAtualizacao = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    nome = table.Column<string>(type: "text", nullable: true),
                    codigo = table.Column<string>(type: "text", nullable: true),
                    dtModificacao = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Capitulo", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ncm_IdCapitulo",
                table: "Ncm",
                column: "IdCapitulo");

            migrationBuilder.CreateIndex(
                name: "IX_MatrizTributacao_IdEmpresa",
                table: "MatrizTributacao",
                column: "IdEmpresa");

            migrationBuilder.AddForeignKey(
                name: "FK_MatrizTributacao_Empresa_IdEmpresa",
                table: "MatrizTributacao",
                column: "IdEmpresa",
                principalTable: "Empresa",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ncm_Capitulo_IdCapitulo",
                table: "Ncm",
                column: "IdCapitulo",
                principalTable: "Capitulo",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MatrizTributacao_Empresa_IdEmpresa",
                table: "MatrizTributacao");

            migrationBuilder.DropForeignKey(
                name: "FK_Ncm_Capitulo_IdCapitulo",
                table: "Ncm");

            migrationBuilder.DropTable(
                name: "Capitulo");

            migrationBuilder.DropIndex(
                name: "IX_Ncm_IdCapitulo",
                table: "Ncm");

            migrationBuilder.DropIndex(
                name: "IX_MatrizTributacao_IdEmpresa",
                table: "MatrizTributacao");

            migrationBuilder.DropColumn(
                name: "IdCapitulo",
                table: "Ncm");

            migrationBuilder.DropColumn(
                name: "IdEmpresa",
                table: "MatrizTributacao");
        }
    }
}
