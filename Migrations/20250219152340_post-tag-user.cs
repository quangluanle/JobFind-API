using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobFind_BE.Migrations
{
    /// <inheritdoc />
    public partial class posttaguser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ae26ed39-d28a-4122-be5c-a4868f9b2581");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be6b2e70-9867-435e-8254-80f8d401c454");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "996c6318-ac17-406a-835c-4b90af7b1722", null, "Admin", "ADMIN" },
                    { "a85de4c3-0fee-4394-8721-7b13ddc45982", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "996c6318-ac17-406a-835c-4b90af7b1722");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a85de4c3-0fee-4394-8721-7b13ddc45982");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ae26ed39-d28a-4122-be5c-a4868f9b2581", null, "Admin", "ADMIN" },
                    { "be6b2e70-9867-435e-8254-80f8d401c454", null, "User", "USER" }
                });
        }
    }
}
