using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateTableNcm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ncm_Unidade_unidadeId",
                table: "Ncm");

            migrationBuilder.DropIndex(
                name: "IX_Ncm_unidadeId",
                table: "Ncm");

            migrationBuilder.DropColumn(
                name: "unidadeId",
                table: "Ncm");

            migrationBuilder.RenameColumn(
                name: "vlPis",
                table: "Ncm",
                newName: "VlPis");

            migrationBuilder.RenameColumn(
                name: "vlIpi",
                table: "Ncm",
                newName: "VlIpi");

            migrationBuilder.RenameColumn(
                name: "vlIiMercosul",
                table: "Ncm",
                newName: "VlIiMercosul");

            migrationBuilder.RenameColumn(
                name: "vlIi",
                table: "Ncm",
                newName: "VlIi");

            migrationBuilder.RenameColumn(
                name: "vlCofins",
                table: "Ncm",
                newName: "VlCofins");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Ncm",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "dtModificacao",
                table: "Ncm",
                newName: "DtModificacao");

            migrationBuilder.RenameColumn(
                name: "dtAtualizacao",
                table: "Ncm",
                newName: "DtAtualizacao");

            migrationBuilder.RenameColumn(
                name: "codigo",
                table: "Ncm",
                newName: "Codigo");

            migrationBuilder.CreateIndex(
                name: "IX_Ncm_IdUnidade",
                table: "Ncm",
                column: "IdUnidade");

            migrationBuilder.AddForeignKey(
                name: "FK_Ncm_Unidade_IdUnidade",
                table: "Ncm",
                column: "IdUnidade",
                principalTable: "Unidade",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ncm_Unidade_IdUnidade",
                table: "Ncm");

            migrationBuilder.DropIndex(
                name: "IX_Ncm_IdUnidade",
                table: "Ncm");

            migrationBuilder.RenameColumn(
                name: "VlPis",
                table: "Ncm",
                newName: "vlPis");

            migrationBuilder.RenameColumn(
                name: "VlIpi",
                table: "Ncm",
                newName: "vlIpi");

            migrationBuilder.RenameColumn(
                name: "VlIiMercosul",
                table: "Ncm",
                newName: "vlIiMercosul");

            migrationBuilder.RenameColumn(
                name: "VlIi",
                table: "Ncm",
                newName: "vlIi");

            migrationBuilder.RenameColumn(
                name: "VlCofins",
                table: "Ncm",
                newName: "vlCofins");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Ncm",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "DtModificacao",
                table: "Ncm",
                newName: "dtModificacao");

            migrationBuilder.RenameColumn(
                name: "DtAtualizacao",
                table: "Ncm",
                newName: "dtAtualizacao");

            migrationBuilder.RenameColumn(
                name: "Codigo",
                table: "Ncm",
                newName: "codigo");

            migrationBuilder.AddColumn<int>(
                name: "unidadeId",
                table: "Ncm",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ncm_unidadeId",
                table: "Ncm",
                column: "unidadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ncm_Unidade_unidadeId",
                table: "Ncm",
                column: "unidadeId",
                principalTable: "Unidade",
                principalColumn: "Id");
        }
    }
}
