using Microsoft.AspNetCore.Mvc.RazorPages;
using RestaurantOrderApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantOrderApp.Pages // ? BU ÇOK ÖNEMLÝ
{
    public class FoodsModel : PageModel
    {
        private readonly AppDbContext _context;

        public FoodsModel(AppDbContext context)
        {
            _context = context;
        }

        public List<Food> FoodList { get; set; }

        public void OnGet()
        {
            FoodList = _context.Foods.ToList();
        }
    }
}
