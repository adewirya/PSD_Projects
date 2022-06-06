using PSDProject.Model;

namespace PSDProject.Factory
{
    public class CartFactory
    {
        public static Cart newCart(int userId, int productId, int quantity)
        {
            Cart c = new Cart();
            c.UserId = userId;
            c.ProductId = productId;
            c.Quantity = quantity;

            return c;
        }
    }
}