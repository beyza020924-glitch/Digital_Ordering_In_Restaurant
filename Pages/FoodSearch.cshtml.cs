using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RestaurantOrderApp.Pages
{
    public class FoodSearchModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string Search { get; set; } = "";

        public void OnGet()
        {
            // Burada ileride veritabanýna göre filtreleme yapabilirsin.
        }
    }
}
