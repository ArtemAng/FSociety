using FSociety.Domain.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;

namespace FSociety.Domain.Concrete
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<Novel> UserSteps { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            return userIdentity;
        }
    }

    public class EFDbContext: IdentityDbContext<ApplicationUser>
    {
        public EFDbContext() : base("EFDbContext")
        {

        }

        public DbSet<Novel> Novels { get; set; }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
