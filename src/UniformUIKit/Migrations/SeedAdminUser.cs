using Microsoft.AspNet.Identity;
using Microsoft.Framework.DependencyInjection;
using System;
using System.Security.Claims;
using System.Threading.Tasks;
using UniformUIKit.Models;

namespace UniformUIKit.Migrations
{
    public partial class SeedDataInitializer
    {
        private static async Task SeedAdminUsersAsync(IServiceProvider serviceProvider)
        {
            const string adminUserEmail = "serveryang@qq.com";
            const string roleName = "Administrator";

            var userManager = serviceProvider.GetRequiredService<UserManager<AdminUser>>();
            var roleManager = serviceProvider.GetRequiredService<RoleManager<AdminRole>>();

            if (!await roleManager.RoleExistsAsync(roleName))
            {
                var adminRole = new AdminRole(roleName);

                await roleManager.CreateAsync(adminRole);
                await roleManager.AddClaimAsync(adminRole, new Claim("ManageRole", "Allowed"));
            }

            var user = await userManager.FindByEmailAsync(adminUserEmail);

            if (user == null)
            {
                user = new AdminUser { UserName = adminUserEmail, Email = adminUserEmail };
                await userManager.CreateAsync(user, "!QAZ2wsx");
                await userManager.AddToRoleAsync(user, roleName);
                await userManager.AddClaimAsync(user, new Claim("ManageStore", "Allowed"));
            }
        }
    }
}