using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GL.FC.Data.Database.Migrations
{
    public partial class AddingPostTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    ModificationDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    ModificationDate = table.Column<DateTime>(nullable: true),
                    Heading = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    Tags = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Post_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Post_UserProfile_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "UserProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    ModificationDate = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    PostId = table.Column<int>(nullable: false),
                    CommentedById = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_UserProfile_CommentedById",
                        column: x => x.CommentedById,
                        principalTable: "UserProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comment_Post_PostId",
                        column: x => x.PostId,
                        principalTable: "Post",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Likes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    ModificationDate = table.Column<DateTime>(nullable: true),
                    PostId = table.Column<int>(nullable: false),
                    LikedById = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Likes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Likes_UserProfile_LikedById",
                        column: x => x.LikedById,
                        principalTable: "UserProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Likes_Post_PostId",
                        column: x => x.PostId,
                        principalTable: "Post",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PostImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    ModificationDate = table.Column<DateTime>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    PostId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostImages_Post_PostId",
                        column: x => x.PostId,
                        principalTable: "Post",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreationDate", "ModificationDate", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 10, 30, 10, 51, 4, 5, DateTimeKind.Local).AddTicks(9420), new DateTime(2020, 10, 30, 10, 51, 4, 5, DateTimeKind.Local).AddTicks(9420), "Transformation" },
                    { 2, new DateTime(2020, 10, 30, 10, 51, 4, 5, DateTimeKind.Local).AddTicks(9420), new DateTime(2020, 10, 30, 10, 51, 4, 5, DateTimeKind.Local).AddTicks(9420), "Stories" },
                    { 3, new DateTime(2020, 10, 30, 10, 51, 4, 5, DateTimeKind.Local).AddTicks(9420), new DateTime(2020, 10, 30, 10, 51, 4, 5, DateTimeKind.Local).AddTicks(9420), "Blog" },
                    { 4, new DateTime(2020, 10, 30, 10, 51, 4, 5, DateTimeKind.Local).AddTicks(9420), new DateTime(2020, 10, 30, 10, 51, 4, 5, DateTimeKind.Local).AddTicks(9420), "Hacks" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comment_CommentedById",
                table: "Comment",
                column: "CommentedById");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_PostId",
                table: "Comment",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_LikedById",
                table: "Likes",
                column: "LikedById");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_PostId",
                table: "Likes",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_CategoryId",
                table: "Post",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_CreatedBy",
                table: "Post",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PostImages_PostId",
                table: "PostImages",
                column: "PostId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "Likes");

            migrationBuilder.DropTable(
                name: "PostImages");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
