using Microsoft.EntityFrameworkCore;

namespace Project.Data
{
    public class SeedDataProducts
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ProjectContext(serviceProvider.GetRequiredService<DbContextOptions<ProjectContext>>()))
            {
                if (context == null || context.Product == null)
                {
                    throw new ArgumentNullException("Null CWContext");
                }

                if (context.Product.Any())
                {
                    return;   // DB has been seeded
                }

                context.Product.AddRange
                    (

                    new Models.Product
                    {
                        ProductName = "Winter Very Coat",
                        ProductDescription = "Coat In Winter",
                        Category = "Coat",
                        Price = 12,
                        ImageName = "1.jpg"
                    },
                    new Models.Product
                    {

                        ProductName = "Purple Ellese Coat",
                        ProductDescription = "Coat In Winter",
                        Category = "Coat",
                        Price = 32,
                        ImageName = "2.jpg"
                    },
                    new Models.Product
                    {

                        ProductName = "North BlueFace Coat",
                        ProductDescription = "Coat In Winter",
                        Category = "Coat",
                        Price = 52,
                        ImageName = "3.jpg"
                    },
                    new Models.Product
                    {
                        ProductName = "Winter White Gucci Coat",
                        ProductDescription = "Coat In Winter",
                        Category = "Coat",
                        Price = 82,
                        ImageName = "4.jpg"
                    },
                    new Models.Product
                    {

                        ProductName = "Ellese Red Coat",
                        ProductDescription = "Coat In Winter",
                        Category = "Coat",
                        Price = 72,
                        ImageName = "5.jpg"
                    },
                    new Models.Product
                    {

                        ProductName = "North Face Boot",
                        ProductDescription = "Boot For Winter",
                        Category = "Boot",
                        Price = 62,
                        ImageName = "6.jpg"
                    },
                    new Models.Product
                    {
                        ProductName = "WVery Gucci Coat",
                        ProductDescription = "Coat In Winter",
                        Category = "Coat",
                        Price = 92,
                        ImageName = "7.jpg"
                    },
                    new Models.Product
                    {

                        ProductName = "Ellese Gloves",
                        ProductDescription = "Golves Gor Winter",
                        Category = "Gloves",
                        Price = 42,
                        ImageName = "8.jpg"
                    },
                    new Models.Product
                    {

                        ProductName = "Gucci Gloves",
                        ProductDescription = "Golves Gor Winter",
                        Category = "Gloves",
                        Price = 32,
                        ImageName = "9.jpg"
                    },
                    new Models.Product
                    {
                        ProductName = "Winter Scarf",
                        ProductDescription = "Coat In Winter",
                        Category = "Scarf",
                        Price = 22,
                        ImageName = "10.jpg"
                    }

                    );

                context.SaveChanges();

              
            }
        }
    }

}

