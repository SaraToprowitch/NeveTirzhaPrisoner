using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NeveTirzhaPrisoner.Data.Migrations
{
    public partial class num2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CurrentNumOfPrisoners",
                table: "rehabilitationPrograms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaxNumOfPrisoners",
                table: "rehabilitationPrograms",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentNumOfPrisoners",
                table: "rehabilitationPrograms");

            migrationBuilder.DropColumn(
                name: "MaxNumOfPrisoners",
                table: "rehabilitationPrograms");
        }
    }
}
