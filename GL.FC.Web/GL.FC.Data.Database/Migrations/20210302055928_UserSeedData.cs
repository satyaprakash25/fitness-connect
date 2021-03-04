using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GL.FC.Data.Database.Migrations
{
    public partial class UserSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UserProfile",
                columns: new[] { "Id", "Address", "Age", "CreationDate", "Email", "Gender", "JoiningDate", "ModificationDate", "Name", "PhoneNumber", "Title", "ZipCode" },
                values: new object[] { 1, "New York", "27", new DateTime(2020, 10, 30, 10, 51, 4, 5, DateTimeKind.Local).AddTicks(9420), "aae7toysp6v@temporary-mail.net", "Male", new DateTime(2020, 10, 30, 10, 51, 4, 5, DateTimeKind.Local).AddTicks(9420), new DateTime(2020, 10, 30, 10, 51, 4, 5, DateTimeKind.Local).AddTicks(9420), "Jesus L Schuster", "9999999999", null, "10018" });

            migrationBuilder.InsertData(
                table: "UserProfile",
                columns: new[] { "Id", "Address", "Age", "CreationDate", "Email", "Gender", "JoiningDate", "ModificationDate", "Name", "PhoneNumber", "Title", "ZipCode" },
                values: new object[] { 2, "New York", "30", new DateTime(2020, 10, 30, 10, 51, 4, 5, DateTimeKind.Local).AddTicks(9420), "Johnson@temporary-mail.net", "Female", new DateTime(2020, 10, 30, 10, 51, 4, 5, DateTimeKind.Local).AddTicks(9420), new DateTime(2020, 10, 30, 10, 51, 4, 5, DateTimeKind.Local).AddTicks(9420), "Illa johnson", "9999999999", null, "10018" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
