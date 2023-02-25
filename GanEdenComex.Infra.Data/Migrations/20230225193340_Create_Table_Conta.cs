using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableConta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Conta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Banco = table.Column<string>(type: "text", nullable: true),
                    Agencia = table.Column<string>(type: "text", nullable: true),
                    Numero = table.Column<string>(type: "text", nullable: true),
                    NomeTitular = table.Column<string>(type: "text", nullable: true),
                    CpfTitular = table.Column<string>(type: "text", nullable: true),
                    RestricaoUso = table.Column<string>(type: "text", nullable: true),
                    Limite = table.Column<string>(type: "text", nullable: true),
                    TipoDeBloqueio = table.Column<string>(type: "text", nullable: true),
                    ContaPadraoCNAB = table.Column<bool>(type: "boolean", nullable: true),
                    GeracaoDeBoleto = table.Column<bool>(type: "boolean", nullable: true),
                    IdEmpresa = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Conta_Empresa_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Conta_IdEmpresa",
                table: "Conta",
                column: "IdEmpresa");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Conta");
        }
    }
}
