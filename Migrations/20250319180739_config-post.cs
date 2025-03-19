using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobFind_BE.Migrations
{
    /// <inheritdoc />
    public partial class configpost : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: "0158b754-cbf7-473b-b3dc-19aae3130543");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b44836ed-422f-4e47-a2b3-277aa87f011d");

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

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3cf0965b-d889-43a9-bd4b-a536f30e6e43", null, "Admin", "ADMIN" },
                    { "404ed05b-ac75-4aec-833c-2de645b5ce9a", null, "User", "USER" }
                });

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
                name: "IX_AspNetUsers_Email",
                table: "AspNetUsers",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PhoneNumber",
                table: "AspNetUsers",
                column: "PhoneNumber",
                unique: true,
                filter: "[PhoneNumber] IS NOT NULL");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "IX_AspNetUsers_Email",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PhoneNumber",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cf0965b-d889-43a9-bd4b-a536f30e6e43");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "404ed05b-ac75-4aec-833c-2de645b5ce9a");

            migrationBuilder.AddColumn<int>(
                name: "AreasId",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoriesId",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompaniesId",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FormOfWorksId",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0158b754-cbf7-473b-b3dc-19aae3130543", null, "User", "USER" },
                    { "b44836ed-422f-4e47-a2b3-277aa87f011d", null, "Admin", "ADMIN" }
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
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Categories_CategoriesId",
                table: "Posts",
                column: "CategoriesId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Companies_CompaniesId",
                table: "Posts",
                column: "CompaniesId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_FormOfWorks_FormOfWorksId",
                table: "Posts",
                column: "FormOfWorksId",
                principalTable: "FormOfWorks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
