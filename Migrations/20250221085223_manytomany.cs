using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobFind_BE.Migrations
{
    /// <inheritdoc />
    public partial class manytomany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Post_User_Post_UserId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Areas_Area_id",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Categories_Category_id",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Companies_Company_id",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_FormOfWorks_Form_of_work_id",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Post_Tag_Post_TagId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Post_User_Post_UserId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Tags_Post_Tag_Post_TagId",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Tags_Post_TagId",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Posts_Area_id",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_Category_id",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_Company_id",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_Form_of_work_id",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_Post_TagId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_Post_UserId",
                table: "Posts");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70273daa-745c-41fc-b74d-9aca1f49c0e6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a4492407-5d5e-4c2b-a470-6d9f3df8181f");

            migrationBuilder.DropColumn(
                name: "Post_TagId",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "Post_TagId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Post_UserId",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "Post_UserId",
                table: "AspNetUsers",
                newName: "User_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_Post_UserId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_User_CompanyId");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Post_User",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Cover_letter",
                table: "Post_User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cv",
                table: "Post_User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Post_User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Subject",
                table: "Post_User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PostId",
                table: "Companies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "AreaPost",
                columns: table => new
                {
                    AreasId = table.Column<int>(type: "int", nullable: false),
                    PostsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaPost", x => new { x.AreasId, x.PostsId });
                    table.ForeignKey(
                        name: "FK_AreaPost_Areas_AreasId",
                        column: x => x.AreasId,
                        principalTable: "Areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AreaPost_Posts_PostsId",
                        column: x => x.PostsId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryPost",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    PostsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryPost", x => new { x.CategoriesId, x.PostsId });
                    table.ForeignKey(
                        name: "FK_CategoryPost_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryPost_Posts_PostsId",
                        column: x => x.PostsId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormOfWorkPost",
                columns: table => new
                {
                    FormOfWorksId = table.Column<int>(type: "int", nullable: false),
                    PostsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormOfWorkPost", x => new { x.FormOfWorksId, x.PostsId });
                    table.ForeignKey(
                        name: "FK_FormOfWorkPost_FormOfWorks_FormOfWorksId",
                        column: x => x.FormOfWorksId,
                        principalTable: "FormOfWorks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormOfWorkPost_Posts_PostsId",
                        column: x => x.PostsId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Post_Level",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    levelId = table.Column<int>(type: "int", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post_Level", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Post_Position",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    PositionId = table.Column<int>(type: "int", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post_Position", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Post_Position_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Post_Position_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User_Company",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Company", x => x.Id);
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4853c7e1-e75d-404e-8543-917f8f2bcd1a", null, "User", "USER" },
                    { "89795abe-9b7d-40e9-96e3-0a0f3850cd5c", null, "Admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Post_User_PostId",
                table: "Post_User",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_User_UserId",
                table: "Post_User",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_Tag_PostId",
                table: "Post_Tag",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_Tag_TagId",
                table: "Post_Tag",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_PostId",
                table: "Companies",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_AreaPost_PostsId",
                table: "AreaPost",
                column: "PostsId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryPost_PostsId",
                table: "CategoryPost",
                column: "PostsId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyUser_Company_User_CompaniesId",
                table: "CompanyUser_Company",
                column: "User_CompaniesId");

            migrationBuilder.CreateIndex(
                name: "IX_FormOfWorkPost_PostsId",
                table: "FormOfWorkPost",
                column: "PostsId");

            migrationBuilder.CreateIndex(
                name: "IX_LevelPost_Level_Post_LevelsId",
                table: "LevelPost_Level",
                column: "Post_LevelsId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_Position_PositionId",
                table: "Post_Position",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_Position_PostId",
                table: "Post_Position",
                column: "PostId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Posts_PostId",
                table: "Companies",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Tag_Posts_PostId",
                table: "Post_Tag",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Tag_Tags_TagId",
                table: "Post_Tag",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Post_User_AspNetUsers_UserId",
                table: "Post_User",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Post_User_Posts_PostId",
                table: "Post_User",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_User_Company_User_CompanyId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Posts_PostId",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_Tag_Posts_PostId",
                table: "Post_Tag");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_Tag_Tags_TagId",
                table: "Post_Tag");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_User_AspNetUsers_UserId",
                table: "Post_User");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_User_Posts_PostId",
                table: "Post_User");

            migrationBuilder.DropTable(
                name: "AreaPost");

            migrationBuilder.DropTable(
                name: "CategoryPost");

            migrationBuilder.DropTable(
                name: "CompanyUser_Company");

            migrationBuilder.DropTable(
                name: "FormOfWorkPost");

            migrationBuilder.DropTable(
                name: "LevelPost_Level");

            migrationBuilder.DropTable(
                name: "Post_Position");

            migrationBuilder.DropTable(
                name: "PostPost_Level");

            migrationBuilder.DropTable(
                name: "User_Company");

            migrationBuilder.DropTable(
                name: "Post_Level");

            migrationBuilder.DropIndex(
                name: "IX_Post_User_PostId",
                table: "Post_User");

            migrationBuilder.DropIndex(
                name: "IX_Post_User_UserId",
                table: "Post_User");

            migrationBuilder.DropIndex(
                name: "IX_Post_Tag_PostId",
                table: "Post_Tag");

            migrationBuilder.DropIndex(
                name: "IX_Post_Tag_TagId",
                table: "Post_Tag");

            migrationBuilder.DropIndex(
                name: "IX_Companies_PostId",
                table: "Companies");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4853c7e1-e75d-404e-8543-917f8f2bcd1a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89795abe-9b7d-40e9-96e3-0a0f3850cd5c");

            migrationBuilder.DropColumn(
                name: "Cover_letter",
                table: "Post_User");

            migrationBuilder.DropColumn(
                name: "Cv",
                table: "Post_User");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Post_User");

            migrationBuilder.DropColumn(
                name: "Subject",
                table: "Post_User");

            migrationBuilder.DropColumn(
                name: "PostId",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "User_CompanyId",
                table: "AspNetUsers",
                newName: "Post_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_User_CompanyId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_Post_UserId");

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

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Post_User",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "70273daa-745c-41fc-b74d-9aca1f49c0e6", null, "Admin", "ADMIN" },
                    { "a4492407-5d5e-4c2b-a470-6d9f3df8181f", null, "User", "USER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tags_Post_TagId",
                table: "Tags",
                column: "Post_TagId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_Area_id",
                table: "Posts",
                column: "Area_id");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_Category_id",
                table: "Posts",
                column: "Category_id");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_Company_id",
                table: "Posts",
                column: "Company_id");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_Form_of_work_id",
                table: "Posts",
                column: "Form_of_work_id");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_Post_TagId",
                table: "Posts",
                column: "Post_TagId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_Post_UserId",
                table: "Posts",
                column: "Post_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Post_User_Post_UserId",
                table: "AspNetUsers",
                column: "Post_UserId",
                principalTable: "Post_User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Areas_Area_id",
                table: "Posts",
                column: "Area_id",
                principalTable: "Areas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Categories_Category_id",
                table: "Posts",
                column: "Category_id",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Companies_Company_id",
                table: "Posts",
                column: "Company_id",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_FormOfWorks_Form_of_work_id",
                table: "Posts",
                column: "Form_of_work_id",
                principalTable: "FormOfWorks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
    }
}
