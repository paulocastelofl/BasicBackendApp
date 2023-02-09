using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateTableEmpresaAddAssociadosv4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_IdEmpresa",
                table: "Empresa",
                column: "IdEmpresa");

            migrationBuilder.AddForeignKey(
                name: "FK_Empresa_Empresa_IdEmpresa",
                table: "Empresa",
                column: "IdEmpresa",
                principalTable: "Empresa",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empresa_Empresa_IdEmpresa",
                table: "Empresa");

            migrationBuilder.DropIndex(
                name: "IX_Empresa_IdEmpresa",
                table: "Empresa");

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
    }
}
