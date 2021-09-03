using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPNETCoreWebAPIJWTTutorial.Migrations
{
    public partial class RolesSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4fc6cb20-a896-4117-b2fc-13f83de5a35c", "d3ac15a0-741e-4a6a-9618-d241f6f7efa1", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "96753bf5-0bc4-4216-ba2c-7a814ab67f9d", "177bafe2-1fcd-47b3-86de-55d5150f8367", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4fc6cb20-a896-4117-b2fc-13f83de5a35c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96753bf5-0bc4-4216-ba2c-7a814ab67f9d");
        }
    }
}
