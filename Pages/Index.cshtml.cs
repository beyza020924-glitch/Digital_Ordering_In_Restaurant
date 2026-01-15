using Microsoft.AspNetCore.Mvc.RazorPages;
using RestaurantOrderApp.Models;
using RestaurantOrderApp.Data; // DbContext için gerekli
using System.Collections.Generic;
using System.Linq;

namespace RestaurantOrderApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public List<Food> Foods { get; set; }

        public void OnGet()
        {
            Foods = _context.Foods.Take(3).ToList();
        }
    }
}
