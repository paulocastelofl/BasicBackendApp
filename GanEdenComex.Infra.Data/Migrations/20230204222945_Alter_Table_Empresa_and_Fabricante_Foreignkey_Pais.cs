using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AlterTableEmpresaandFabricanteForeignkeyPais : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdPais",
                table: "Fabricante",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdPais",
                table: "Empresa",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Fabricante_IdPais",
                table: "Fabricante",
                column: "IdPais");

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_IdPais",
                table: "Empresa",
                column: "IdPais");

            migrationBuilder.AddForeignKey(
                name: "FK_Empresa_Pais_IdPais",
                table: "Empresa",
                column: "IdPais",
                principalTable: "Pais",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Fabricante_Pais_IdPais",
                table: "Fabricante",
                column: "IdPais",
                principalTable: "Pais",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empresa_Pais_IdPais",
                table: "Empresa");

            migrationBuilder.DropForeignKey(
                name: "FK_Fabricante_Pais_IdPais",
                table: "Fabricante");

            migrationBuilder.DropIndex(
                name: "IX_Fabricante_IdPais",
                table: "Fabricante");

            migrationBuilder.DropIndex(
                name: "IX_Empresa_IdPais",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "IdPais",
                table: "Fabricante");

            migrationBuilder.DropColumn(
                name: "IdPais",
                table: "Empresa");
        }
    }
}
