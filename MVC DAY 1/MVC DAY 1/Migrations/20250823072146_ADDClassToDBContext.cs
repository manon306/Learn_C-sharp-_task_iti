using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_DAY_1.Migrations
{
    /// <inheritdoc />
    public partial class ADDClassToDBContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClassID",
                table: "S",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_S_ClassID",
                table: "S",
                column: "ClassID");

            migrationBuilder.AddForeignKey(
                name: "FK_S_Classes_ClassID",
                table: "S",
                column: "ClassID",
                principalTable: "Classes",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_S_Classes_ClassID",
                table: "S");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropIndex(
                name: "IX_S_ClassID",
                table: "S");

            migrationBuilder.DropColumn(
                name: "ClassID",
                table: "S");
        }
    }
}
