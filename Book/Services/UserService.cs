namespace Book.Services
{
    public class UserService
    {
        private User _user = new User();

        public UserService()
        {
            // نمونه سفارش تستی
            _user.Orders.Add(new Order
            {
                OrderId = 1001,
                TotalPrice = 250000,
                Books = new List<Book>
                {
                    new Book { Title = "کتاب اول", Price = 120000 },
                    new Book { Title = "کتاب دوم", Price = 130000 }
                }
            });

            _user.Orders.Add(new Order
            {
                OrderId = 1002,
                TotalPrice = 80000,
                Books = new List<Book>
                {
                    new Book { Title = "کتاب سوم", Price = 80000 }
                }
            });
        }

        public User GetUser() => _user;
    }
}
