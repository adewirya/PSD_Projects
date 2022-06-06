using PSDProject.Factory;
using PSDProject.Model;
using PSDProject.Repository;
using System.Collections.Generic;

namespace PSDProject.Handler
{
    public class UserHandler
    {
        public static User login (string username, string password)
        {
            return UserRepository.login(username, password);
        }

        public static void register(string username, string password)
        {
            User u = UserFactory.register(username, password);

            UserRepository.register(u);
        }

        public static User selectById(int id)
        {
            return UserRepository.selectById(id);
        }

        public static List<User> select()
        {
            return UserRepository.select();
        }

        public static void delete(int id)
        {
            UserRepository.delete(id);
        }

        public static void update(int id, string username, string password)
        {
            UserRepository.update(id, username, password);
        }
    }
}