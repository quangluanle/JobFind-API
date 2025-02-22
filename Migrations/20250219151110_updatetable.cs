using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobFind_BE.Migrations
{
    /// <inheritdoc />
    public partial class updatetable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52c49e41-b042-453b-a1aa-d1aad047b3d8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d06240c6-1371-4d2b-ac44-801c7a20d3e8");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Tags",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "Posts",
                newName: "Updated_at");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "Posts",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "Posts",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "salary",
                table: "Posts",
                newName: "Salary");

            migrationBuilder.RenameColumn(
                name: "form_of_work_id",
                table: "Posts",
                newName: "Form_of_work_id");

            migrationBuilder.RenameColumn(
                name: "due_at",
                table: "Posts",
                newName: "Due_at");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Posts",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "Posts",
                newName: "Created_at");

            migrationBuilder.RenameColumn(
                name: "company_id",
                table: "Posts",
                newName: "Company_id");

            migrationBuilder.RenameColumn(
                name: "category_id",
                table: "Posts",
                newName: "Category_id");

            migrationBuilder.RenameColumn(
                name: "benefit",
                table: "Posts",
                newName: "Benefit");

            migrationBuilder.RenameColumn(
                name: "area_id",
                table: "Posts",
                newName: "Area_id");

            migrationBuilder.RenameColumn(
                name: "amount",
                table: "Posts",
                newName: "Amount");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Posts",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_form_of_work_id",
                table: "Posts",
                newName: "IX_Posts_Form_of_work_id");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_company_id",
                table: "Posts",
                newName: "IX_Posts_Company_id");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_category_id",
                table: "Posts",
                newName: "IX_Posts_Category_id");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_area_id",
                table: "Posts",
                newName: "IX_Posts_Area_id");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "Positions",
                newName: "Updated_at");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Positions",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Positions",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "Positions",
                newName: "Created_at");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Positions",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "Levels",
                newName: "Updated_at");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Levels",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "Levels",
                newName: "Created_at");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Levels",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "FormOfWorks",
                newName: "Updated_at");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "FormOfWorks",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "FormOfWorks",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "FormOfWorks",
                newName: "Created_at");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "FormOfWorks",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "website",
                table: "Companies",
                newName: "Website");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "Companies",
                newName: "Updated_at");

            migrationBuilder.RenameColumn(
                name: "thumbnail",
                table: "Companies",
                newName: "Thumbnail");

            migrationBuilder.RenameColumn(
                name: "tax_number",
                table: "Companies",
                newName: "Tax_number");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "Companies",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Companies",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "logo",
                table: "Companies",
                newName: "Logo");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Companies",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "Companies",
                newName: "Created_at");

            migrationBuilder.RenameColumn(
                name: "amount_of_employee",
                table: "Companies",
                newName: "Amount_of_employee");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Companies",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "Categories",
                newName: "Updated_at");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Categories",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "Categories",
                newName: "Created_at");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Categories",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "Areas",
                newName: "Updated_at");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Areas",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "Areas",
                newName: "Created_at");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Areas",
                newName: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ae26ed39-d28a-4122-be5c-a4868f9b2581", null, "Admin", "ADMIN" },
                    { "be6b2e70-9867-435e-8254-80f8d401c454", null, "User", "USER" }
                });

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

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ae26ed39-d28a-4122-be5c-a4868f9b2581");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be6b2e70-9867-435e-8254-80f8d401c454");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Tags",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Updated_at",
                table: "Posts",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Posts",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Posts",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "Salary",
                table: "Posts",
                newName: "salary");

            migrationBuilder.RenameColumn(
                name: "Form_of_work_id",
                table: "Posts",
                newName: "form_of_work_id");

            migrationBuilder.RenameColumn(
                name: "Due_at",
                table: "Posts",
                newName: "due_at");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Posts",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Created_at",
                table: "Posts",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "Company_id",
                table: "Posts",
                newName: "company_id");

            migrationBuilder.RenameColumn(
                name: "Category_id",
                table: "Posts",
                newName: "category_id");

            migrationBuilder.RenameColumn(
                name: "Benefit",
                table: "Posts",
                newName: "benefit");

            migrationBuilder.RenameColumn(
                name: "Area_id",
                table: "Posts",
                newName: "area_id");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Posts",
                newName: "amount");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Posts",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_Form_of_work_id",
                table: "Posts",
                newName: "IX_Posts_form_of_work_id");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_Company_id",
                table: "Posts",
                newName: "IX_Posts_company_id");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_Category_id",
                table: "Posts",
                newName: "IX_Posts_category_id");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_Area_id",
                table: "Posts",
                newName: "IX_Posts_area_id");

            migrationBuilder.RenameColumn(
                name: "Updated_at",
                table: "Positions",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Positions",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Positions",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Created_at",
                table: "Positions",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Positions",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Updated_at",
                table: "Levels",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Levels",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Created_at",
                table: "Levels",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Levels",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Updated_at",
                table: "FormOfWorks",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "FormOfWorks",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "FormOfWorks",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Created_at",
                table: "FormOfWorks",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "FormOfWorks",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Website",
                table: "Companies",
                newName: "website");

            migrationBuilder.RenameColumn(
                name: "Updated_at",
                table: "Companies",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "Thumbnail",
                table: "Companies",
                newName: "thumbnail");

            migrationBuilder.RenameColumn(
                name: "Tax_number",
                table: "Companies",
                newName: "tax_number");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Companies",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Companies",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Logo",
                table: "Companies",
                newName: "logo");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Companies",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Created_at",
                table: "Companies",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "Amount_of_employee",
                table: "Companies",
                newName: "amount_of_employee");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Companies",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Updated_at",
                table: "Categories",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Categories",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Created_at",
                table: "Categories",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Categories",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Updated_at",
                table: "Areas",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Areas",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Created_at",
                table: "Areas",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Areas",
                newName: "id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "52c49e41-b042-453b-a1aa-d1aad047b3d8", null, "User", "USER" },
                    { "d06240c6-1371-4d2b-ac44-801c7a20d3e8", null, "Admin", "ADMIN" }
                });

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
    }
}
