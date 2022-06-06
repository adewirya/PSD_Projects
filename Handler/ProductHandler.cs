using PSDProject.Factory;
using PSDProject.Model;
using PSDProject.Repository;
using System.Collections.Generic;

namespace PSDProject.Handler
{
    public class ProductHandler
    {

        public static void insertProduct(string name, string desc,int price)
        {
            Product p = ProductFactory.newProduct(name, desc, price);
            ProductRepository.insertProduct(p);
        }
        public static List<Product> select()
        {
            return ProductRepository.select();
        }

        public static Product selectProductBasedOnId(int id)
        {
            return ProductRepository.selectProductBasedOnId(id);
        }

        public static void updateProduct(string name, string desc, int price, int id)
        {
            ProductRepository.updateProduct(name,desc, price, id);
        }

        public static void deleteProduct(int id)
        {
            ProductRepository.deleteProduct(id);
        }
    }
}