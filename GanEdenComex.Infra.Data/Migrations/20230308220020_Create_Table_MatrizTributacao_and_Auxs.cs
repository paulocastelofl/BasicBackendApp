using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableMatrizTributacaoandAuxs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Destinacao",
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
                    table.PrimaryKey("PK_Destinacao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoDoc",
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
                    table.PrimaryKey("PK_TipoDoc", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tributacao",
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
                    table.PrimaryKey("PK_Tributacao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Utilizacao",
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
                    table.PrimaryKey("PK_Utilizacao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MatrizTributacao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdInscricaoEstadual = table.Column<int>(type: "integer", nullable: true),
                    IdProdutoSuframa = table.Column<int>(type: "integer", nullable: true),
                    IdNcm = table.Column<int>(type: "integer", nullable: true),
                    IdDestinacao = table.Column<int>(type: "integer", nullable: true),
                    IdUtilizacao = table.Column<int>(type: "integer", nullable: true),
                    IdTributacao = table.Column<int>(type: "integer", nullable: true),
                    Cra = table.Column<double>(type: "double precision", nullable: true),
                    IdTipoDoc = table.Column<int>(type: "integer", nullable: true),
                    Decreto = table.Column<string>(type: "text", nullable: true),
                    NumeroDocumento = table.Column<string>(type: "text", nullable: true),
                    InicioVigencia = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    FimVigencia = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatrizTributacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MatrizTributacao_Destinacao_IdDestinacao",
                        column: x => x.IdDestinacao,
                        principalTable: "Destinacao",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MatrizTributacao_InscricaoEstadual_IdInscricaoEstadual",
                        column: x => x.IdInscricaoEstadual,
                        principalTable: "InscricaoEstadual",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MatrizTributacao_Ncm_IdNcm",
                        column: x => x.IdNcm,
                        principalTable: "Ncm",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MatrizTributacao_ProdutoSuframa_IdProdutoSuframa",
                        column: x => x.IdProdutoSuframa,
                        principalTable: "ProdutoSuframa",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MatrizTributacao_TipoDoc_IdTipoDoc",
                        column: x => x.IdTipoDoc,
                        principalTable: "TipoDoc",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MatrizTributacao_Tributacao_IdTributacao",
                        column: x => x.IdTributacao,
                        principalTable: "Tributacao",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MatrizTributacao_Utilizacao_IdUtilizacao",
                        column: x => x.IdUtilizacao,
                        principalTable: "Utilizacao",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_MatrizTributacao_IdDestinacao",
                table: "MatrizTributacao",
                column: "IdDestinacao");

            migrationBuilder.CreateIndex(
                name: "IX_MatrizTributacao_IdInscricaoEstadual",
                table: "MatrizTributacao",
                column: "IdInscricaoEstadual");

            migrationBuilder.CreateIndex(
                name: "IX_MatrizTributacao_IdNcm",
                table: "MatrizTributacao",
                column: "IdNcm");

            migrationBuilder.CreateIndex(
                name: "IX_MatrizTributacao_IdProdutoSuframa",
                table: "MatrizTributacao",
                column: "IdProdutoSuframa");

            migrationBuilder.CreateIndex(
                name: "IX_MatrizTributacao_IdTipoDoc",
                table: "MatrizTributacao",
                column: "IdTipoDoc");

            migrationBuilder.CreateIndex(
                name: "IX_MatrizTributacao_IdTributacao",
                table: "MatrizTributacao",
                column: "IdTributacao");

            migrationBuilder.CreateIndex(
                name: "IX_MatrizTributacao_IdUtilizacao",
                table: "MatrizTributacao",
                column: "IdUtilizacao");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MatrizTributacao");

            migrationBuilder.DropTable(
                name: "Destinacao");

            migrationBuilder.DropTable(
                name: "TipoDoc");

            migrationBuilder.DropTable(
                name: "Tributacao");

            migrationBuilder.DropTable(
                name: "Utilizacao");
        }
    }
}
