using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Student.DAL.Migrations
{
    /// <inheritdoc />
    public partial class MakeClassIdNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_classes_ClassID",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "ClassID",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_classes_ClassID",
                table: "Users",
                column: "ClassID",
                principalTable: "classes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_classes_ClassID",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "ClassID",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_classes_ClassID",
                table: "Users",
                column: "ClassID",
                principalTable: "classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
