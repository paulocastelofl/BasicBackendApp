using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTableItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnoExTIPI",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "AnoExTarifario",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "AtoExTIPI",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "AtoExTarifario",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "CodigoExTIPI",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "CodigoExTarifario",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "DescricaoNALADI",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Destaque",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "DetalheProdutoSuframa",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "OrgaoExTIPI",
                table: "Item");

            migrationBuilder.RenameColumn(
                name: "TipoProdutoSuframa",
                table: "Item",
                newName: "tratamentoAdministrativo");

            migrationBuilder.RenameColumn(
                name: "TipoExTarifario",
                table: "Item",
                newName: "tipoProduto");

            migrationBuilder.RenameColumn(
                name: "TipoExTIPI",
                table: "Item",
                newName: "partNumberInterno");

            migrationBuilder.RenameColumn(
                name: "OrgaoExTarifario",
                table: "Item",
                newName: "detalheNcm");

            migrationBuilder.RenameColumn(
                name: "NALADI",
                table: "Item",
                newName: "unidadeId");

            migrationBuilder.RenameColumn(
                name: "CodigoInterno",
                table: "Item",
                newName: "IdUnidade");

            migrationBuilder.AlterColumn<string>(
                name: "ProdutoSuframa",
                table: "Item",
                type: "text",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "dtModificacao",
                table: "Item",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "vlCra",
                table: "Item",
                type: "double precision",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Item_unidadeId",
                table: "Item",
                column: "unidadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Unidade_unidadeId",
                table: "Item",
                column: "unidadeId",
                principalTable: "Unidade",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Unidade_unidadeId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_unidadeId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "dtModificacao",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "vlCra",
                table: "Item");

            migrationBuilder.RenameColumn(
                name: "unidadeId",
                table: "Item",
                newName: "NALADI");

            migrationBuilder.RenameColumn(
                name: "tratamentoAdministrativo",
                table: "Item",
                newName: "TipoProdutoSuframa");

            migrationBuilder.RenameColumn(
                name: "tipoProduto",
                table: "Item",
                newName: "TipoExTarifario");

            migrationBuilder.RenameColumn(
                name: "partNumberInterno",
                table: "Item",
                newName: "TipoExTIPI");

            migrationBuilder.RenameColumn(
                name: "detalheNcm",
                table: "Item",
                newName: "OrgaoExTarifario");

            migrationBuilder.RenameColumn(
                name: "IdUnidade",
                table: "Item",
                newName: "CodigoInterno");

            migrationBuilder.AlterColumn<int>(
                name: "ProdutoSuframa",
                table: "Item",
                type: "integer",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AnoExTIPI",
                table: "Item",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AnoExTarifario",
                table: "Item",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AtoExTIPI",
                table: "Item",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AtoExTarifario",
                table: "Item",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CodigoExTIPI",
                table: "Item",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CodigoExTarifario",
                table: "Item",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescricaoNALADI",
                table: "Item",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Destaque",
                table: "Item",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DetalheProdutoSuframa",
                table: "Item",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrgaoExTIPI",
                table: "Item",
                type: "text",
                nullable: true);
        }
    }
}
