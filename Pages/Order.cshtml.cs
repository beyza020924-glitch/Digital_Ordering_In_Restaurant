using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RestaurantOrderApp.Data;
using RestaurantOrderApp.Models;

namespace RestaurantOrderApp.Pages
{
    public class OrderModel : PageModel
    {
        private readonly AppDbContext _context;

        public OrderModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty(SupportsGet = true)]
        public int Id { get; set; } 

        [BindProperty]
        public Order Order { get; set; }

        public Food SelectedFood { get; set; }

        public void OnGet()
        {
            SelectedFood = _context.Foods.FirstOrDefault(f => f.Id == Id);
            Order = new Order
            {
                FoodId = Id,
                Quantity = 1
            };
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Orders.Add(Order);
            _context.SaveChanges();

            TempData["Message"] = "Order saved successfully!";
            return RedirectToPage("Index");
        }
    }
}
