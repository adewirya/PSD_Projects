using PSDProject.Model;
using System.Collections.Generic;
using System.Linq;

namespace PSDProject.Repository
{
    public class ProductRepository
    {
        public static void insertProduct(Product p)
        {
            PSDProjectsEntities db = new PSDProjectsEntities();
            db.Products.Add(p);
            db.SaveChanges();

        }

        public static void deleteProduct(int id)
        {
            PSDProjectsEntities db = new PSDProjectsEntities();
            var del = db.Products.Find(id);
            db.Products.Remove(del);
            db.SaveChanges();
        }

        public static void updateProduct(string name, string desc, int price, int id)
        {
            PSDProjectsEntities db = new PSDProjectsEntities();
            Product p = db.Products.Find(id);
            p.ProductDescription = desc;
            p.ProductName = name;
            p.ProductPrice = price;
            db.SaveChanges();
        }

        public static List<Product> select()
        {
            PSDProjectsEntities db = new PSDProjectsEntities();
            return (from x in db.Products select x).ToList();
        }

        public static Product selectProductBasedOnId(int id)
        {
            PSDProjectsEntities db = new PSDProjectsEntities();
            Product p = (from x in db.Products where x.ProductId == id select x).FirstOrDefault();
            return p;
        }


    }
}