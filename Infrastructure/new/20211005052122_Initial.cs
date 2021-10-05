using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.@new
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "78347b99-d9b3-4693-8a83-8d70bbc03d94", 0, "d543851b-f1d0-4671-af09-620726d04582", "admin@gmail.com", true, "Admin FullName", false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEDAbgOmg4ZiHd+RtlE3Gnr+aLkxgbRjNdkkmM33bjyXpYuC/kUiRegptyiaeUZwVCA==", null, true, "6c0d0ca0-12ac-412f-8719-6cc9e4921150", false, "admin" },
                    { "7290793f-31e4-47c8-8752-032b8d951536", 0, "516ba7fd-c639-4ae2-8f6f-5701a6d0d28c", "basic@gmail.com", true, "Basic FullName", false, null, null, null, "AQAAAAEAACcQAAAAEGBAYo7Ih8oGSRegV/4jvtwZYUmKZFBA+ZsDZFrrBi0RCyyUTKsqeIBVJZjbbugGsQ==", null, true, "71ba27c4-edf6-4669-b386-498c59a86673", false, "basic" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "fb00e52c-be3a-4802-ad4b-eb5f1a925739", "a633d634-39f4-455c-817e-4b52825868d6", "Admin", "ADMIN" },
                    { "8197dde8-505c-4ab1-a574-725d37a27903", "2d5a7b30-deb4-4c0b-9c03-e1eb2ad5a41f", "Basic", "BASIC" },
                    { "0b4c3ba6-ed5e-4efb-9011-1cd74b3cac16", "4d565fe0-6650-4b98-a1ba-5bff9e38ffa8", "Default", "DEFAULT" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fb00e52c-be3a-4802-ad4b-eb5f1a925739", "78347b99-d9b3-4693-8a83-8d70bbc03d94" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8197dde8-505c-4ab1-a574-725d37a27903", "7290793f-31e4-47c8-8752-032b8d951536" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "0b4c3ba6-ed5e-4efb-9011-1cd74b3cac16");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8197dde8-505c-4ab1-a574-725d37a27903", "7290793f-31e4-47c8-8752-032b8d951536" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fb00e52c-be3a-4802-ad4b-eb5f1a925739", "78347b99-d9b3-4693-8a83-8d70bbc03d94" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7290793f-31e4-47c8-8752-032b8d951536");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78347b99-d9b3-4693-8a83-8d70bbc03d94");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "8197dde8-505c-4ab1-a574-725d37a27903");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "fb00e52c-be3a-4802-ad4b-eb5f1a925739");
        }
    }
}
