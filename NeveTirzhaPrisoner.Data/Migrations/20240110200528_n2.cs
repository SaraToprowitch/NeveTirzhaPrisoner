using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NeveTirzhaPrisoner.Data.Migrations
{
    public partial class n2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PrisonerId",
                table: "rehabilitationPrograms",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PrisonGuardId",
                table: "prisoners",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_rehabilitationPrograms_PrisonerId",
                table: "rehabilitationPrograms",
                column: "PrisonerId");

            migrationBuilder.CreateIndex(
                name: "IX_prisoners_PrisonGuardId",
                table: "prisoners",
                column: "PrisonGuardId");

            migrationBuilder.AddForeignKey(
                name: "FK_prisoners_prisonGuards_PrisonGuardId",
                table: "prisoners",
                column: "PrisonGuardId",
                principalTable: "prisonGuards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_rehabilitationPrograms_prisoners_PrisonerId",
                table: "rehabilitationPrograms",
                column: "PrisonerId",
                principalTable: "prisoners",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_prisoners_prisonGuards_PrisonGuardId",
                table: "prisoners");

            migrationBuilder.DropForeignKey(
                name: "FK_rehabilitationPrograms_prisoners_PrisonerId",
                table: "rehabilitationPrograms");

            migrationBuilder.DropIndex(
                name: "IX_rehabilitationPrograms_PrisonerId",
                table: "rehabilitationPrograms");

            migrationBuilder.DropIndex(
                name: "IX_prisoners_PrisonGuardId",
                table: "prisoners");

            migrationBuilder.DropColumn(
                name: "PrisonerId",
                table: "rehabilitationPrograms");

            migrationBuilder.DropColumn(
                name: "PrisonGuardId",
                table: "prisoners");
        }
    }
}
