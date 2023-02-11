using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AlterTableItemandProduto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tipo_De_Emabalagem",
                table: "Produto",
                newName: "Tipo_De_Embalagem");

            migrationBuilder.AddColumn<double>(
                name: "AliquotaCOFINS",
                table: "Item",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "AliquotaII",
                table: "Item",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "AliquotaIPI",
                table: "Item",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "AliquotaPIS",
                table: "Item",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescricaoNALADI",
                table: "Item",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescricaoProdutoSuframa",
                table: "Item",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DetalheProdutoSuframa",
                table: "Item",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NALADI",
                table: "Item",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProdutoSuframa",
                table: "Item",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoProdutoSuframa",
                table: "Item",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AliquotaCOFINS",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "AliquotaII",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "AliquotaIPI",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "AliquotaPIS",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "DescricaoNALADI",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "DescricaoProdutoSuframa",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "DetalheProdutoSuframa",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "NALADI",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "ProdutoSuframa",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "TipoProdutoSuframa",
                table: "Item");

            migrationBuilder.RenameColumn(
                name: "Tipo_De_Embalagem",
                table: "Produto",
                newName: "Tipo_De_Emabalagem");
        }
    }
}
