namespace RestApi.Migrations.DataMigrations
{
    using API.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RestApi.Infrastructure.DBServiceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\DataMigrations";
        }

        protected override void Seed(RestApi.Infrastructure.DBServiceContext context)
        {
            context.Categories.AddOrUpdate(
                p => p.Id,
                new Category() { Id = 1, Name = "Electronics" },
                new Category() { Id = 2, Name = "Motors" },
                new Category() { Id = 3, Name = "Real Estate" },
                new Category() { Id = 4, Name = "Phones & Mobile Phones" },
                new Category() { Id = 5, Name = "Furnitures & Accessories" },
                new Category() { Id = 6, Name = "Animals" }
            );

            context.Subcategories.AddOrUpdate(
                p => p.Id,

                // Category 1
                new Subcategory() { Id = 1, Name = "Desktop PC's", CategoryId = 1 },
                new Subcategory() { Id = 2, Name = "Laptops & Notebooks", CategoryId = 1 },
                new Subcategory() { Id = 3, Name = "Monitors & Screens", CategoryId = 1 },
                new Subcategory() { Id = 4, Name = "Games-Gaming", CategoryId = 1 },
                new Subcategory() { Id = 5, Name = "Printers & Scanners", CategoryId = 1 },
                new Subcategory() { Id = 6, Name = "TVs", CategoryId = 1 },
                new Subcategory() { Id = 7, Name = "CD Players", CategoryId = 1 },
                new Subcategory() { Id = 8, Name = "Digital Camera's", CategoryId = 1 },
                new Subcategory() { Id = 9, Name = "Satellite Dishes & Receivers", CategoryId = 1 },
                new Subcategory() { Id = 10, Name = "Others...", CategoryId = 1 },

                // Category 2
                new Subcategory() { Id = 11, Name = "Cars", CategoryId = 2 },
                new Subcategory() { Id = 12, Name = "Motorbike & Scooters", CategoryId = 2 },
                new Subcategory() { Id = 13, Name = "Vans & Trucks", CategoryId = 2 },
                new Subcategory() { Id = 14, Name = "Car Parts & Accessories", CategoryId = 2 },
                new Subcategory() { Id = 15, Name = "Motorbike Parts & Accessories", CategoryId = 2 },
                new Subcategory() { Id = 16, Name = "Other…", CategoryId = 2 },

                // Category 3
                new Subcategory() { Id = 17, Name = "Houses for Rent", CategoryId = 3 },
                new Subcategory() { Id = 18, Name = "Flats for Rent", CategoryId = 3 },
                new Subcategory() { Id = 19, Name = "Commercials for Rent", CategoryId = 3 },
                new Subcategory() { Id = 20, Name = "Houses for Sale", CategoryId = 3 },
                new Subcategory() { Id = 21, Name = "Flats for Sale", CategoryId = 3 },
                new Subcategory() { Id = 22, Name = "Commercials for Sale", CategoryId = 3 },
                new Subcategory() { Id = 23, Name = "Land", CategoryId = 3 },

                // Category 4
                new Subcategory() { Id = 24, Name = "Mobile & Smart Phones", CategoryId = 4 },
                new Subcategory() { Id = 25, Name = "Mobile Phones Accessories", CategoryId = 4 },
                new Subcategory() { Id = 26, Name = "Home Phones", CategoryId = 4 },

                // Category 5
                new Subcategory() { Id = 27, Name = "Beds & Mattresses", CategoryId = 5 },
                new Subcategory() { Id = 28, Name = "Desks", CategoryId = 5 },
                new Subcategory() { Id = 29, Name = "Tables", CategoryId = 5 },
                new Subcategory() { Id = 30, Name = "Chairs", CategoryId = 5 },
                new Subcategory() { Id = 31, Name = "Sofas", CategoryId = 5 },
                new Subcategory() { Id = 32, Name = "Bookcases", CategoryId = 5 },
                new Subcategory() { Id = 33, Name = "Kitchenware", CategoryId = 5 },
                new Subcategory() { Id = 34, Name = "Other...", CategoryId = 5 },

                // Category 6
                new Subcategory() { Id = 35, Name = "Equipments & Accessories", CategoryId = 6 },
                new Subcategory() { Id = 36, Name = "Dogs", CategoryId = 6 },
                new Subcategory() { Id = 37, Name = "Cats", CategoryId = 6 },
                new Subcategory() { Id = 38, Name = "Fishes", CategoryId = 6 },
                new Subcategory() { Id = 39, Name = "Pets for Adoption", CategoryId = 6 },
                new Subcategory() { Id = 40, Name = "Other...", CategoryId = 6 }
            );
        }
    }
}
