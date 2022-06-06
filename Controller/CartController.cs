using PSDProject.Model;
using PSDProject.Handler;
using System.Collections.Generic;

namespace PSDProject.Controller
{
    public class CartController
    {
        public static void addToCart(int userId, int productId, int quantity)
        {
            Cart c = selectCart(productId, userId);
            if (c == null)
            {
                CartHandler.addToCart(userId, productId, quantity);
            }
            else
            {
                CartHandler.updateCart(c.CartId, c.Quantity+quantity);
            }
        }

        public static Cart selectCart(int prodId, int userId)
        {
            return CartHandler.selectCart(prodId, userId);
        }

        public static void updateCart(int cartId, int qty)
        {
            
            CartHandler.updateCart(cartId, qty);
        }

        public static void deleteCart(int userId, int productId)
        {
            CartHandler.deleteCart(userId, productId);
        }

        public static void clearCart(int userId)
        {
            CartHandler.clearCart(userId);
        }

        public static List<Cart> select(int userId)
        {
            return CartHandler.select(userId);
        }

        public static Cart selectById(int cartId)
        {
            return CartHandler.selectById(cartId);
        }
    }
}