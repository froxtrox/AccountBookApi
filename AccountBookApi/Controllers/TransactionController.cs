using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AccountBookApi.Domain;
using AccountBookApi.Data;



namespace AccountBookApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransactionController : ControllerBase
    {
        private readonly AccountBookDBContext _context;
        private readonly ILogger<AccountBookController> _logger;

        public TransactionController(ILogger<AccountBookController> logger, AccountBookDBContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Transaction> Get()
        {
            var Message = $"About page visited at {DateTime.UtcNow.ToLongTimeString()}";
            _logger.LogInformation(Message);
            return _context.Transactions;
        }

        [HttpPost]
        public IEnumerable<User> Create()
        {
            var Message = $"About page visited at {DateTime.UtcNow.ToLongTimeString()}";
            _logger.LogInformation(Message);
            return _context.Users;
        }
    }
}
