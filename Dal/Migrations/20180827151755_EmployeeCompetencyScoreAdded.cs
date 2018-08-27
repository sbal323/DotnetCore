using Microsoft.EntityFrameworkCore.Migrations;

namespace Dal.Migrations
{
    public partial class EmployeeCompetencyScoreAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Score",
                table: "EmployeeCompetencies",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Score",
                table: "EmployeeCompetencies");
        }
    }
}
