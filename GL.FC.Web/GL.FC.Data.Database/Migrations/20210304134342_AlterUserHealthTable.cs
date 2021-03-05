using Microsoft.EntityFrameworkCore.Migrations;

namespace GL.FC.Data.Database.Migrations
{
    public partial class AlterUserHealthTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Abdomen",
                table: "UserHealth",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Neck",
                table: "UserHealth",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Abdomen",
                table: "UserHealth");

            migrationBuilder.DropColumn(
                name: "Neck",
                table: "UserHealth");
        }
    }
}
