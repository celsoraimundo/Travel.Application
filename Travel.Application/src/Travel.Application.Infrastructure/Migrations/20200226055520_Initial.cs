using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Travel.Application.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Viagem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomePassageiro = table.Column<string>(nullable: false),
                    DataPartida = table.Column<DateTime>(type: "datetime", nullable: false),
                    Origem = table.Column<string>(nullable: false),
                    Destino = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Viagem", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Viagem");
        }
    }
}
