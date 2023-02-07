using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableCertificadoDigital : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdCertificadoDigital",
                table: "RepresentanteLegal",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Data_Inicio",
                table: "NCM",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Data_Fim",
                table: "NCM",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "CertificadoDigital",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ArquivoCertificadoDigital = table.Column<string>(name: "Arquivo_CertificadoDigital", type: "text", nullable: true),
                    SenhaCerficadoDigital = table.Column<string>(name: "Senha_CerficadoDigital", type: "text", nullable: true),
                    DTVencimentoCertificadoDigital = table.Column<DateTime>(name: "DT_Vencimento_CertificadoDigital", type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertificadoDigital", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RepresentanteLegal_IdCertificadoDigital",
                table: "RepresentanteLegal",
                column: "IdCertificadoDigital");

            migrationBuilder.AddForeignKey(
                name: "FK_RepresentanteLegal_CertificadoDigital_IdCertificadoDigital",
                table: "RepresentanteLegal",
                column: "IdCertificadoDigital",
                principalTable: "CertificadoDigital",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RepresentanteLegal_CertificadoDigital_IdCertificadoDigital",
                table: "RepresentanteLegal");

            migrationBuilder.DropTable(
                name: "CertificadoDigital");

            migrationBuilder.DropIndex(
                name: "IX_RepresentanteLegal_IdCertificadoDigital",
                table: "RepresentanteLegal");

            migrationBuilder.DropColumn(
                name: "IdCertificadoDigital",
                table: "RepresentanteLegal");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "Data_Inicio",
                table: "NCM",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "Data_Fim",
                table: "NCM",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);
        }
    }
}
