using Microsoft.AspNet.Identity;
using System.Threading.Tasks;
using UniformUIKit.Models;

namespace UniformUIKit.Migrations
{
    public partial class SeedDataInitializer
    {
        private AppDbContext _ctx;
        private UserManager<AdminUser> _userManager;

        public SeedDataInitializer(AppDbContext ctx, UserManager<AdminUser> userManager)
        {
            _ctx = ctx;
            _userManager = userManager;
        }

        public async Task InitializeDataAsync()
        {
            await SeedAdminUsersAsync();
        }
    }
}