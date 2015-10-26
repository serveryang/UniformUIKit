using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;

namespace UniformUIKit.Models
{
    public partial class AppDbContext : IdentityDbContext<AdminUser>
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            builder.Entity<AdminUser>().ToTable("AdminUsers");
            builder.Entity<IdentityRole>().ToTable("AdminUserRoles");
            builder.Entity<IdentityUserRole<string>>().ToTable("AdminUserUserRoles");
            builder.Entity<IdentityUserClaim<string>>().ToTable("AdminUserUserClaims");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("AdminUserRoleClaims");
            builder.Entity<IdentityUserLogin<string>>().ToTable("AdminUserUserLogins");

            Seed();
        }

        protected void Seed()
        {
        }
    }
}
