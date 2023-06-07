using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ZortBilgisayarV1.entity;

namespace ZortBilgisayarV1.data.Concrete.SQL.EFCore
{
    public static class SeedDatabe
    {
        public static void Seed()
        {
            var context = new ZortContext();

            if (context.Database.GetPendingMigrations().Count()==0)
            {
                if (context.Categories.Count() == 0)
                {
                    context.Categories.AddRange(Categories);
                    context.SaveChanges();
                    
                }
                if (context.Products.Count() == 0)
                {
                    context.Products.AddRange(Products);
                    context.AddRange(ProductCategories);
                    context.SaveChanges();
                    
                
                }
                
            }
            context.SaveChanges();
        }

        private static Category[] Categories=
        {
            new Category() {Name = "Telefon"},
            new Category() {Name = "Bilgisayar"},
            new Category() {Name = "Elektorink"}
        };

        private static Product[] Products =
        {
            new Product {Name="Iphone ", Price=5000,Battery="5000 mh",Camera="25 MP", describtion="Telefon", ImageUrl="ihpne12.jpg", IsApproved=true},
            new Product {Name="Iphone 5S", Price=6000,Battery="5000 mh",Camera="25 MP", describtion="Telefon", ImageUrl="iphone11.jpg", IsApproved=true},
            new Product {Name="Iphone S3", Price=2300,Battery="5000 mh",Camera="25 MP", describtion="Telefon", ImageUrl="işlemci1.jpg", IsApproved=true},
            new Product {Name="Casper Nirvana", Price=12000, describtion="Bilgisayar",GPU="Asus RTX 2060", CPU="AMD RYzen 5 5600", ImageUrl="pc1.jpg", IsApproved=true},
            new Product {Name="Macbook Pro 2", Price=25000, describtion="Bilgisayar",GPU="Asus RTX 2060", CPU="AMD RYzen 5 5600", ImageUrl="pc2.jpg", IsApproved=true}
        };

        private static ProductCategory[] ProductCategories =
        {
            new ProductCategory {Product=Products[0],Category=Categories[0]},
            new ProductCategory {Product=Products[0],Category=Categories[2]},

            new ProductCategory {Product=Products[1],Category=Categories[0]},
            new ProductCategory {Product=Products[1],Category=Categories[2]},

            new ProductCategory {Product=Products[2],Category=Categories[0]},
            new ProductCategory {Product=Products[2],Category=Categories[2]},

            new ProductCategory {Product=Products[3],Category=Categories[1]},
            new ProductCategory {Product=Products[3],Category=Categories[2]},

            new ProductCategory {Product=Products[4],Category=Categories[1]},
            new ProductCategory {Product=Products[4],Category=Categories[2]},

        };
    }
}