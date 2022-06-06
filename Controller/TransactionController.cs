using PSDProject.Model;
using PSDProject.Handler;
using System.Collections.Generic;

namespace PSDProject.Controller
{
    public class TransactionController
    {
        public static void newTransaction(int userId, List<Cart> carts)
        {
            TransactionHandler.newTransaction(userId, carts);
            
        }   
    }
}