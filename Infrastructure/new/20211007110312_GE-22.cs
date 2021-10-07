using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.@new
{
    public partial class GE22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "d8e7e0f5-3438-4991-8e77-ee3021707986", 0, "c8eb1d0c-18e0-4785-906a-88076b78e69a", "admin@gmail.com", true, "Admin FullName", false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEBsoU/2bEALdTAn6rL9tfBxIJ6qpPXVb1rjvEf6HEqd5Tm6c6oOFQDbCGarl5BCzFg==", null, true, "e0f9002e-1439-4465-8cf4-ed0033bd8167", false, "admin" },
                    { "c8eb03e9-255d-4bea-a1bb-10a28f0a65b3", 0, "6d35cae1-ec6d-49fa-a432-8ecd46ada38a", "basic@gmail.com", true, "Basic FullName", false, null, null, null, "AQAAAAEAACcQAAAAELrZcr8gZlpvfbHqfyC3H9CF2uWwD5zsjSJ8YBDdhirkiIJjE3ptqJmvyixQSqRE7g==", null, true, "41e6f0ce-83c2-4670-8dc6-48e91536dab5", false, "basic" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4b70bb35-29d3-4983-87de-3303198ec5f9", "7433e718-873b-4cba-bbb1-066513909604", "Admin", "ADMIN" },
                    { "13ad4163-612b-4bc7-ad3e-b03375d8103b", "01ed6d0d-63c7-4271-a314-ae02193d08f1", "Basic", "BASIC" },
                    { "6979b721-988d-448f-aabe-f225d6d8c3dc", "949e458c-7ff5-491b-a104-b9922e1a2770", "Default", "DEFAULT" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4b70bb35-29d3-4983-87de-3303198ec5f9", "d8e7e0f5-3438-4991-8e77-ee3021707986" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "13ad4163-612b-4bc7-ad3e-b03375d8103b", "c8eb03e9-255d-4bea-a1bb-10a28f0a65b3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "6979b721-988d-448f-aabe-f225d6d8c3dc");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "13ad4163-612b-4bc7-ad3e-b03375d8103b", "c8eb03e9-255d-4bea-a1bb-10a28f0a65b3" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4b70bb35-29d3-4983-87de-3303198ec5f9", "d8e7e0f5-3438-4991-8e77-ee3021707986" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c8eb03e9-255d-4bea-a1bb-10a28f0a65b3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8e7e0f5-3438-4991-8e77-ee3021707986");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "13ad4163-612b-4bc7-ad3e-b03375d8103b");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "4b70bb35-29d3-4983-87de-3303198ec5f9");

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
    }
}
