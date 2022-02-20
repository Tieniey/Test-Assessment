using _2C2PTest.Models;
using Microsoft.EntityFrameworkCore;

namespace _2C2PTest.Repositories
{
    public class UploadRepo
    {
        _2C2P db = new _2C2P();

        //To Get all transaction      
        public List<Transaction2C2p> GetAllTransaction()
        {
            try
            {
                return db.Transaction2C2ps.ToList();
            }
            catch
            {
                throw;
            }
        }

        //To Add new transaction record         
        public void AddTransaction(Transaction2C2p trx)
        {
            try
            {
                db.Transaction2C2ps.Add(trx);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

    }
}
