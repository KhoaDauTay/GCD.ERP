using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.@new
{
    public partial class Initial13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "5287b8e1-cb7d-404b-a835-4057e2e1853e", 0, "dbddcda3-5a65-4f83-805b-e9324c201e01", "admin@gmail.com", true, "Admin FullName", false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEPWPN+19X4ZrnJjVYjU8aRdiTbXyBeWqL0X09W4Z8g7jgH6OOzqCkKJFr7pVfCd5pQ==", null, true, "70086666-49b6-4a56-8601-e1b0eae4b5f1", false, "admin" },
                    { "1e651732-736d-48e3-90a2-f91daa928776", 0, "fa17396b-a277-44fa-8311-41b52eb8e187", "basic@gmail.com", true, "Basic FullName", false, null, null, null, "AQAAAAEAACcQAAAAENIIdvhBEEoHIXaPLC2VVecl61+ZK7vrAg8wigd559rs3uUBFXEW9Iz3h2xDyy8vcQ==", null, true, "2653fcc5-16d3-4ea6-a762-c56600ea61bc", false, "basic" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8c076a28-1b56-4bc9-9a54-92cac3d98763", "b13ab683-6179-4a1a-9e4a-1c667327edcd", "Admin", "ADMIN" },
                    { "7ccfb274-6fbe-451a-9a5e-7a066ed533d5", "2a7f562c-cad6-4a86-8c61-eaed9a2f81d2", "Basic", "BASIC" },
                    { "0c12cf25-685f-412a-84de-aa63c76880cf", "96511d1c-6131-4ba3-a3dd-bd3e2c973282", "Default", "DEFAULT" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8c076a28-1b56-4bc9-9a54-92cac3d98763", "5287b8e1-cb7d-404b-a835-4057e2e1853e" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7ccfb274-6fbe-451a-9a5e-7a066ed533d5", "1e651732-736d-48e3-90a2-f91daa928776" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "0c12cf25-685f-412a-84de-aa63c76880cf");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7ccfb274-6fbe-451a-9a5e-7a066ed533d5", "1e651732-736d-48e3-90a2-f91daa928776" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8c076a28-1b56-4bc9-9a54-92cac3d98763", "5287b8e1-cb7d-404b-a835-4057e2e1853e" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e651732-736d-48e3-90a2-f91daa928776");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5287b8e1-cb7d-404b-a835-4057e2e1853e");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "7ccfb274-6fbe-451a-9a5e-7a066ed533d5");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "8c076a28-1b56-4bc9-9a54-92cac3d98763");

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
    }
}
