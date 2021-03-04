using Microsoft.EntityFrameworkCore.Migrations;

namespace GL.FC.Data.Database.Migrations
{
    public partial class AddingImagePathForUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "UserProfile",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImagePath",
                value: "uploads/user/user-1.png");

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImagePath",
                value: "uploads/user/user-2.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "UserProfile");
        }
    }
}
