using PSDProject.Model;
using System.Collections.Generic;
using System.Linq;

namespace PSDProject.Repository
{
    public class CartRepository
    {
        public static void addToCart(Cart c)
        {
            PSDProjectsEntities db = new PSDProjectsEntities();

            db.Carts.Add(c);
            db.SaveChanges();
        }

        public static Cart selectCart(int prodId, int userId)
        {
            PSDProjectsEntities db = new PSDProjectsEntities();

            Cart t = (from x in db.Carts where x.ProductId == prodId && x.UserId == userId select x).FirstOrDefault();

            return t;
        }

        public static void deleteCart(int userId, int productId)
        {
            PSDProjectsEntities db = new PSDProjectsEntities();
            Cart c = (from x in db.Carts where x.UserId == userId && x.ProductId == productId select x).FirstOrDefault();   
            db.Carts.Remove(c);
            db.SaveChanges();
        }

        public static void clearCart(int userId)
        {
            PSDProjectsEntities db = new PSDProjectsEntities();
            List<Cart> carts = (from x in db.Carts where x.UserId == userId select x).ToList();
            foreach(Cart c in carts)
            {
                db.Carts.Remove(c);
                db.SaveChanges();
            }
        }
        public static List<Cart> select(int userId)
        {
            PSDProjectsEntities db = new PSDProjectsEntities();
            return (from x in db.Carts where x.UserId == userId select x).ToList();
        }

        public static Cart selectById(int cartId)
        {
            PSDProjectsEntities db = new PSDProjectsEntities();
            return (from x in db.Carts where x.CartId == cartId select x).FirstOrDefault();
        }

        public static void updateCart(int cartId, int quantity)
        {
            PSDProjectsEntities db = new PSDProjectsEntities();
            Cart c = (from x in db.Carts where x.CartId == cartId select x).FirstOrDefault();
            c.Quantity = quantity;
            db.SaveChanges();
        }
    }
}