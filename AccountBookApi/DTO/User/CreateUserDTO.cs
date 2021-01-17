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
    public class CreateUserDTO
    {
        public string Name { get; set; }
        public DateTime DoB { get; set; }
        public string Email { get; set; }

    }
}



