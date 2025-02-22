using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobFind_BE.Migrations
{
    /// <inheritdoc />
    public partial class modifym2mv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_User_Company_User_CompanyId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "CompanyUser_Company");

            migrationBuilder.DropTable(
                name: "LevelPost_Level");

            migrationBuilder.DropTable(
                name: "PostPost_Level");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_User_CompanyId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d849e90-5e66-47bc-9664-aa7a3b9aa4ad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be296fa9-5c9f-4307-9b3e-53ea6940ef56");

            migrationBuilder.DropColumn(
                name: "User_CompanyId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "UsersId",
                table: "User_Company",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4c100b95-6e6a-4201-8abe-3609986c630e", null, "User", "USER" },
                    { "ba8e5641-7dc9-48cf-bb04-2d66559f3576", null, "Admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_Company_CompanyId",
                table: "User_Company",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Company_UsersId",
                table: "User_Company",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_Level_levelId",
                table: "Post_Level",
                column: "levelId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_Level_PostId",
                table: "Post_Level",
                column: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Level_Levels_levelId",
                table: "Post_Level",
                column: "levelId",
                principalTable: "Levels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Level_Posts_PostId",
                table: "Post_Level",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Company_AspNetUsers_UsersId",
                table: "User_Company",
                column: "UsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Company_Companies_CompanyId",
                table: "User_Company",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Post_Level_Levels_levelId",
                table: "Post_Level");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_Level_Posts_PostId",
                table: "Post_Level");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Company_AspNetUsers_UsersId",
                table: "User_Company");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Company_Companies_CompanyId",
                table: "User_Company");

            migrationBuilder.DropIndex(
                name: "IX_User_Company_CompanyId",
                table: "User_Company");

            migrationBuilder.DropIndex(
                name: "IX_User_Company_UsersId",
                table: "User_Company");

            migrationBuilder.DropIndex(
                name: "IX_Post_Level_levelId",
                table: "Post_Level");

            migrationBuilder.DropIndex(
                name: "IX_Post_Level_PostId",
                table: "Post_Level");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c100b95-6e6a-4201-8abe-3609986c630e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba8e5641-7dc9-48cf-bb04-2d66559f3576");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "User_Company");

            migrationBuilder.AddColumn<int>(
                name: "User_CompanyId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CompanyUser_Company",
                columns: table => new
                {
                    CompaniesId = table.Column<int>(type: "int", nullable: false),
                    User_CompaniesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyUser_Company", x => new { x.CompaniesId, x.User_CompaniesId });
                    table.ForeignKey(
                        name: "FK_CompanyUser_Company_Companies_CompaniesId",
                        column: x => x.CompaniesId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyUser_Company_User_Company_User_CompaniesId",
                        column: x => x.User_CompaniesId,
                        principalTable: "User_Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LevelPost_Level",
                columns: table => new
                {
                    LevelsId = table.Column<int>(type: "int", nullable: false),
                    Post_LevelsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LevelPost_Level", x => new { x.LevelsId, x.Post_LevelsId });
                    table.ForeignKey(
                        name: "FK_LevelPost_Level_Levels_LevelsId",
                        column: x => x.LevelsId,
                        principalTable: "Levels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LevelPost_Level_Post_Level_Post_LevelsId",
                        column: x => x.Post_LevelsId,
                        principalTable: "Post_Level",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostPost_Level",
                columns: table => new
                {
                    Post_LevelsId = table.Column<int>(type: "int", nullable: false),
                    PostsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostPost_Level", x => new { x.Post_LevelsId, x.PostsId });
                    table.ForeignKey(
                        name: "FK_PostPost_Level_Post_Level_Post_LevelsId",
                        column: x => x.Post_LevelsId,
                        principalTable: "Post_Level",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostPost_Level_Posts_PostsId",
                        column: x => x.PostsId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9d849e90-5e66-47bc-9664-aa7a3b9aa4ad", null, "Admin", "ADMIN" },
                    { "be296fa9-5c9f-4307-9b3e-53ea6940ef56", null, "User", "USER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_User_CompanyId",
                table: "AspNetUsers",
                column: "User_CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyUser_Company_User_CompaniesId",
                table: "CompanyUser_Company",
                column: "User_CompaniesId");

            migrationBuilder.CreateIndex(
                name: "IX_LevelPost_Level_Post_LevelsId",
                table: "LevelPost_Level",
                column: "Post_LevelsId");

            migrationBuilder.CreateIndex(
                name: "IX_PostPost_Level_PostsId",
                table: "PostPost_Level",
                column: "PostsId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_User_Company_User_CompanyId",
                table: "AspNetUsers",
                column: "User_CompanyId",
                principalTable: "User_Company",
                principalColumn: "Id");
        }
    }
}
