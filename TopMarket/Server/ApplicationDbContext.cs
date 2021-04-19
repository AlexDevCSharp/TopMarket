using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TopMarket.Shared.Entities;

namespace TopMarket.Server
{ 
    public class ApplicationDbContext:IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
             : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            var countries = new List<Country>()
            {
                new Country(){Id = 1, Name = "Dominican Republic"},
                new Country(){Id = 2, Name = "United States" }
            };

            builder.Entity<Country>().HasData(countries);

            var states = new List<State>() {
              new State {Id = 1, Name = "Santo Domingo", CountryId = 1},
              new State {Id = 2, Name = "San Cristobal", CountryId = 1},
              new State {Id = 3, Name = "Vermont", CountryId = 2},
              new State {Id = 4, Name = "New York", CountryId = 2}
            };

            builder.Entity<State>().HasData(states);

            var people = new List<Person>();
            for (int i = 6; i < 15; i++)
            {
                people.Add(new Person() { Id = i, Name = $"Person {i}", StateId = 1 });
            }

            builder.Entity<Person>().HasData(people);

            var categories = new List<Category>()
            {
                new Category() { Id = 1, Name = "fruit and vegie" },
                new Category() { Id = 2, Name = "meat" },
                new Category() { Id = 3, Name = "bakaley" }
            };

            builder.Entity<Category>().HasData(categories);

            var subcategory = new List<Subcategory>() {
                new Subcategory() { Id = 1, Name = "fruit", CategoryId=1 },
                new Subcategory() { Id = 2, Name = "vegi", CategoryId=1 },
                new Subcategory() { Id = 3, Name = "pork", CategoryId=2  },
                new Subcategory() { Id = 4, Name = "veal", CategoryId=2  },
                new Subcategory() { Id = 5, Name = "lamb", CategoryId=2  },
                new Subcategory() { Id = 6, Name = "bread", CategoryId=3 }
            };

            builder.Entity<Subcategory>().HasData(subcategory);

            var products = new List<Product>() {
                new Product() { Id = 1, Price = 15.50, Brand = "Ukraine", Title="Apple", Summary="Green", SubcatId=1, Weight=500, Poster="https://topmarketstorageaccount.blob.core.windows.net/products/14c5172d-a00f-48ca-9f3b-a642a05e312d.jpg" },
                new Product() { Id = 2, Price = 35, Brand = "Juicy", Title="Orange", Summary="Juicy", SubcatId=1, Weight=500, Poster="https://topmarketstorageaccount.blob.core.windows.net/products/18429064-d0a9-4ffa-a24e-1b459964189e.jpg" },
                new Product() { Id = 3, Price = 350, Brand = "Myasokombinat", Title="Steak", Summary="NY", SubcatId=4, Weight=100, Poster="https://topmarketstorageaccount.blob.core.windows.net/products/8e3bd231-cdcc-4311-9dd7-c9aa1ca5271e.jpg" },
                new Product() { Id = 4, Price = 180, Brand = "Myasokombinat", Title="Ribs", Summary="Frozen", SubcatId=3, Weight=250, Poster="https://topmarketstorageaccount.blob.core.windows.net/products/04dbca64-0d49-4b7a-8414-ac955e1931da.jpg" },
                new Product() { Id = 5, Price = 17.30, Brand = "Darnica", Title="Bagget", Summary="Fresh", SubcatId=6, Weight=100, Poster="https://topmarketstorageaccount.blob.core.windows.net/products/ec4256c5-588e-4aa8-84c6-81114d2807f6.jpg" },
                new Product() { Id = 6, Price = 8.90, Brand = "Odessa", Title="Potato", Summary="Big", SubcatId=2, Weight=500, Poster="https://topmarketstorageaccount.blob.core.windows.net/products/3c339ec1-26a6-42de-af6d-86812d7dc140.jpg" },
            };

            builder.Entity<Product>().HasData(products);

            var userAdminId = "df4d3070-5e26-4f78-bdd6-f9bb12f55a40";

            var hasher = new PasswordHasher<IdentityUser>();

            var userAdmin = new IdentityUser()
            {
                Id = userAdminId,
                Email = "alexshefer1991@hotmail.com",
                UserName = "alexshefer1991@hotmail.com",
                NormalizedEmail = "alexshefer1991@hotmail.com",
                NormalizedUserName = "alexshefer1991@hotmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Aa123456!")
            };

            builder.Entity<IdentityUser>().HasData(userAdmin);

            builder.Entity<IdentityUserClaim<string>>()
                .HasData(new IdentityUserClaim<string>()
                {
                    Id = 1,
                    ClaimType = ClaimTypes.Role,
                    ClaimValue = "Admin",
                    UserId = userAdminId
                });

            base.OnModelCreating(builder);
        }



        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Discount> Discounts { get; set; }
    }
}
