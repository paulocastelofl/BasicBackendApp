using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateTableEmpresaAddAssociadosv3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empresa_Empresa_Empresa",
                table: "Empresa");

            migrationBuilder.DropIndex(
                name: "IX_Empresa_Empresa",
                table: "Empresa");

            migrationBuilder.RenameColumn(
                name: "Empresa",
                table: "Empresa",
                newName: "IdEmpresa");

            migrationBuilder.AddColumn<int>(
                name: "EmpresaId",
                table: "Empresa",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_EmpresaId",
                table: "Empresa",
                column: "EmpresaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Empresa_Empresa_EmpresaId",
                table: "Empresa",
                column: "EmpresaId",
                principalTable: "Empresa",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empresa_Empresa_EmpresaId",
                table: "Empresa");

            migrationBuilder.DropIndex(
                name: "IX_Empresa_EmpresaId",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "Empresa");

            migrationBuilder.RenameColumn(
                name: "IdEmpresa",
                table: "Empresa",
                newName: "Empresa");

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_Empresa",
                table: "Empresa",
                column: "Empresa");

            migrationBuilder.AddForeignKey(
                name: "FK_Empresa_Empresa_Empresa",
                table: "Empresa",
                column: "Empresa",
                principalTable: "Empresa",
                principalColumn: "Id");
        }
    }
}
