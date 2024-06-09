using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NeveTirzhaPrisoner.Data.Migrations
{
    public partial class num1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_rehabilitationPrograms_prisoners_PrisonerId",
                table: "rehabilitationPrograms");

            migrationBuilder.DropIndex(
                name: "IX_rehabilitationPrograms_PrisonerId",
                table: "rehabilitationPrograms");

            migrationBuilder.DropColumn(
                name: "PrisonerId",
                table: "rehabilitationPrograms");

            migrationBuilder.CreateTable(
                name: "PrisonerRehabilitationPrograms",
                columns: table => new
                {
                    ProgramsId = table.Column<int>(type: "int", nullable: false),
                    prisonersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrisonerRehabilitationPrograms", x => new { x.ProgramsId, x.prisonersId });
                    table.ForeignKey(
                        name: "FK_PrisonerRehabilitationPrograms_prisoners_prisonersId",
                        column: x => x.prisonersId,
                        principalTable: "prisoners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PrisonerRehabilitationPrograms_rehabilitationPrograms_ProgramsId",
                        column: x => x.ProgramsId,
                        principalTable: "rehabilitationPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PrisonerRehabilitationPrograms_prisonersId",
                table: "PrisonerRehabilitationPrograms",
                column: "prisonersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PrisonerRehabilitationPrograms");

            migrationBuilder.AddColumn<int>(
                name: "PrisonerId",
                table: "rehabilitationPrograms",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_rehabilitationPrograms_PrisonerId",
                table: "rehabilitationPrograms",
                column: "PrisonerId");

            migrationBuilder.AddForeignKey(
                name: "FK_rehabilitationPrograms_prisoners_PrisonerId",
                table: "rehabilitationPrograms",
                column: "PrisonerId",
                principalTable: "prisoners",
                principalColumn: "Id");
        }
    }
}
