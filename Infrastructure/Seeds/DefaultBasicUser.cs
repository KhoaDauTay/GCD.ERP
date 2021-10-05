using System.Linq;
using System.Threading.Tasks;
using Application.Enums;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Seeds
{
    public static class DefaultBasicUser
    {
        public static void Seed(this ModelBuilder builder)
        {
            #region RoleData

            var adminRole = new IdentityRole()
            {
                Name = "Admin",
                NormalizedName = "ADMIN",
            };
            var basicRole = new IdentityRole()
            {
                Name = "Basic",
                NormalizedName = "BASIC",
            };
            var defaultRole = new IdentityRole()
            {
                Name = "Default",
                NormalizedName = "DEFAULT",
            };
            builder.Entity<IdentityRole>().HasData(
                adminRole,
                basicRole,
                defaultRole
            );

            #endregion RoleData

            #region UserData

            var hasher = new PasswordHasher<User>();
            var admin = new User()
            {
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                FullName = "Admin FullName",
                Email = "admin@gmail.com",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Admin@123"),
            };
            var basic = new User()
            {
                UserName = "basic",
                FullName = "Basic FullName",
                Email = "basic@gmail.com",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Basic@123"),
            };
            builder.Entity<User>().HasData(
                admin,
                basic
            );

            #endregion UserData

            #region UserRole

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> {UserId = admin.Id, RoleId = adminRole.Id},
                new IdentityUserRole<string> {UserId = basic.Id, RoleId = basicRole.Id}
            );

            #endregion UserRole
        }
    }
}