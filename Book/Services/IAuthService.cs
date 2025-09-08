namespace Book.Services
{
   

    public interface IAuthService
    {
        bool Register(string username, string password);
        Users Login(string username, string password);
    }

    public class AuthService : IAuthService
    {
        private readonly List<Users> _users = new();

        public bool Register(string username, string password)
        {
            if (_users.Any(u => u.UserName == username))
                return false;

            _users.Add(new Users { UserName = username, Password = password });
            return true;
        }

        public Users Login(string username, string password)
        {
            return _users.FirstOrDefault(u => u.UserName == username && u.Password == password);
        }
    }


    public class Users
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
