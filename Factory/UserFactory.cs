using PSDProject.Model;


namespace PSDProject.Factory
{
    public class UserFactory
    {
        public static User register(string username, string password)
        {
            User u = new User();
            u.Username = username;
            u.Password = password;
            return u;
        }
    }
}