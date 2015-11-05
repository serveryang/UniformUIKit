using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;

namespace UniformUIKit.Models
{
    public partial class AppDbContext : IdentityDbContext<AdminUser, AdminRole, string>
    {
        public DbSet<AdminUser> AdminUsers { get; set; }
        public DbSet<AdminRole> AdminRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            //builder.Entity<AdminUserRole>().HasKey(t => new { t.UserId, t.RoleId });
            //builder.Entity<AdminUserLogin>().HasKey(l => new { l.LoginProvider, l.ProviderKey });

            builder.Entity<AdminUser>().ToTable("AdminUsers");
            builder.Entity<AdminRole>().ToTable("AdminRoles");

            builder.Entity<IdentityUserLogin<string>>().ToTable("AdminUserLogins");
            builder.Entity<IdentityUserClaim<string>>().ToTable("AdminUserClaims");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("AdminRoleClaims");
            builder.Entity<IdentityUserRole<string>>().ToTable("AdminUserRoles");
        }
    }
}