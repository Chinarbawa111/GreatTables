using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using GreatTables.Data;
using System;
using System.Linq;

namespace GreatTables.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GreatTablesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<GreatTablesContext>>()))
            {
                // Look for any movies.
                if (context.Table.Any())
                {
                    return;   // DB has been seeded
                }

                context.Table.AddRange(
                    new Table
                    {
                        Quality = "Trestle",
                        Color = "Black",
                        Measurements = "Small",
                        Price = 10.00M,
                        Rating = 3,
                    },

                    new Table
                    {
                        Quality = "Trestle",
                        Color = "Black",
                        Measurements = "Medium",
                        Price = 15.00M,
                        Rating = 4,
                    },


                    new Table
                    {
                        Quality = "Trestle",
                        Color = "White",
                        Measurements = "Medium",
                        Price = 18.00M,
                        Rating = 4
                    },

                    new Table
                    {
                        Quality = "Legs",
                        Color = "Brown",
                        Measurements = "Medium",
                        Price = 10.00M,
                        Rating = 4,
                    },

                    new Table
                    {
                        Quality = "Legs",
                        Color = "Black",
                        Measurements = "Large",
                        Price = 40.00M,
                        Rating = 5,
                    },


                    new Table
                    {
                        Quality = "Legs",
                        Color = "White",
                        Measurements = "Large",
                        Price = 50.00M,
                        Rating = 5,
                    },
                    
                    new Table
                    {
                        Quality = "Pedestal",
                        Color = "Brown",
                        Measurements = "Small",
                        Price = 30.00M,
                        Rating = 4,
                    },
                    
                    new Table
                    {
                        Quality = "Pedestal",
                        Color = "Black",
                        Measurements = "Large",
                        Price = 35.00M,
                        Rating = 3,
                    },
                    
                    new Table
                    {
                        Quality = "Pedestal",
                        Color = "White",
                        Measurements = "Large",
                        Price = 50.00M,
                        Rating = 5,
                    },
                    
                    new Table
                    {
                        Quality = "Pedestal",
                        Color = "Cream",
                        Measurements = "Large",
                        Price = 70.00M,
                        Rating = 5,
                    },
                    
                    new Table
                    {
                        Quality = "Pedestal",
                        Color = "Grey",
                        Measurements = "Extra Large",
                        Price = 100.00M,
                        Rating = 5,
                    }



                ) ;
                context.SaveChanges();
            }
        }
    }
}