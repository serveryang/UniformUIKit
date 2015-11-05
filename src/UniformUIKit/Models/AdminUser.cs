using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniformUIKit.Models
{
    // Add profile data for application users by adding properties to the AdminUser class

    [Table("AdminUsers")]
    public class AdminUser : IdentityUser { }

    [Table("AdminRoles")]
    public class AdminRole : IdentityRole
    {
        public AdminRole() : base()
        {
        }

        public AdminRole(string roleName) : base(roleName)
        {
        }
    }

    //[Table("AdminUserRoles")]
    //public class AdminUserRole : IdentityUserRole<string>
    //{
    //    [ForeignKey("RoleId")]
    //    public virtual AdminRole AdminRole { get; set; }

    //    public override string RoleId
    //    {
    //        get { return base.RoleId; }

    //        set { base.RoleId = value; }
    //    }

    //    [ForeignKey("UserId")]
    //    public virtual AdminUser AdminUser { get; set; }

    //    public override string UserId
    //    {
    //        get { return base.UserId; }

    //        set { base.UserId = value; }
    //    }
    //}

    //[Table("AdminUserLogins")]
    //public class AdminUserLogin : IdentityUserLogin<string>
    //{
    //    [ForeignKey("UserId")]
    //    public virtual AdminUser AdminUser { get; set; }

    //    public override string UserId
    //    {
    //        get { return base.UserId; }

    //        set { base.UserId = value; }
    //    }
    //}

    //[Table("AdminUserClaims")]
    //public class AdminUserClaim : IdentityUserClaim<string>
    //{
    //    [ForeignKey("UserId")]
    //    public virtual AdminUser AdminUser { get; set; }

    //    public override string UserId
    //    {
    //        get { return base.UserId; }

    //        set { base.UserId = value; }
    //    }
    //}

    //[Table("AdminRoleClaims")]
    //public class AdminRoleClaim : IdentityRoleClaim<string>
    //{
    //    [ForeignKey("RoleId")]
    //    public virtual AdminRole AdminRole { get; set; }

    //    public override string RoleId
    //    {
    //        get { return base.RoleId; }

    //        set { base.RoleId = value; }
    //    }
    //}
}