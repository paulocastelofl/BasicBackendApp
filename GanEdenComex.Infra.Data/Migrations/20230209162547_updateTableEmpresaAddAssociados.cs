using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateTableEmpresaAddAssociados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmpresaId",
                table: "Empresa",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdEmpresa",
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

            migrationBuilder.DropColumn(
                name: "IdEmpresa",
                table: "Empresa");
        }
    }
}
