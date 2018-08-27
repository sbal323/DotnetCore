using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Dal.Migrations
{
    public partial class CompetenciesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Competency",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competency", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeCompetencies",
                columns: table => new
                {
                    CompetencyId = table.Column<int>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeCompetencies", x => new { x.EmployeeId, x.CompetencyId });
                    table.ForeignKey(
                        name: "FK_EmployeeCompetencies_Competency_CompetencyId",
                        column: x => x.CompetencyId,
                        principalTable: "Competency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeCompetencies_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeCompetencies_CompetencyId",
                table: "EmployeeCompetencies",
                column: "CompetencyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeCompetencies");

            migrationBuilder.DropTable(
                name: "Competency");
        }
    }
}
