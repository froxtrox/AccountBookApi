using AccountBookApi.Data.Repository.Interfaces;
using AccountBookApi.Domain;
namespace AccountBookApi.Data.Repository
{
    public interface ITransactionRepository : IRepository<Transaction>
    {
    }
}