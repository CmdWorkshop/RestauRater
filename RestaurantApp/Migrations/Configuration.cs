namespace RestaurantApp.Migrations
{
    using RestaurantApp.Models;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<RestauRaterDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "RestaurantApp.Models.RestauRaterDB";
        }

        protected override void Seed(RestauRaterDB context)
        {
            context.Dishes.AddOrUpdate(d => d.Name,
                    new Dish
                    {
                        Name = "Scallops and Pulled Pork",
                        Description = "Description of scallops and pulled pork",
                        Price = 4.99f
                    },
                    new Dish
                    {
                        Name = "9oz Rump Steak",
                        Description = "Description of rump steak",
                        Price = 14.99f
                    },
                    new Dish
                    {
                        Name = "Chocolate Profiteroles",
                        Description = "Description of profiteroles",
                        Price = 6.49f
                    }
            );
        }
    }
}
