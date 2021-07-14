using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace felipe_santos_volvoapp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Caminhao",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Modelo = table.Column<int>(nullable: false),
                    AnoFabricacao = table.Column<DateTime>(nullable: false),
                    AnoModelo = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caminhao", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Caminhao");
        }
    }
}
