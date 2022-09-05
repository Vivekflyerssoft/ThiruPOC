using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagement.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    EmpId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 100"),
                    Name = table.Column<string>(nullable: true),
                    EmailId = table.Column<string>(nullable: true),
                    PhoneNo = table.Column<string>(nullable: true),
                    Designation = table.Column<string>(nullable: true),
                    Salary = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.EmpId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employees");
        }
    }
}
