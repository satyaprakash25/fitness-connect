using Microsoft.EntityFrameworkCore.Migrations;

namespace GL.FC.Data.Database.Migrations
{
    public partial class AddingNameOnUserProfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "UserProfile",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "UserProfile");
        }
    }
}
