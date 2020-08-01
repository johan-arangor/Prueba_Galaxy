using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace Prueba_Galaxy.Migrations
{
    public partial class MigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "contratosItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    NumContrato = table.Column<int>(nullable: false),
                    IdTrabajador = table.Column<int>(nullable: false),
                    IdEntidad = table.Column<string>(nullable: true),
                    Finicio = table.Column<DateTime>(nullable: false),
                    FFin = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contratosItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "entidadItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_entidadItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "trabajadorItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    IdTypeDocument = table.Column<int>(nullable: false),
                    PNombre = table.Column<string>(nullable: true),
                    SNombre = table.Column<string>(nullable: true),
                    PApellido = table.Column<string>(nullable: true),
                    SApellido = table.Column<string>(nullable: true),
                    FNacimiento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trabajadorItems", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contratosItems");

            migrationBuilder.DropTable(
                name: "entidadItems");

            migrationBuilder.DropTable(
                name: "trabajadorItems");
        }
    }
}
