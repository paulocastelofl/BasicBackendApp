using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTableNCM : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ano",
                table: "NCM");

            migrationBuilder.DropColumn(
                name: "Ato_Legal",
                table: "NCM");

            migrationBuilder.DropColumn(
                name: "Codigo_NCM",
                table: "NCM");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "NCM");

            migrationBuilder.RenameColumn(
                name: "Numero",
                table: "NCM",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Descricao_Concatenada",
                table: "NCM",
                newName: "codigo");

            migrationBuilder.RenameColumn(
                name: "Data_Inicio",
                table: "NCM",
                newName: "dtModificacao");

            migrationBuilder.RenameColumn(
                name: "Data_Fim",
                table: "NCM",
                newName: "dtAtualizacao");

            migrationBuilder.AddColumn<int>(
                name: "IdUnidade",
                table: "NCM",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "unidadeId",
                table: "NCM",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "vlCofins",
                table: "NCM",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "vlIi",
                table: "NCM",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "vlIiMercosul",
                table: "NCM",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "vlIpi",
                table: "NCM",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "vlPis",
                table: "NCM",
                type: "double precision",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_NCM_unidadeId",
                table: "NCM",
                column: "unidadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_NCM_Unidade_unidadeId",
                table: "NCM",
                column: "unidadeId",
                principalTable: "Unidade",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NCM_Unidade_unidadeId",
                table: "NCM");

            migrationBuilder.DropIndex(
                name: "IX_NCM_unidadeId",
                table: "NCM");

            migrationBuilder.DropColumn(
                name: "IdUnidade",
                table: "NCM");

            migrationBuilder.DropColumn(
                name: "unidadeId",
                table: "NCM");

            migrationBuilder.DropColumn(
                name: "vlCofins",
                table: "NCM");

            migrationBuilder.DropColumn(
                name: "vlIi",
                table: "NCM");

            migrationBuilder.DropColumn(
                name: "vlIiMercosul",
                table: "NCM");

            migrationBuilder.DropColumn(
                name: "vlIpi",
                table: "NCM");

            migrationBuilder.DropColumn(
                name: "vlPis",
                table: "NCM");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "NCM",
                newName: "Numero");

            migrationBuilder.RenameColumn(
                name: "dtModificacao",
                table: "NCM",
                newName: "Data_Inicio");

            migrationBuilder.RenameColumn(
                name: "dtAtualizacao",
                table: "NCM",
                newName: "Data_Fim");

            migrationBuilder.RenameColumn(
                name: "codigo",
                table: "NCM",
                newName: "Descricao_Concatenada");

            migrationBuilder.AddColumn<string>(
                name: "Ano",
                table: "NCM",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ato_Legal",
                table: "NCM",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Codigo_NCM",
                table: "NCM",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "NCM",
                type: "text",
                nullable: true);
        }
    }
}
