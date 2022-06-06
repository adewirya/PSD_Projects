using PSDProject.Model;

namespace PSDProject.Factory
{
    public class ProductFactory
    {
        public static Product newProduct(string name, string desc,int price)
        {
            Product p = new Product();
            p.ProductName = name;
            p.ProductDescription = desc;
            p.ProductPrice = price;

            return p;
        }
    }
}