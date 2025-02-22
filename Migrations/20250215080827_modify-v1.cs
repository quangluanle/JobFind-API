using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobFind_BE.Migrations
{
    /// <inheritdoc />
    public partial class modifyv1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Areas_Areaid",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Categories_Categoryid",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Companies_Companyid",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_FormOfWorks_FormOfWorkid",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_Areaid",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_Categoryid",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_Companyid",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_FormOfWorkid",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Areaid",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Categoryid",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Companyid",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "FormOfWorkid",
                table: "Posts");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_area_id",
                table: "Posts",
                column: "area_id");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_category_id",
                table: "Posts",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_company_id",
                table: "Posts",
                column: "company_id");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_form_of_work_id",
                table: "Posts",
                column: "form_of_work_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Areas_area_id",
                table: "Posts",
                column: "area_id",
                principalTable: "Areas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Categories_category_id",
                table: "Posts",
                column: "category_id",
                principalTable: "Categories",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Companies_company_id",
                table: "Posts",
                column: "company_id",
                principalTable: "Companies",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_FormOfWorks_form_of_work_id",
                table: "Posts",
                column: "form_of_work_id",
                principalTable: "FormOfWorks",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Areas_area_id",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Categories_category_id",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Companies_company_id",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_FormOfWorks_form_of_work_id",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_area_id",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_category_id",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_company_id",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_form_of_work_id",
                table: "Posts");

            migrationBuilder.AddColumn<int>(
                name: "Areaid",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Categoryid",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Companyid",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FormOfWorkid",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_Areaid",
                table: "Posts",
                column: "Areaid");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_Categoryid",
                table: "Posts",
                column: "Categoryid");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_Companyid",
                table: "Posts",
                column: "Companyid");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_FormOfWorkid",
                table: "Posts",
                column: "FormOfWorkid");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Areas_Areaid",
                table: "Posts",
                column: "Areaid",
                principalTable: "Areas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Categories_Categoryid",
                table: "Posts",
                column: "Categoryid",
                principalTable: "Categories",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Companies_Companyid",
                table: "Posts",
                column: "Companyid",
                principalTable: "Companies",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_FormOfWorks_FormOfWorkid",
                table: "Posts",
                column: "FormOfWorkid",
                principalTable: "FormOfWorks",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
