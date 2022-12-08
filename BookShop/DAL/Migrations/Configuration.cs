namespace DAL.Migrations
{
    using DAL.EF.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.EF.BookContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.EF.BookContext context)
        {
            string[] categories = new string[] {"Novel","Sc. Fiction","Story","Comic","History","Horror" };
            List<Category> cts = new List<Category>();
            foreach (var item in categories)
            {
                cts.Add(new Category
                {
                    Name = item
                }); ;
            }
            context.Categories.AddOrUpdate(cts.ToArray());
            List<Book> books = new List<Book>();
            string[] authors = new string[] { "J.K", "H.P", "H.A", "M.A", "D.F" };
            Random rand = new Random();
            for (int i = 1; i <= 100; i++) {
                books.Add(new Book()
                {
                    Name = Guid.NewGuid().ToString().Substring(0, 20),
                    Author = authors[rand.Next(0,5)],
                    Price = rand.NextDouble(),
                    CategoryId = rand.Next(1,6)
                });
                ;
            }
            context.Books.AddOrUpdate(books.ToArray());
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
