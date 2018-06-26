using FSociety.Domain.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSociety.Domain.Concrete
{
    public class EFDbContext: IdentityDbContext<IdentityUser>
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
