using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AlterTableZFM : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdEmpresa",
                table: "ZFM",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ZFM_IdEmpresa",
                table: "ZFM",
                column: "IdEmpresa");

            migrationBuilder.AddForeignKey(
                name: "FK_ZFM_Empresa_IdEmpresa",
                table: "ZFM",
                column: "IdEmpresa",
                principalTable: "Empresa",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ZFM_Empresa_IdEmpresa",
                table: "ZFM");

            migrationBuilder.DropIndex(
                name: "IX_ZFM_IdEmpresa",
                table: "ZFM");

            migrationBuilder.DropColumn(
                name: "IdEmpresa",
                table: "ZFM");
        }
    }
}
