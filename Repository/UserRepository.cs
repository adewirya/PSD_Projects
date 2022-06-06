using PSDProject.Model;
using System.Collections.Generic;
using System.Linq;

namespace PSDProject.Repository
{
    public class UserRepository
    {
        public static User login(string username, string password)
        {
            PSDProjectsEntities db = new PSDProjectsEntities();

            User u = (from x in db.Users where x.Username.Equals(username) && x.Password.Equals(password) select x).FirstOrDefault();

            return u;
        }

        public static User selectById(int id)
        {
            PSDProjectsEntities db = new PSDProjectsEntities();

            User u = (from x in db.Users where x.UserId == id select x).FirstOrDefault();

            return u;
        }

        public static void register(User u)
        {
            PSDProjectsEntities db = new PSDProjectsEntities();
            db.Users.Add(u);
            db.SaveChanges();
        }

        public static List<User> select()
        {
            PSDProjectsEntities db = new PSDProjectsEntities();
            return (from x in db.Users select x).ToList();
        }

        public static void delete(int id)
        {
            PSDProjectsEntities db = new PSDProjectsEntities();
            User u = (from x in db.Users where x.UserId == id select x).FirstOrDefault();
            db.Users.Remove(u);
            db.SaveChanges();
        }

        public static void update(int id, string username, string password)
        {
            PSDProjectsEntities db = new PSDProjectsEntities();
            User u = (from x in db.Users where x.UserId == id select x).FirstOrDefault();
            u.Username = username;
            u.Password = password;
            db.SaveChanges();
        }
    }
}