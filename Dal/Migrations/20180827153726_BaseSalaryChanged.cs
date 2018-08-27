using Microsoft.EntityFrameworkCore.Migrations;

namespace Dal.Migrations
{
    public partial class BaseSalaryChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "AnnualBaseSalary",
                table: "SalaryDetails",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnnualBaseSalary",
                table: "SalaryDetails");
        }
    }
}
