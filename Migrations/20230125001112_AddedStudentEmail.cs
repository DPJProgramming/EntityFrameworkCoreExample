using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity_Framework_core_example.Migrations
{
    public partial class AddedStudentEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmailAddress",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailAddress",
                table: "Students");
        }
    }
}
