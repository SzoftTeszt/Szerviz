using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassLibrary.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Szerelok",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nev = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Szakterulet = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Szerelok", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Javitasok",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rendszam = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Hiba = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Ar = table.Column<int>(type: "int", nullable: false),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SzereloId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Javitasok", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Javitasok_Szerelok_SzereloId",
                        column: x => x.SzereloId,
                        principalTable: "Szerelok",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Javitasok_SzereloId",
                table: "Javitasok",
                column: "SzereloId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Javitasok");

            migrationBuilder.DropTable(
                name: "Szerelok");
        }
    }
}
