using Tee.PerfectChannel.WebApi.Entities;

namespace Tee.PerfectChannel.WebApi.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Tee.PerfectChannel.WebApi.ItemsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ItemsContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data. E.g.
            //

            context.Items.AddOrUpdate(
              p => p.Id,
                new Item { Name = "Apples", Description = "Fruit", Stock = 5, Price = 2.5 },
                new Item { Name = "Bread", Description = "Loaf", Stock = 5, Price = 1.35 },
                new Item { Name = "Oranges", Description = "Fruit", Stock = 5, Price = 2.99 },
                new Item { Name = "Milk", Description = "Milk", Stock = 5, Price = 2.07 },
                new Item { Name = "Chocolate", Description = "Bars", Stock = 5, Price = 1.79 }
            );

            context.Baskets.AddOrUpdate(
              p => p.Id,
                new Basket { Id = 1, UserId = 1 }
            );

            context.Users.AddOrUpdate(
              p => p.Id,
                new User { Id = 1, Name = "First User" }
            );
        }
    }
}