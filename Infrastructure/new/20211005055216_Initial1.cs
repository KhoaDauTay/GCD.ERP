using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.@new
{
    public partial class Initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "fd76e6e4-2847-45e6-84c6-6fa045e7c75e", 0, "3146c23c-fdf0-4fd0-b3b0-94f975fd3038", "admin@gmail.com", true, "Admin FullName", false, null, null, "ADMIN", "AQAAAAEAACcQAAAAELon98XZfajgjcobtV/3ZemITtO8gtOlWvwcMWCmgFG1HbyLb5GNbt806HjNhO4elA==", null, true, "c0df6a11-aa99-40f6-ba5d-be53760590b5", false, "admin" },
                    { "b8cfb351-e948-45c3-9c7d-367845b8ee8c", 0, "3b6eed7f-f9e4-45af-9b89-8ece80fcc046", "basic@gmail.com", true, "Basic FullName", false, null, null, null, "AQAAAAEAACcQAAAAEHnwT5sh3SsorysM62TyH2W54lURH16Hha/PuKiNtDoaUAPSf3dcEBZjQdFviuyZrA==", null, true, "07660776-5f74-49c3-904b-580f6c20a25c", false, "basic" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6b197e5f-0d23-4865-952a-435b3e32ebea", "3fa159f6-4484-4413-b4e8-fcef27586c9e", "Admin", "ADMIN" },
                    { "b263b7c3-c01a-466f-a54e-72e85d2a8763", "3a39630c-401f-4d89-968b-33ffad558984", "Basic", "BASIC" },
                    { "bbcb0c0b-cee8-4687-84e4-e61e9d00520b", "2f94f50a-8f58-4abd-9117-3ab0c0f10dd8", "Default", "DEFAULT" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6b197e5f-0d23-4865-952a-435b3e32ebea", "fd76e6e4-2847-45e6-84c6-6fa045e7c75e" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b263b7c3-c01a-466f-a54e-72e85d2a8763", "b8cfb351-e948-45c3-9c7d-367845b8ee8c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "bbcb0c0b-cee8-4687-84e4-e61e9d00520b");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b263b7c3-c01a-466f-a54e-72e85d2a8763", "b8cfb351-e948-45c3-9c7d-367845b8ee8c" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6b197e5f-0d23-4865-952a-435b3e32ebea", "fd76e6e4-2847-45e6-84c6-6fa045e7c75e" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8cfb351-e948-45c3-9c7d-367845b8ee8c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd76e6e4-2847-45e6-84c6-6fa045e7c75e");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "6b197e5f-0d23-4865-952a-435b3e32ebea");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "b263b7c3-c01a-466f-a54e-72e85d2a8763");

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
    }
}
