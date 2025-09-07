namespace Book.Services
{

    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
    }

    public interface IBookService
    {
        List<Book> GetBooks();
    }

    public class BookService : IBookService
    {
        private readonly List<Book> _books = new()
        {
        new Book { Id = 1, Title = "خاطرات یک کتاب", Author = "نویسنده اول", Price = 120000 },
        new Book { Id = 2, Title = "ماجراهای برنامه نویسی", Author = "نویسنده دوم", Price = 95000 },
        new Book { Id = 3, Title = "دنیا در یک صفحه", Author = "نویسنده سوم", Price = 150000 }
        };

        public List<Book> GetBooks() => _books;
    }
}
