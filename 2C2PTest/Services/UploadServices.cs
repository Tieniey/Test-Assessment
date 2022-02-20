using _2C2PTest.Repositories;
using _2C2PTest.Models;

namespace _2C2PTest.Services
{
    public class UploadServices
    {
        UploadRepo objUpload = new UploadRepo();

        public Task<List<Transaction2C2p>> GetAllTransaction()
        {
            return Task.FromResult(objUpload.GetAllTransaction());
        }

        public void Create(Transaction2C2p trx)
        {
            objUpload.AddTransaction(trx);
        }
    }
}
