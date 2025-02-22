using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobFind_BE.Migrations
{
    /// <inheritdoc />
    public partial class modifym2m : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Posts_PostId",
                table: "Companies");

            migrationBuilder.DropTable(
                name: "AreaPost");

            migrationBuilder.DropTable(
                name: "CategoryPost");

            migrationBuilder.DropTable(
                name: "FormOfWorkPost");

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
                name: "PostId",
                table: "Companies");

            migrationBuilder.AddColumn<int>(
                name: "AreasId",
                table: "Posts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoriesId",
                table: "Posts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompaniesId",
                table: "Posts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FormOfWorksId",
                table: "Posts",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9d849e90-5e66-47bc-9664-aa7a3b9aa4ad", null, "Admin", "ADMIN" },
                    { "be296fa9-5c9f-4307-9b3e-53ea6940ef56", null, "User", "USER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_AreasId",
                table: "Posts",
                column: "AreasId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CategoriesId",
                table: "Posts",
                column: "CategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CompaniesId",
                table: "Posts",
                column: "CompaniesId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_FormOfWorksId",
                table: "Posts",
                column: "FormOfWorksId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Areas_AreasId",
                table: "Posts",
                column: "AreasId",
                principalTable: "Areas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Categories_CategoriesId",
                table: "Posts",
                column: "CategoriesId",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Companies_CompaniesId",
                table: "Posts",
                column: "CompaniesId",
                principalTable: "Companies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_FormOfWorks_FormOfWorksId",
                table: "Posts",
                column: "FormOfWorksId",
                principalTable: "FormOfWorks",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Areas_AreasId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Categories_CategoriesId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Companies_CompaniesId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_FormOfWorks_FormOfWorksId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_AreasId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_CategoriesId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_CompaniesId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_FormOfWorksId",
                table: "Posts");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d849e90-5e66-47bc-9664-aa7a3b9aa4ad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be296fa9-5c9f-4307-9b3e-53ea6940ef56");

            migrationBuilder.DropColumn(
                name: "AreasId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "CategoriesId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "CompaniesId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "FormOfWorksId",
                table: "Posts");

            migrationBuilder.AddColumn<int>(
                name: "PostId",
                table: "Companies",
                type: "int",
                nullable: true);

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4853c7e1-e75d-404e-8543-917f8f2bcd1a", null, "User", "USER" },
                    { "89795abe-9b7d-40e9-96e3-0a0f3850cd5c", null, "Admin", "ADMIN" }
                });

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
                name: "IX_FormOfWorkPost_PostsId",
                table: "FormOfWorkPost",
                column: "PostsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Posts_PostId",
                table: "Companies",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id");
        }
    }
}
