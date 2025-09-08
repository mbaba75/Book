namespace Book.Services
{
    public class User
    {
        public string FullName { get; set; } = "کاربر تستی";
        public string Email { get; set; } = "test@example.com";
        public string Address { get; set; } = "تهران، خیابان آزادی";
        public List<Order> Orders { get; set; } = new();
    }
}
