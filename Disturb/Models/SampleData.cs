using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Disturb.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<DisturbEntities>
    {
        protected override void Seed(DisturbEntities context)
        {
            var categories = new List<Category>
            {
                new Category { Name = "Поли" },
                new Category { Name = "Рокли" },
                new Category { Name = "Панталони" },
                new Category { Name = "Тениски" },
                new Category { Name = "Суитчери" },
                new Category { Name = "Обеци" }
            };

            var brands = new List<Brand>
            {
                new Brand { Name = "Brand 1" },
                new Brand { Name = "Brand 2" },
                new Brand { Name = "Brand 3" },
                new Brand { Name = "Brand 4" }
            };

            new List<Product>
            {
                new Product { Code = "R1", Description = "Роклята", Category = categories.Single(g => g.Name == "Рокли"), Price = 8.99M, Brand = brands.Single(a => a.Name == "Brand 1"), PicUrl = "/Content/Images/placeholder.gif" },
                new Product { Code = " T1", Description = "Тениската", Category = categories.Single(g => g.Name == "Тениски"), Price = 8.99M, Brand = brands.Single(a => a.Name == "Brand 1"), PicUrl = "/Content/Images/placeholder.gif" },
                new Product { Code = "O1", Description = "Крави", Category = categories.Single(g => g.Name == "Обеци"), Price = 8.99M, Brand = brands.Single(a => a.Name == "Brand 2"), PicUrl = "/Content/Images/placeholder.gif" },
                
            }.ForEach(a => context.Products.Add(a));
        }
    }
}