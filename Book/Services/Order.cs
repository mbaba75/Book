namespace Book.Services
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public decimal TotalPrice { get; set; }
        public List<Book> Books { get; set; } = new();
    }
}
