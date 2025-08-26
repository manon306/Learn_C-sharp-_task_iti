using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_DAY_1.Migrations
{
    /// <inheritdoc />
    public partial class ADDRelationBetweenClassAndStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_S_Classes_ClassID",
                table: "S");

            migrationBuilder.AlterColumn<int>(
                name: "ClassID",
                table: "S",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_S_Classes_ClassID",
                table: "S",
                column: "ClassID",
                principalTable: "Classes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_S_Classes_ClassID",
                table: "S");

            migrationBuilder.AlterColumn<int>(
                name: "ClassID",
                table: "S",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_S_Classes_ClassID",
                table: "S",
                column: "ClassID",
                principalTable: "Classes",
                principalColumn: "ID");
        }
    }
}
