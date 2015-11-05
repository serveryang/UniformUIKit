using Microsoft.Framework.DependencyInjection;
using System;
using System.Threading.Tasks;
using UniformUIKit.Models;

namespace UniformUIKit.Migrations
{
    public partial class SeedDataInitializer
    {
        public static async Task SeedAsync(IServiceProvider serviceProvider)
        {
            using (var db = serviceProvider.GetRequiredService<AppDbContext>())
            {
                //if (await db.Database.EnsureCreatedAsync())
                //{
                //    await SeedAdminUsersAsync(serviceProvider);
                //}
                await SeedAdminUsersAsync(serviceProvider);
            }
        }
    }
}