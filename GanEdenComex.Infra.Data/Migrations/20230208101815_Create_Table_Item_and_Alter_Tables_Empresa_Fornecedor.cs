using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableItemandAlterTablesEmpresaFornecedor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CodigoInterno",
                table: "Fornecedor",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdPais",
                table: "Fornecedor",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "AprovaRegistroDI",
                table: "Empresa",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AtividadeEconomica",
                table: "Empresa",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "AtualizarFornecedoresFabricantes",
                table: "Empresa",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "AtualizarItens",
                table: "Empresa",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CNAE",
                table: "Empresa",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "CadastroDeFornecedoresFabricantes",
                table: "Empresa",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "CadastroDeItens",
                table: "Empresa",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CentroDeCusto",
                table: "Empresa",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ControlarCEMercantes",
                table: "Empresa",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ControlarCambio",
                table: "Empresa",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ControlarDemurrage",
                table: "Empresa",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DespachantePadrao",
                table: "Empresa",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NumeroDeCadastroNoMA",
                table: "Empresa",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PrazoDiasCEMercanteCritico",
                table: "Empresa",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Segurado",
                table: "Empresa",
                type: "boolean",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PartNumber = table.Column<string>(type: "text", nullable: true),
                    CodigoInterno = table.Column<int>(type: "integer", nullable: true),
                    UnidadeOrganizacional = table.Column<string>(type: "text", nullable: true),
                    DescricaoDetalhada = table.Column<string>(type: "text", nullable: true),
                    DescricaoNFE = table.Column<string>(type: "text", nullable: true),
                    IdFornecedor = table.Column<int>(type: "integer", nullable: true),
                    IdNCM = table.Column<int>(type: "integer", nullable: true),
                    IdEmpresa = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Item_Empresa_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Item_Fornecedor_IdFornecedor",
                        column: x => x.IdFornecedor,
                        principalTable: "Fornecedor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Item_NCM_IdNCM",
                        column: x => x.IdNCM,
                        principalTable: "NCM",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedor_IdPais",
                table: "Fornecedor",
                column: "IdPais");

            migrationBuilder.CreateIndex(
                name: "IX_Item_IdEmpresa",
                table: "Item",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_Item_IdFornecedor",
                table: "Item",
                column: "IdFornecedor");

            migrationBuilder.CreateIndex(
                name: "IX_Item_IdNCM",
                table: "Item",
                column: "IdNCM");

            migrationBuilder.AddForeignKey(
                name: "FK_Fornecedor_Pais_IdPais",
                table: "Fornecedor",
                column: "IdPais",
                principalTable: "Pais",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fornecedor_Pais_IdPais",
                table: "Fornecedor");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Fornecedor_IdPais",
                table: "Fornecedor");

            migrationBuilder.DropColumn(
                name: "CodigoInterno",
                table: "Fornecedor");

            migrationBuilder.DropColumn(
                name: "IdPais",
                table: "Fornecedor");

            migrationBuilder.DropColumn(
                name: "AprovaRegistroDI",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "AtividadeEconomica",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "AtualizarFornecedoresFabricantes",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "AtualizarItens",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "CNAE",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "CadastroDeFornecedoresFabricantes",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "CadastroDeItens",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "CentroDeCusto",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "ControlarCEMercantes",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "ControlarCambio",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "ControlarDemurrage",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "DespachantePadrao",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "NumeroDeCadastroNoMA",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "PrazoDiasCEMercanteCritico",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "Segurado",
                table: "Empresa");
        }
    }
}
