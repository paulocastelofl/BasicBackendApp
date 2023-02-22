using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateTblItemv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Empresa_IdEmpresa",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_ExTIPI_extipiId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_ExTarifario_extarifarioId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Naladi_naladiId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Ncm_IdNCM",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Unidade_unidadeId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_extarifarioId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_extipiId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_IdEmpresa",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_IdNCM",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_naladiId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_unidadeId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "DescricaoDetalhada",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "DescricaoNFE",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "DescricaoProdutoSuframa",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "IdEmpresa",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "IdExTIPI",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "IdExTarifario",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "IdNCM",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "IdNaladi",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "IdUnidade",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "UnidadeOrganizacional",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "extarifarioId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "extipiId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "naladiId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "unidadeId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "vlCra",
                table: "Item");

            migrationBuilder.RenameColumn(
                name: "ProdutoSuframa",
                table: "Item",
                newName: "produtoSuframa");

            migrationBuilder.RenameColumn(
                name: "PartNumber",
                table: "Item",
                newName: "partNumber");

            migrationBuilder.RenameColumn(
                name: "AliquotaPIS",
                table: "Item",
                newName: "aliquotaPis");

            migrationBuilder.RenameColumn(
                name: "AliquotaIPI",
                table: "Item",
                newName: "aliquotaIpi");

            migrationBuilder.RenameColumn(
                name: "AliquotaII",
                table: "Item",
                newName: "aliquotaIi");

            migrationBuilder.RenameColumn(
                name: "AliquotaCOFINS",
                table: "Item",
                newName: "aliquotaCofins");

            migrationBuilder.RenameColumn(
                name: "tratamentoAdministrativo",
                table: "Item",
                newName: "unidade");

            migrationBuilder.RenameColumn(
                name: "tipoProduto",
                table: "Item",
                newName: "ncm");

            migrationBuilder.RenameColumn(
                name: "partNumberInterno",
                table: "Item",
                newName: "descricao");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "produtoSuframa",
                table: "Item",
                newName: "ProdutoSuframa");

            migrationBuilder.RenameColumn(
                name: "partNumber",
                table: "Item",
                newName: "PartNumber");

            migrationBuilder.RenameColumn(
                name: "aliquotaPis",
                table: "Item",
                newName: "AliquotaPIS");

            migrationBuilder.RenameColumn(
                name: "aliquotaIpi",
                table: "Item",
                newName: "AliquotaIPI");

            migrationBuilder.RenameColumn(
                name: "aliquotaIi",
                table: "Item",
                newName: "AliquotaII");

            migrationBuilder.RenameColumn(
                name: "aliquotaCofins",
                table: "Item",
                newName: "AliquotaCOFINS");

            migrationBuilder.RenameColumn(
                name: "unidade",
                table: "Item",
                newName: "tratamentoAdministrativo");

            migrationBuilder.RenameColumn(
                name: "ncm",
                table: "Item",
                newName: "tipoProduto");

            migrationBuilder.RenameColumn(
                name: "descricao",
                table: "Item",
                newName: "partNumberInterno");

            migrationBuilder.AddColumn<string>(
                name: "DescricaoDetalhada",
                table: "Item",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescricaoNFE",
                table: "Item",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescricaoProdutoSuframa",
                table: "Item",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdEmpresa",
                table: "Item",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdExTIPI",
                table: "Item",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdExTarifario",
                table: "Item",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdNCM",
                table: "Item",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdNaladi",
                table: "Item",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdUnidade",
                table: "Item",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UnidadeOrganizacional",
                table: "Item",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "extarifarioId",
                table: "Item",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "extipiId",
                table: "Item",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "naladiId",
                table: "Item",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "unidadeId",
                table: "Item",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "vlCra",
                table: "Item",
                type: "double precision",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Item_extarifarioId",
                table: "Item",
                column: "extarifarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_extipiId",
                table: "Item",
                column: "extipiId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_IdEmpresa",
                table: "Item",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_Item_IdNCM",
                table: "Item",
                column: "IdNCM");

            migrationBuilder.CreateIndex(
                name: "IX_Item_naladiId",
                table: "Item",
                column: "naladiId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_unidadeId",
                table: "Item",
                column: "unidadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Empresa_IdEmpresa",
                table: "Item",
                column: "IdEmpresa",
                principalTable: "Empresa",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_ExTIPI_extipiId",
                table: "Item",
                column: "extipiId",
                principalTable: "ExTIPI",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_ExTarifario_extarifarioId",
                table: "Item",
                column: "extarifarioId",
                principalTable: "ExTarifario",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Naladi_naladiId",
                table: "Item",
                column: "naladiId",
                principalTable: "Naladi",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Ncm_IdNCM",
                table: "Item",
                column: "IdNCM",
                principalTable: "Ncm",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Unidade_unidadeId",
                table: "Item",
                column: "unidadeId",
                principalTable: "Unidade",
                principalColumn: "Id");
        }
    }
}
