using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobFind_BE.Migrations
{
    /// <inheritdoc />
    public partial class updatetagss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "996c6318-ac17-406a-835c-4b90af7b1722");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a85de4c3-0fee-4394-8721-7b13ddc45982");

            migrationBuilder.AddColumn<int>(
                name: "Post_TagId",
                table: "Tags",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Post_TagId",
                table: "Posts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Post_UserId",
                table: "Posts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Post_UserId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PostTags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PostViews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostViews", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a4c1f8ca-c584-4362-8122-6e7ff1dd5ef3", null, "User", "USER" },
                    { "cc901868-f23b-4dbe-b1dc-bd8c8eb848af", null, "Admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tags_Post_TagId",
                table: "Tags",
                column: "Post_TagId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_Post_TagId",
                table: "Posts",
                column: "Post_TagId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_Post_UserId",
                table: "Posts",
                column: "Post_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Post_UserId",
                table: "AspNetUsers",
                column: "Post_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_PostViews_Post_UserId",
                table: "AspNetUsers",
                column: "Post_UserId",
                principalTable: "PostViews",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_PostTags_Post_TagId",
                table: "Posts",
                column: "Post_TagId",
                principalTable: "PostTags",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_PostViews_Post_UserId",
                table: "Posts",
                column: "Post_UserId",
                principalTable: "PostViews",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_PostTags_Post_TagId",
                table: "Tags",
                column: "Post_TagId",
                principalTable: "PostTags",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_PostViews_Post_UserId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_PostTags_Post_TagId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_PostViews_Post_UserId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Tags_PostTags_Post_TagId",
                table: "Tags");

            migrationBuilder.DropTable(
                name: "PostTags");

            migrationBuilder.DropTable(
                name: "PostViews");

            migrationBuilder.DropIndex(
                name: "IX_Tags_Post_TagId",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Posts_Post_TagId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_Post_UserId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Post_UserId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a4c1f8ca-c584-4362-8122-6e7ff1dd5ef3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc901868-f23b-4dbe-b1dc-bd8c8eb848af");

            migrationBuilder.DropColumn(
                name: "Post_TagId",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "Post_TagId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Post_UserId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Post_UserId",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "996c6318-ac17-406a-835c-4b90af7b1722", null, "Admin", "ADMIN" },
                    { "a85de4c3-0fee-4394-8721-7b13ddc45982", null, "User", "USER" }
                });
        }
    }
}
