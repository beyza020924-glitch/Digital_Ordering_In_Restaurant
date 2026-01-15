using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RestaurantOrderApp.Models;
using System;
using System.Linq;

namespace RestaurantOrderApp.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new AppDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>());

            if (context.Foods.Any())
            {
                return; // Zaten veri varsa tekrar ekleme
            }

            context.Foods.AddRange(
                new Food
                {
                    Title = "Chicke Hawain Pizza",
                    Description = "Made with Italian Sauce, Chicken, and organic vegetables.",
                    Price = 2.3M,
                    ImageUrl = "/images/menu-pizza.jpg"
                },
                new Food
                {
                    Title = "Smoky Burger",
                    Description = "Made with Italian Sauce, Chicken, and organic vegetables.",
                    Price = 2.3M,
                    ImageUrl = "/images/menu-burger.jpg"
                },
                new Food
                {
                    Title = "Nice Burger",
                    Description = "Made with Italian Sauce, Chicken, and organic vegetables.",
                    Price = 2.3M,
                    ImageUrl = "/images/menu-burger.jpg"
                },
                new Food
                {
                    Title = "Chicken Steam Momo",
                    Description = "Made with Italian Sauce, Chicken, and organic vegetables.",
                    Price = 2.3M,
                    ImageUrl = "/images/menu-momo.jpg"
                }
            );

            context.SaveChanges();
        }
    }
}
