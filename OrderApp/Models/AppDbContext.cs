namespace RestaurantOrderApp.Models
{
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore;

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Food> Foods { get; set; }

    }

}
