using Microsoft.EntityFrameworkCore.Migrations;

namespace Dal.Migrations
{
    public partial class TotalSalaryChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "AnnualTotalSalary",
                table: "SalaryDetails",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnnualTotalSalary",
                table: "SalaryDetails");
        }
    }
}
