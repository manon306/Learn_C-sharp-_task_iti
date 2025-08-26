using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sempa.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddImageInUSerClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "imagePath",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imagePath",
                table: "Users");
        }
    }
}
