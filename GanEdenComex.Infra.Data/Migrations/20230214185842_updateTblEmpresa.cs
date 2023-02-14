using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateTblEmpresa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AtividadeEconomica",
                table: "Empresa");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "AtividadeEconomica",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "DtModificacao",
                table: "AtividadeEconomica",
                newName: "dtModificacao");

            migrationBuilder.RenameColumn(
                name: "Codigo",
                table: "AtividadeEconomica",
                newName: "codigo");

            migrationBuilder.AddColumn<int>(
                name: "IdAtividadeEconomica",
                table: "Empresa",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_IdAtividadeEconomica",
                table: "Empresa",
                column: "IdAtividadeEconomica");

            migrationBuilder.AddForeignKey(
                name: "FK_Empresa_AtividadeEconomica_IdAtividadeEconomica",
                table: "Empresa",
                column: "IdAtividadeEconomica",
                principalTable: "AtividadeEconomica",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empresa_AtividadeEconomica_IdAtividadeEconomica",
                table: "Empresa");

            migrationBuilder.DropIndex(
                name: "IX_Empresa_IdAtividadeEconomica",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "IdAtividadeEconomica",
                table: "Empresa");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "AtividadeEconomica",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "dtModificacao",
                table: "AtividadeEconomica",
                newName: "DtModificacao");

            migrationBuilder.RenameColumn(
                name: "codigo",
                table: "AtividadeEconomica",
                newName: "Codigo");

            migrationBuilder.AddColumn<string>(
                name: "AtividadeEconomica",
                table: "Empresa",
                type: "text",
                nullable: true);
        }
    }
}
