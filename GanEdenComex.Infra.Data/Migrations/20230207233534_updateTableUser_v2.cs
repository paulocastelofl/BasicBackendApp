using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateTableUserv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Empresa_PaisId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_PaisId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PaisId",
                table: "Users");

            migrationBuilder.CreateIndex(
                name: "IX_Users_IdEmpresa",
                table: "Users",
                column: "IdEmpresa");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Empresa_IdEmpresa",
                table: "Users",
                column: "IdEmpresa",
                principalTable: "Empresa",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Empresa_IdEmpresa",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_IdEmpresa",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "PaisId",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_PaisId",
                table: "Users",
                column: "PaisId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Empresa_PaisId",
                table: "Users",
                column: "PaisId",
                principalTable: "Empresa",
                principalColumn: "Id");
        }
    }
}
