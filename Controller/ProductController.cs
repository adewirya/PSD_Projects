using PSDProject.Handler;
using PSDProject.Model;
using System.Collections.Generic;

namespace PSDProject.Controller
{
    public class ProductController
    {
        public static List<Product> select()
        {
            return ProductHandler.select();
        }
        public static void deleteProduct(int id)
        {
            ProductHandler.deleteProduct(id);
        }

        public static void insertProduct(string name, string desc, int price)
        {
            ProductHandler.insertProduct(name, desc, price);
        }

        public static Product selectBasedOnId(int id)
        {
            return ProductHandler.selectProductBasedOnId(id);
        }

        public static void updateProduct(string name, string desc, int price, int id)
        {
            ProductHandler.updateProduct(name,desc, price, id);
        }
    }
}