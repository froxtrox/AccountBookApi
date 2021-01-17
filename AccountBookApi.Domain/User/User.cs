using System;

namespace AccountBookApi.Domain
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public DateTime DoB { get; set; }
        public string Email { get; set; }
    }
}
