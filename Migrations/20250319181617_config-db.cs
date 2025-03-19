using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobFind_BE.Migrations
{
    /// <inheritdoc />
    public partial class configdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Post_Level_Levels_levelId",
                table: "Post_Level");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_Level_Posts_PostId",
                table: "Post_Level");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_Position_Positions_PositionId",
                table: "Post_Position");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_Position_Posts_PostId",
                table: "Post_Position");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_Tag_Posts_PostId",
                table: "Post_Tag");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_Tag_Tags_TagId",
                table: "Post_Tag");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_User_Posts_PostId",
                table: "Post_User");

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
                name: "FK_User_Company_Companies_CompanyId",
                table: "User_Company");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tags",
                table: "Tags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Posts",
                table: "Posts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Positions",
                table: "Positions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Levels",
                table: "Levels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FormOfWorks",
                table: "FormOfWorks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Companies",
                table: "Companies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cf0965b-d889-43a9-bd4b-a536f30e6e43");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "404ed05b-ac75-4aec-833c-2de645b5ce9a");

            migrationBuilder.RenameTable(
                name: "Tags",
                newName: "Tag");

            migrationBuilder.RenameTable(
                name: "Posts",
                newName: "Post");

            migrationBuilder.RenameTable(
                name: "Positions",
                newName: "Position");

            migrationBuilder.RenameTable(
                name: "Levels",
                newName: "Level");

            migrationBuilder.RenameTable(
                name: "FormOfWorks",
                newName: "FormOfWork");

            migrationBuilder.RenameTable(
                name: "Companies",
                newName: "Company");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_Form_of_work_id",
                table: "Post",
                newName: "IX_Post_Form_of_work_id");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_Company_id",
                table: "Post",
                newName: "IX_Post_Company_id");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_Category_id",
                table: "Post",
                newName: "IX_Post_Category_id");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_Area_id",
                table: "Post",
                newName: "IX_Post_Area_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tag",
                table: "Tag",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Post",
                table: "Post",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Position",
                table: "Position",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Level",
                table: "Level",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FormOfWork",
                table: "FormOfWork",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Company",
                table: "Company",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0ab4e3ae-f9dd-4779-9b92-62621bd0c3e6", null, "User", "USER" },
                    { "63c73c10-f7cd-4ad6-8617-f28aa61bdcc2", null, "Admin", "ADMIN" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Areas_Area_id",
                table: "Post",
                column: "Area_id",
                principalTable: "Areas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Category_Category_id",
                table: "Post",
                column: "Category_id",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Company_Company_id",
                table: "Post",
                column: "Company_id",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Post_FormOfWork_Form_of_work_id",
                table: "Post",
                column: "Form_of_work_id",
                principalTable: "FormOfWork",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Level_Level_levelId",
                table: "Post_Level",
                column: "levelId",
                principalTable: "Level",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Level_Post_PostId",
                table: "Post_Level",
                column: "PostId",
                principalTable: "Post",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Position_Position_PositionId",
                table: "Post_Position",
                column: "PositionId",
                principalTable: "Position",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Position_Post_PostId",
                table: "Post_Position",
                column: "PostId",
                principalTable: "Post",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Tag_Post_PostId",
                table: "Post_Tag",
                column: "PostId",
                principalTable: "Post",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Tag_Tag_TagId",
                table: "Post_Tag",
                column: "TagId",
                principalTable: "Tag",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Post_User_Post_PostId",
                table: "Post_User",
                column: "PostId",
                principalTable: "Post",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Company_Company_CompanyId",
                table: "User_Company",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Post_Areas_Area_id",
                table: "Post");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_Category_Category_id",
                table: "Post");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_Company_Company_id",
                table: "Post");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_FormOfWork_Form_of_work_id",
                table: "Post");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_Level_Level_levelId",
                table: "Post_Level");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_Level_Post_PostId",
                table: "Post_Level");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_Position_Position_PositionId",
                table: "Post_Position");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_Position_Post_PostId",
                table: "Post_Position");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_Tag_Post_PostId",
                table: "Post_Tag");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_Tag_Tag_TagId",
                table: "Post_Tag");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_User_Post_PostId",
                table: "Post_User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Company_Company_CompanyId",
                table: "User_Company");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tag",
                table: "Tag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Post",
                table: "Post");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Position",
                table: "Position");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Level",
                table: "Level");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FormOfWork",
                table: "FormOfWork");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Company",
                table: "Company");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ab4e3ae-f9dd-4779-9b92-62621bd0c3e6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "63c73c10-f7cd-4ad6-8617-f28aa61bdcc2");

            migrationBuilder.RenameTable(
                name: "Tag",
                newName: "Tags");

            migrationBuilder.RenameTable(
                name: "Post",
                newName: "Posts");

            migrationBuilder.RenameTable(
                name: "Position",
                newName: "Positions");

            migrationBuilder.RenameTable(
                name: "Level",
                newName: "Levels");

            migrationBuilder.RenameTable(
                name: "FormOfWork",
                newName: "FormOfWorks");

            migrationBuilder.RenameTable(
                name: "Company",
                newName: "Companies");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_Post_Form_of_work_id",
                table: "Posts",
                newName: "IX_Posts_Form_of_work_id");

            migrationBuilder.RenameIndex(
                name: "IX_Post_Company_id",
                table: "Posts",
                newName: "IX_Posts_Company_id");

            migrationBuilder.RenameIndex(
                name: "IX_Post_Category_id",
                table: "Posts",
                newName: "IX_Posts_Category_id");

            migrationBuilder.RenameIndex(
                name: "IX_Post_Area_id",
                table: "Posts",
                newName: "IX_Posts_Area_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tags",
                table: "Tags",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Posts",
                table: "Posts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Positions",
                table: "Positions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Levels",
                table: "Levels",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FormOfWorks",
                table: "FormOfWorks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Companies",
                table: "Companies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3cf0965b-d889-43a9-bd4b-a536f30e6e43", null, "Admin", "ADMIN" },
                    { "404ed05b-ac75-4aec-833c-2de645b5ce9a", null, "User", "USER" }
                });

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
                name: "FK_Post_Position_Positions_PositionId",
                table: "Post_Position",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Position_Posts_PostId",
                table: "Post_Position",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_Post_User_Posts_PostId",
                table: "Post_User",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_User_Company_Companies_CompanyId",
                table: "User_Company",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
