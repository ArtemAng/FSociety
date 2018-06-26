namespace FSociety.Domain.Migrations
{
    using FSociety.Domain.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FSociety.Domain.Concrete.EFDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FSociety.Domain.Concrete.EFDbContext context)
        {
            context.Novels.AddOrUpdate(
                h => h.Name,
                new Novel
                {
                    Name = "Hall 1",
                    Ñontent = "dasdasdas"
                },
                new Novel
                {
                    Name = "Hall 2",
                    Ñontent = "dasdasdas2"
                });

            //context.SaveChanges();

        }
    }
}
