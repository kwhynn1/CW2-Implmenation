using Microsoft.EntityFrameworkCore;

namespace Project.Data
{
    public class SeedDataCutomers
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ProjectContext(serviceProvider.GetRequiredService<DbContextOptions<ProjectContext>>()))
            {
           
                if (context == null || context.Customer == null)
                {
                    throw new ArgumentNullException("Null CWContext");
                }

                if (context.Customer.Any())
                {
                    return;   // DB has been seeded
                }

                context.Customer.AddRange
                    (

                    new Models.Customer
                    {
                        FullName = "Peter John",
                        StreetAddress = "56 New Road",
                        City = "London",
                        PostalCode = "En53ER",
                        Gender = "F",
                    },
                    new Models.Customer
                    {
                        FullName = "Alwilda Ottone",
                        StreetAddress = "56 New Road",
                        City = "London",
                        PostalCode = "En53ER",
                        Gender = "F",
                    },
                    new Models.Customer
                    {
                        FullName = "Juurou Eva",
                        StreetAddress = "56 New Road",
                        City = "London",
                        PostalCode = "En53ER",
                        Gender = "F",
                    }, new Models.Customer
                    {
                        FullName = "Homer Vincent",
                        StreetAddress = "56 New Road",
                        City = "London",
                        PostalCode = "En53ER",
                        Gender = "M",
                    },
                    new Models.Customer
                    {
                        FullName = "Larysa Vasant",
                        StreetAddress = "56 New Road",
                        City = "London",
                        PostalCode = "En53ER",
                        Gender = "F",
                    },
                    new Models.Customer
                    {
                        FullName = "Suze Archibald",
                        StreetAddress = "56 New Road",
                        City = "London",
                        PostalCode = "En53ER",
                        Gender = "F",
                    }, new Models.Customer
                    {
                        FullName = "Eva O'Donnell",
                        StreetAddress = "56 New Road",
                        City = "London",
                        PostalCode = "En53ER",
                        Gender = "F",
                    },
                    new Models.Customer
                    {
                        FullName = "Archibald Hoekstra",
                        StreetAddress = "56 New Road",
                        City = "London",
                        PostalCode = "En53ER",
                        Gender = "M",
                    },
                    new Models.Customer
                    {
                        FullName = "Vasant Haynes",
                        StreetAddress = "56 New Road",
                        City = "London",
                        PostalCode = "En53ER",
                        Gender = "M",
                    },
                    new Models.Customer
                    {
                        FullName = "Homer John",
                        StreetAddress = "56 New Road",
                        City = "London",
                        PostalCode = "En53ER",
                        Gender = "M",
                    }
                    );


                context.SaveChanges();



            }
        }
    }

}

