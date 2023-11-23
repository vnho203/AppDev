using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AppDev.Migrations
{
    /// <inheritdoc />
    public partial class AddCToTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Display",
                table: "Categories",
                newName: "DisplayOrder");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, "So scary", 2, "Horror" },
                    { 2, "Hello", 3, "Action" },
                    { 3, "A lot of roman stories", 1, "Roman" },
                    { 4, "So difficult", 4, "Science" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.RenameColumn(
                name: "DisplayOrder",
                table: "Categories",
                newName: "Display");
        }
    }
}
