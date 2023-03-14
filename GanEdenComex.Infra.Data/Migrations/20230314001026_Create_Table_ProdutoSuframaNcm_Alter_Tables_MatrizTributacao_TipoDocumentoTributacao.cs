using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableProdutoSuframaNcmAlterTablesMatrizTributacaoTipoDocumentoTributacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MatrizTributacao_Ncm_IdNcm",
                table: "MatrizTributacao");

            migrationBuilder.DropForeignKey(
                name: "FK_MatrizTributacao_ProdutoSuframa_IdProdutoSuframa",
                table: "MatrizTributacao");

            migrationBuilder.DropForeignKey(
                name: "FK_MatrizTributacao_TipoDoc_IdTipoDoc",
                table: "MatrizTributacao");

            migrationBuilder.DropTable(
                name: "TipoDoc");

            migrationBuilder.DropIndex(
                name: "IX_MatrizTributacao_IdNcm",
                table: "MatrizTributacao");

            migrationBuilder.DropColumn(
                name: "IdNcm",
                table: "MatrizTributacao");

            migrationBuilder.RenameColumn(
                name: "IdTipoDoc",
                table: "MatrizTributacao",
                newName: "IdTipoDocumentoTributacao");

            migrationBuilder.RenameColumn(
                name: "IdProdutoSuframa",
                table: "MatrizTributacao",
                newName: "IdProdutoSuframaNcm");

            migrationBuilder.RenameIndex(
                name: "IX_MatrizTributacao_IdTipoDoc",
                table: "MatrizTributacao",
                newName: "IX_MatrizTributacao_IdTipoDocumentoTributacao");

            migrationBuilder.RenameIndex(
                name: "IX_MatrizTributacao_IdProdutoSuframa",
                table: "MatrizTributacao",
                newName: "IX_MatrizTributacao_IdProdutoSuframaNcm");

            migrationBuilder.CreateTable(
                name: "ProdutoSuframaNcm",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ativo = table.Column<bool>(type: "boolean", nullable: false),
                    IdProdutoSuframa = table.Column<int>(type: "integer", nullable: true),
                    IdNcm = table.Column<int>(type: "integer", nullable: true),
                    IdTipoProduto = table.Column<int>(type: "integer", nullable: true),
                    nome = table.Column<string>(type: "text", nullable: true),
                    codigo = table.Column<string>(type: "text", nullable: true),
                    dtModificacao = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoSuframaNcm", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProdutoSuframaNcm_Ncm_IdNcm",
                        column: x => x.IdNcm,
                        principalTable: "Ncm",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProdutoSuframaNcm_ProdutoSuframa_IdProdutoSuframa",
                        column: x => x.IdProdutoSuframa,
                        principalTable: "ProdutoSuframa",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProdutoSuframaNcm_TipoProduto_IdTipoProduto",
                        column: x => x.IdTipoProduto,
                        principalTable: "TipoProduto",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TipoDocumentoTributacao",
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
                    table.PrimaryKey("PK_TipoDocumentoTributacao", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoSuframaNcm_IdNcm",
                table: "ProdutoSuframaNcm",
                column: "IdNcm");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoSuframaNcm_IdProdutoSuframa",
                table: "ProdutoSuframaNcm",
                column: "IdProdutoSuframa");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoSuframaNcm_IdTipoProduto",
                table: "ProdutoSuframaNcm",
                column: "IdTipoProduto");

            migrationBuilder.AddForeignKey(
                name: "FK_MatrizTributacao_ProdutoSuframaNcm_IdProdutoSuframaNcm",
                table: "MatrizTributacao",
                column: "IdProdutoSuframaNcm",
                principalTable: "ProdutoSuframaNcm",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MatrizTributacao_TipoDocumentoTributacao_IdTipoDocumentoTri~",
                table: "MatrizTributacao",
                column: "IdTipoDocumentoTributacao",
                principalTable: "TipoDocumentoTributacao",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MatrizTributacao_ProdutoSuframaNcm_IdProdutoSuframaNcm",
                table: "MatrizTributacao");

            migrationBuilder.DropForeignKey(
                name: "FK_MatrizTributacao_TipoDocumentoTributacao_IdTipoDocumentoTri~",
                table: "MatrizTributacao");

            migrationBuilder.DropTable(
                name: "ProdutoSuframaNcm");

            migrationBuilder.DropTable(
                name: "TipoDocumentoTributacao");

            migrationBuilder.RenameColumn(
                name: "IdTipoDocumentoTributacao",
                table: "MatrizTributacao",
                newName: "IdTipoDoc");

            migrationBuilder.RenameColumn(
                name: "IdProdutoSuframaNcm",
                table: "MatrizTributacao",
                newName: "IdProdutoSuframa");

            migrationBuilder.RenameIndex(
                name: "IX_MatrizTributacao_IdTipoDocumentoTributacao",
                table: "MatrizTributacao",
                newName: "IX_MatrizTributacao_IdTipoDoc");

            migrationBuilder.RenameIndex(
                name: "IX_MatrizTributacao_IdProdutoSuframaNcm",
                table: "MatrizTributacao",
                newName: "IX_MatrizTributacao_IdProdutoSuframa");

            migrationBuilder.AddColumn<int>(
                name: "IdNcm",
                table: "MatrizTributacao",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TipoDoc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    codigo = table.Column<string>(type: "text", nullable: true),
                    dtModificacao = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    nome = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDoc", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MatrizTributacao_IdNcm",
                table: "MatrizTributacao",
                column: "IdNcm");

            migrationBuilder.AddForeignKey(
                name: "FK_MatrizTributacao_Ncm_IdNcm",
                table: "MatrizTributacao",
                column: "IdNcm",
                principalTable: "Ncm",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MatrizTributacao_ProdutoSuframa_IdProdutoSuframa",
                table: "MatrizTributacao",
                column: "IdProdutoSuframa",
                principalTable: "ProdutoSuframa",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MatrizTributacao_TipoDoc_IdTipoDoc",
                table: "MatrizTributacao",
                column: "IdTipoDoc",
                principalTable: "TipoDoc",
                principalColumn: "Id");
        }
    }
}
