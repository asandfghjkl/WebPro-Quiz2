using System.Collections.Generic;
using System.Data.Entity;

namespace WingtipToys.Models
{
  public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
  {
    protected override void Seed(ProductContext context)
    {
      GetCategories().ForEach(c => context.Categories.Add(c));
      GetProducts().ForEach(p => context.Products.Add(p));
    }

    private static List<Category> GetCategories()
    {
      var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Starters"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Salads"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Specialty"
                },
            };

      return categories;
    }

    private static List<Product> GetProducts()
    {
      var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Crab Cake",
                    Description = "A delicate crab cake served on a toasted roll with lettuce and tartar sauce", 
                    ImagePath="cake.jpg",
                    UnitPrice = 22.500,
                    CategoryID = 1
               },
                new Product 
                {
                    ProductID = 2,
                    ProductName = "Mozzarella Stick",
                    Description = "Lorem, deren, trataro, filede, nerada",
                    ImagePath="mozzarella.jpg",
                    UnitPrice = 15.950,
                     CategoryID = 1
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Caesar Selection",
                    Description = "Lorem, deren, trataro, filede, nerada",
                    ImagePath="caesar.jpg",
                    UnitPrice = 32.990,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Spinach Salad",
                    Description = "Fresh spinach with mushrooms, hard boiled egg, and warm bacon vinaigrette",
                    ImagePath="spinach-salad.jpg",
                    UnitPrice = 18.950,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Greek Salad",
                    Description = "Fresh spinach, crisp romaine, tomatoes, and Greek olives",
                    ImagePath="greek-salad.jpg",
                    UnitPrice = 34.950,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Bread Barrel",
                    Description = "Lorem, deren, trataro, filede, nerada",
                    ImagePath="bread-barrel.jpg",
                    UnitPrice = 95.000,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Lobster Roll",
                    Description = "Plump lobster meat, mayo and crisp lettuce on a toasted bulky roll",
                    ImagePath="lobster-roll.jpg",
                    UnitPrice = 94.950,
                    CategoryID = 3
                }
            };

      return products;
    }
  }
}