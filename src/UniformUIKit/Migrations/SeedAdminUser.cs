using System.Security.Claims;
using System.Threading.Tasks;
using UniformUIKit.Models;

namespace UniformUIKit.Migrations
{
    public partial class SeedDataInitializer
    {
        private async Task SeedAdminUsersAsync()
        {
            var adminUserEmail = "serveryang@qq.com";
            var adminUser = await _userManager.FindByEmailAsync(adminUserEmail);

            if (adminUser == null)
            {
                adminUser = new AdminUser { UserName = adminUserEmail, Email = adminUserEmail };

                var result = await _userManager.CreateAsync(adminUser, "!QAZ2wsx");
                await _userManager.AddClaimAsync(adminUser, new Claim("ManageStore", "Allowed"));
            }
        }
    }
}