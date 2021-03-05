using Microsoft.EntityFrameworkCore.Migrations;

namespace GL.FC.Data.Database.Migrations
{
    public partial class AlterUserprofileforage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Age",
                table: "UserProfile",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 1,
                column: "Age",
                value: 27.0);

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 2,
                column: "Age",
                value: 30.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Age",
                table: "UserProfile",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 1,
                column: "Age",
                value: "27");

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 2,
                column: "Age",
                value: "30");
        }
    }
}
