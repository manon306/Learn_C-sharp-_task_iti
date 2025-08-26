using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Student.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UserClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_classes_ClassId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "ClassId",
                table: "Users",
                newName: "ClassID");

            migrationBuilder.RenameIndex(
                name: "IX_Users_ClassId",
                table: "Users",
                newName: "IX_Users_ClassID");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_classes_ClassID",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "ClassID",
                table: "Users",
                newName: "ClassId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_ClassID",
                table: "Users",
                newName: "IX_Users_ClassId");

            migrationBuilder.AlterColumn<int>(
                name: "ClassId",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_classes_ClassId",
                table: "Users",
                column: "ClassId",
                principalTable: "classes",
                principalColumn: "Id");
        }
    }
}
