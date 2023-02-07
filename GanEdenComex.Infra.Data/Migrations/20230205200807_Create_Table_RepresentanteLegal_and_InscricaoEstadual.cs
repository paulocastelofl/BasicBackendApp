using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableRepresentanteLegalandInscricaoEstadual : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inscricao_Estadual");

            migrationBuilder.CreateTable(
                name: "InscricaoEstadual",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Inscricao = table.Column<string>(type: "text", nullable: true),
                    IdEmpresa = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InscricaoEstadual", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InscricaoEstadual_Empresa_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RepresentanteLegal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CPF = table.Column<string>(type: "text", nullable: true),
                    CNPJ = table.Column<string>(type: "text", nullable: true),
                    MarinhaMercante = table.Column<string>(type: "text", nullable: true),
                    RegistroRepresentante = table.Column<string>(type: "text", nullable: true),
                    SenhaSISCOMEX = table.Column<string>(type: "text", nullable: true),
                    SenhaSUFRAMA = table.Column<string>(type: "text", nullable: true),
                    IdEmpresa = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepresentanteLegal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RepresentanteLegal_Empresa_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_InscricaoEstadual_IdEmpresa",
                table: "InscricaoEstadual",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_RepresentanteLegal_IdEmpresa",
                table: "RepresentanteLegal",
                column: "IdEmpresa");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InscricaoEstadual");

            migrationBuilder.DropTable(
                name: "RepresentanteLegal");

            migrationBuilder.CreateTable(
                name: "Inscricao_Estadual",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdEmpresa = table.Column<int>(type: "integer", nullable: true),
                    Inscricao = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inscricao_Estadual", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inscricao_Estadual_Empresa_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Inscricao_Estadual_IdEmpresa",
                table: "Inscricao_Estadual",
                column: "IdEmpresa");
        }
    }
}
