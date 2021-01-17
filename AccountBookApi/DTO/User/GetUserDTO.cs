using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AccountBookApi.Data;
using AccountBookApi.Domain;
using Microsoft.EntityFrameworkCore;
using AccountBookApi.Data.Repository.Interfaces;

namespace AccountBookApi.DTO
{
    public class GetUserDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

    }
}



