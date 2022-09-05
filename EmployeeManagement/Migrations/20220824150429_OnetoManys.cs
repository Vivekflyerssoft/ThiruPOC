using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagement.Migrations
{
    public partial class OnetoManys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_departments_organitations_Id",
                table: "departments");

            migrationBuilder.DropTable(
                name: "organitations");

            migrationBuilder.CreateTable(
                name: "organisations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_organisations", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_departments_organisations_Id",
                table: "departments",
                column: "Id",
                principalTable: "organisations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_departments_organisations_Id",
                table: "departments");

            migrationBuilder.DropTable(
                name: "organisations");

            migrationBuilder.CreateTable(
                name: "organitations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_organitations", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_departments_organitations_Id",
                table: "departments",
                column: "Id",
                principalTable: "organitations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
