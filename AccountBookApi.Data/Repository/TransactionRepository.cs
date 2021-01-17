using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AccountBookApi.Data.Repository.Interfaces;
using AccountBookApi.Domain;
namespace AccountBookApi.Data.Repository
{
    public class TransactionRepository : Repository<Transaction>, ITransactionRepository
    {
        public TransactionRepository(AccountBookDBContext context) : base(context)
        {
        }
    }
}