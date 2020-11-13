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
                    CategoryName = "All"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Starters"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Salads"
                },
                new Category
                {
                    CategoryID = 4,
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
                    CategoryID = 2
               },
                new Product 
                {
                    ProductID = 2,
                    ProductName = "Mozzarella Stick",
                    Description = "Lorem, deren, trataro, filede, nerada",
                    ImagePath="mozzarella.jpg",
                    UnitPrice = 15.950,
                     CategoryID = 2
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Caesar Selection",
                    Description = "Lorem, deren, trataro, filede, nerada",
                    ImagePath="caesar.jpg",
                    UnitPrice = 32.990,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Spinach Salad",
                    Description = "Fresh spinach with mushrooms, hard boiled egg, and warm bacon vinaigrette",
                    ImagePath="spinach-salad.jpg",
                    UnitPrice = 18.950,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Greek Salad",
                    Description = "Fresh spinach, crisp romaine, tomatoes, and Greek olives",
                    ImagePath="greek-salad.jpg",
                    UnitPrice = 34.950,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Bread Barrel",
                    Description = "Lorem, deren, trataro, filede, nerada",
                    ImagePath="planeace.png",
                    UnitPrice = 95.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Glider",
                    Description = "This fun glider is made from real balsa wood. Some assembly required.",
                    ImagePath="planeglider.png",
                    UnitPrice = 4.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Paper Plane",
                    Description = "This paper plane is like no other paper plane. Some folding required.",
                    ImagePath="planepaper.png",
                    UnitPrice = 2.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Propeller Plane",
                    Description = "Rubber band powered plane features two wheels.",
                    ImagePath="planeprop.png",
                    UnitPrice = 32.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Early Truck",
                    Description = "This toy truck has a real gas powered engine. Requires regular tune ups.",
                    ImagePath="truckearly.png",
                    UnitPrice = 15.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "Fire Truck",
                    Description = "You will have endless fun with this one quarter sized fire truck.",
                    ImagePath="truckfire.png",
                    UnitPrice = 26.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "Big Truck",
                    Description = "This fun toy truck can be used to tow other trucks that are not as big.",
                    ImagePath="truckbig.png",
                    UnitPrice = 29.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 13,
                    ProductName = "Big Ship",
                    Description = "Is it a boat or a ship. Let this floating vehicle decide by using its " + 
                                  "artifically intelligent computer brain!",
                    ImagePath="boatbig.png",
                    UnitPrice = 95.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 14,
                    ProductName = "Paper Boat",
                    Description = "Floating fun for all! This toy boat can be assembled in seconds. Floats for minutes!" + 
                                  "Some folding required.",
                    ImagePath="boatpaper.png",
                    UnitPrice = 4.95,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "Sail Boat",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="boatsail.png",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 16,
                    ProductName = "Rocket",
                    Description = "This fun rocket will travel up to a height of 200 feet.",
                    ImagePath="rocket.png",
                    UnitPrice = 122.95,
                    CategoryID = 5
                }
            };

      return products;
    }
  }
}