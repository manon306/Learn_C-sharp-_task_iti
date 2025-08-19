using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Core.Migrations
{
    /// <inheritdoc />
    public partial class addFleuntApisRequierdinCreteOn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.EnsureSchema(
                name: "HR");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "X",
                newSchema: "HR");

            migrationBuilder.AddColumn<int>(
                name: "createOn",
                schema: "HR",
                table: "X",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_X",
                schema: "HR",
                table: "X",
                column: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_X",
                schema: "HR",
                table: "X");

            migrationBuilder.DropColumn(
                name: "createOn",
                schema: "HR",
                table: "X");

            migrationBuilder.RenameTable(
                name: "X",
                schema: "HR",
                newName: "Employees");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "ID");
        }
    }
}
