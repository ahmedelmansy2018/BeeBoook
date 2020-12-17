using System;
using System.Collections.Generic;
using System.Text;
using BeeBook.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BeeBook.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books  { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = " Books-Progrmming" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Books-Politics" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Books-Historical" });

            //seed Books

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 1,
                Name = " APIS Book",
                Price = 12.95M,
                ShortDescription = " famous  Books!",
                LongDescription =
                    "",
                CategoryId = 1,
                ImageUrl = "",
                InStock = true,
                IsBookOfTheWeek = true,
                ImageThumbnailUrl = "",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 2,
                Name = " APIS Book",
                Price = 12.95M,
                ShortDescription = " famous  Books!",
                LongDescription =
                    "",
                CategoryId = 1,
                ImageUrl = "",
                InStock = true,
                IsBookOfTheWeek = true,
                ImageThumbnailUrl = "",

            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 3,
              
                Name = " APIS Book",
                Price = 12.95M,
                ShortDescription = " famous  Books!",
                LongDescription =
                    "",
                CategoryId = 1,
                ImageUrl = "",
                InStock = true,
                IsBookOfTheWeek = true,
                ImageThumbnailUrl = "",

            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 4,
                Name = " APIS Book",
                Price = 12.95M,
                ShortDescription = " famous  Books!",
                LongDescription =
                    "",
                CategoryId = 2,
                ImageUrl = "",
                InStock = true,
                IsBookOfTheWeek = true,
                ImageThumbnailUrl = "",
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 5,
                Name = " APIS Book",
                Price = 12.95M,
                ShortDescription = " famous  Books!",
                LongDescription =
                    "",
                CategoryId = 3,
                ImageUrl = "",
                InStock = true,
                IsBookOfTheWeek = true,
                ImageThumbnailUrl = "",
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 6,
                Name = " APIS Book",
                Price = 12.95M,
                ShortDescription = " famous  Books!",
                LongDescription =
                    "",
                CategoryId = 2,
                ImageUrl = "",
                InStock = true,
                IsBookOfTheWeek = true,
                ImageThumbnailUrl = "",
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 7,
                Name = " APIS Book",
                Price = 12.95M,
                ShortDescription = " famous  Books!",
                LongDescription =
                    "",
                CategoryId = 2,
                ImageUrl = "",
                InStock = true,
                IsBookOfTheWeek = true,
                ImageThumbnailUrl = "",
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 8,
                Name = "Pumpkin Book",
                Price = 12.95M,
                ShortDescription = "Our  favorite",
                LongDescription ="",
                CategoryId = 3,
                ImageUrl = "",
                InStock = true,
                IsBookOfTheWeek = true,
                ImageThumbnailUrl = "",
                AllergyInformation = ""
            });


            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 9,
                Name = "Rhubarb Book",
                Price = 15.95M,
                ShortDescription = "My God, so sweet!",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Book chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Book muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Book cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 1,
                ImageUrl = "",
                InStock = true,
                IsBookOfTheWeek = true,
                ImageThumbnailUrl = "",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 10,
                Name = " APIS Book",
                Price = 12.95M,
                ShortDescription = " famous  Books!",
                LongDescription =
                    "",
                CategoryId = 3,
                ImageUrl = "",
                InStock = true,
                IsBookOfTheWeek = true,
                ImageThumbnailUrl = "",
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 11,
                Name = " APIS Book",
                Price = 12.95M,
                ShortDescription = " famous  Books!",
                LongDescription =
                    "",
                CategoryId = 3,
                ImageUrl = "",
                InStock = true,
                IsBookOfTheWeek = true,
                ImageThumbnailUrl = "",
            });
        }

    }
}
