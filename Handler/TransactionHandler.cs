using PSDProject.Factory;
using PSDProject.Model;
using PSDProject.Repository;
using System;
using System.Collections.Generic;

namespace PSDProject.Handler
{
    public class TransactionHandler
    {
        public static void newTransaction(int userId, List<Cart> carts)
        {
            TransactionHeader th = TransactionFactory.newTransactionHead(userId);
            List<TransactionDetail> trds = TransactionFactory.newTransactionDetails(carts);
            th.TransactionDetails = trds;
            Console.Write("masuk kevin betch");
            TransactionsRepository.newTransaction(th);
        }
    }
}