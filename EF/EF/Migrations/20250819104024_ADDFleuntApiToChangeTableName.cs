using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Core.Migrations
{
    /// <inheritdoc />
    public partial class ADDFleuntApiToChangeTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_X",
                schema: "HR",
                table: "X");

            migrationBuilder.EnsureSchema(
                name: "DEV");

            migrationBuilder.RenameTable(
                name: "X",
                schema: "HR",
                newName: "EmployeeTable",
                newSchema: "DEV");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeTable",
                schema: "DEV",
                table: "EmployeeTable",
                column: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeTable",
                schema: "DEV",
                table: "EmployeeTable");

            migrationBuilder.EnsureSchema(
                name: "HR");

            migrationBuilder.RenameTable(
                name: "EmployeeTable",
                schema: "DEV",
                newName: "X",
                newSchema: "HR");

            migrationBuilder.AddPrimaryKey(
                name: "PK_X",
                schema: "HR",
                table: "X",
                column: "ID");
        }
    }
}
