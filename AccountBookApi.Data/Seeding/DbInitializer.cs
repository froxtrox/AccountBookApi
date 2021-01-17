using AccountBookApi.Domain;
using System;
using System.Linq;

namespace AccountBookApi.Data
{
    public static class DbInitializer
    {
        public static void Initialize(AccountBookDBContext context)
        {
            context.Database.EnsureCreated();

            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }

            var users = new User[]
            {
                new User {
                    DoB = new DateTime(1990,01,01),
                    Name = "Frank",
                    Email = "Frank@test.org"
                },
                new User {
                    DoB = new DateTime(1990,01,01),
                    Name = "Joe",
                    Email = "Joe@test.org"
                },
                                new User {
                    DoB = new DateTime(1990,01,01),
                    Name = "Tomlin",
                    Email = "Tomlin@test.org"
                }
            };
            foreach (var u in users)
            {
                context.Users.Add(u);
            }
            context.SaveChanges();
        }
    }
}
