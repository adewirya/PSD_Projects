using PSDProject.Model;
using System;
using System.Collections.Generic;

namespace PSDProject.Factory
{
    public class TransactionFactory
    {
        public static TransactionHeader newTransactionHead(int userId)
        {
            TransactionHeader tr = new TransactionHeader();
            tr.UserId = userId;
            tr.TransactionDate = DateTime.Now;

            return tr;
        }

        public static List<TransactionDetail> newTransactionDetails(List<Cart> carts)
        {
            List<TransactionDetail> trds = new List<TransactionDetail>();
            foreach(Cart c in carts)
            {
                TransactionDetail tr = new TransactionDetail();
                tr.ProductId = c.ProductId;
                tr.Quantity = c.Quantity;
                trds.Add(tr);
            }

            return trds;
        }
    }
}