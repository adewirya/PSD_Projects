using PSDProject.Factory;
using PSDProject.Model;
using PSDProject.Repository;
using System.Collections.Generic;

namespace PSDProject.Handler
{
    public class CartHandler
    {
        public static Cart selectCart(int prodId, int userId)
        {
            return CartRepository.selectCart(prodId, userId);
        }

        public static void deleteCart(int userId, int productId)
        {
            CartRepository.deleteCart(userId, productId);
        }

        public static Cart selectById(int cartId)
        {
            return CartRepository.selectById(cartId);
        }

        public static void updateCart(int cartId, int qty)
        {
            CartRepository.updateCart(cartId, qty);
        }


        public static void clearCart(int userId)
        {
            CartRepository.clearCart(userId);
        }

        public static List<Cart> select(int userId)
        {
            return CartRepository.select(userId);
        }
        public static void addToCart(int userId, int productId, int quantity)
        {
            Cart c = CartFactory.newCart(userId, productId, quantity);
            CartRepository.addToCart(c);
        }


    }
}