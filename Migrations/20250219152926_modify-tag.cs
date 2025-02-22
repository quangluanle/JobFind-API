using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobFind_BE.Migrations
{
    /// <inheritdoc />
    public partial class modifytag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_PostViews",
                table: "PostViews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PostTags",
                table: "PostTags");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a4c1f8ca-c584-4362-8122-6e7ff1dd5ef3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc901868-f23b-4dbe-b1dc-bd8c8eb848af");

            migrationBuilder.RenameTable(
                name: "PostViews",
                newName: "Post_User");

            migrationBuilder.RenameTable(
                name: "PostTags",
                newName: "Post_Tag");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Post_User",
                table: "Post_User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Post_Tag",
                table: "Post_Tag",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "70273daa-745c-41fc-b74d-9aca1f49c0e6", null, "Admin", "ADMIN" },
                    { "a4492407-5d5e-4c2b-a470-6d9f3df8181f", null, "User", "USER" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Post_User_Post_UserId",
                table: "AspNetUsers",
                column: "Post_UserId",
                principalTable: "Post_User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Post_Tag_Post_TagId",
                table: "Posts",
                column: "Post_TagId",
                principalTable: "Post_Tag",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Post_User_Post_UserId",
                table: "Posts",
                column: "Post_UserId",
                principalTable: "Post_User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_Post_Tag_Post_TagId",
                table: "Tags",
                column: "Post_TagId",
                principalTable: "Post_Tag",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Post_User_Post_UserId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Post_Tag_Post_TagId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Post_User_Post_UserId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Tags_Post_Tag_Post_TagId",
                table: "Tags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Post_User",
                table: "Post_User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Post_Tag",
                table: "Post_Tag");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70273daa-745c-41fc-b74d-9aca1f49c0e6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a4492407-5d5e-4c2b-a470-6d9f3df8181f");

            migrationBuilder.RenameTable(
                name: "Post_User",
                newName: "PostViews");

            migrationBuilder.RenameTable(
                name: "Post_Tag",
                newName: "PostTags");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostViews",
                table: "PostViews",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostTags",
                table: "PostTags",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a4c1f8ca-c584-4362-8122-6e7ff1dd5ef3", null, "User", "USER" },
                    { "cc901868-f23b-4dbe-b1dc-bd8c8eb848af", null, "Admin", "ADMIN" }
                });

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
    }
}
