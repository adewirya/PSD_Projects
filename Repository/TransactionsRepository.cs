using PSDProject.Model;

namespace PSDProject.Repository
{
    public class TransactionsRepository
    {
        public static void newTransaction(TransactionHeader th)
        {
            PSDProjectsEntities db = new PSDProjectsEntities();
            db.TransactionHeaders.Add(th);
            db.SaveChanges();
        }
    }
}