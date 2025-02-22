using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobFind_BE.Migrations
{
    /// <inheritdoc />
    public partial class updatetag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Tags",
                newName: "id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "52c49e41-b042-453b-a1aa-d1aad047b3d8", null, "User", "USER" },
                    { "d06240c6-1371-4d2b-ac44-801c7a20d3e8", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
