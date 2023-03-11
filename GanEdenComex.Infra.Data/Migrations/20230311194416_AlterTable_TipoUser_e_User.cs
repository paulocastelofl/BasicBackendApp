using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AlterTableTipoUsereUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TipoUser_Users_IdUser",
                table: "TipoUser");

            migrationBuilder.DropIndex(
                name: "IX_TipoUser_IdUser",
                table: "TipoUser");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "TipoUser");

            migrationBuilder.AddColumn<int>(
                name: "IdTipoUser",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_IdTipoUser",
                table: "Users",
                column: "IdTipoUser");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_TipoUser_IdTipoUser",
                table: "Users",
                column: "IdTipoUser",
                principalTable: "TipoUser",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_TipoUser_IdTipoUser",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_IdTipoUser",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IdTipoUser",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "IdUser",
                table: "TipoUser",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TipoUser_IdUser",
                table: "TipoUser",
                column: "IdUser");

            migrationBuilder.AddForeignKey(
                name: "FK_TipoUser_Users_IdUser",
                table: "TipoUser",
                column: "IdUser",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
