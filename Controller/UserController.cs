using PSDProject.Handler;
using PSDProject.Model;
using System.Collections.Generic;

namespace PSDProject.Controller
{
    public class UserController
    {
        public static User login(string username, string password)
        {
            User u = UserHandler.login(username, password);
            return u;
        }

        public static string register(string username, string password, string confpass)
        {
            if (username.Length < 5)
            {
                return "Username length must be more than 4";
            }
            else if (!password.Equals(confpass))
            {
                return "Password doesn't match";
            }

            UserHandler.register(username, password);
            return "";
        }

        public static User selectById(int id)
        {
            return UserHandler.selectById(id);
        }

        public static List<User> select()
        {
            return UserHandler.select();
        }

        public static void delete(int id)
        {
            UserHandler.delete(id);
        }

        public static void update(int id, string username, string password)
        {
            UserHandler.update(id, username, password);
        }
    }
}