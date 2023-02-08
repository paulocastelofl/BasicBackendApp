using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateTableUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cpf",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdEmpresa",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PaisId",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "Users",
                type: "text",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Empresa_PaisId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_PaisId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Cpf",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IdEmpresa",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PaisId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Users");
        }
    }
}
