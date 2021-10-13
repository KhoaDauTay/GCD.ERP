using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class EditRoleEnum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "708ab809-41bd-42c5-bc78-8150d5a8e3ad");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5512a049-bd5c-4d08-aee1-365339f1dbda", "5c0e3f75-c9df-4687-b03e-a50a9f0dbacb" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "61020bb4-9307-47b0-afbd-7aa6de8d9706", "84614ab6-33cd-40a8-a52e-641b2bcf3e47" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5c0e3f75-c9df-4687-b03e-a50a9f0dbacb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84614ab6-33cd-40a8-a52e-641b2bcf3e47");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "5512a049-bd5c-4d08-aee1-365339f1dbda");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "61020bb4-9307-47b0-afbd-7aa6de8d9706");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "FullName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "84614ab6-33cd-40a8-a52e-641b2bcf3e47", 0, "15ee7350-1345-480a-9bf4-dd6cc1ca07df", "admin@gmail.com", true, null, "Admin FullName", null, false, null, "admin@gmail.com", "ADMIN", "AQAAAAEAACcQAAAAECZWOiOJrmaaigfIHEwATEeBTyndCfir/z3BnLeApgFP/W27/8OZ45Ra+9JKohJ6bw==", null, true, "4fe1aaa5-735d-405b-9ef8-992c7477b308", false, "admin" },
                    { "5c0e3f75-c9df-4687-b03e-a50a9f0dbacb", 0, "31ad3366-517b-4331-9cd2-6f5db6f90f1f", "basic@gmail.com", true, null, "Basic FullName", null, false, null, null, null, "AQAAAAEAACcQAAAAEHCf7a8eiVFxrXwtxbPXviAH8ilv5SRXjeWoazOIieZwSrfhvQbNVarpEBO9AY5kYQ==", null, true, "c477f035-9946-4e7e-897d-ecb476ef0d09", false, "basic" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "61020bb4-9307-47b0-afbd-7aa6de8d9706", "84f95127-03a9-46c7-942f-081c257acbb5", "Admin", "ADMIN" },
                    { "5512a049-bd5c-4d08-aee1-365339f1dbda", "ad94b7bc-0496-4ccd-a5d7-4c94dde15ecb", "Basic", "BASIC" },
                    { "708ab809-41bd-42c5-bc78-8150d5a8e3ad", "30ff3043-77fb-431e-a080-6b844a8c5dc8", "Default", "DEFAULT" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "61020bb4-9307-47b0-afbd-7aa6de8d9706", "84614ab6-33cd-40a8-a52e-641b2bcf3e47" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5512a049-bd5c-4d08-aee1-365339f1dbda", "5c0e3f75-c9df-4687-b03e-a50a9f0dbacb" });
        }
    }
}
