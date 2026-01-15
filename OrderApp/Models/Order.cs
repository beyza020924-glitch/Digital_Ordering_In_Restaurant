namespace RestaurantOrderApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int FoodId { get; set; }

        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
    }
}
