using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Student.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddClassIdInTeacher : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClassID",
                table: "Teachers",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClassID",
                table: "Teachers");
        }
    }
}
