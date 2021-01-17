using Microsoft.EntityFrameworkCore;
using AccountBookApi.Domain;

namespace AccountBookApi.Data
{
    public class AccountBookDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        public AccountBookDBContext(DbContextOptions<AccountBookDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Transaction>().ToTable("Transaction");
            // modelBuilder.Entity<User>(entity =>
            // {
            //     entity.HasKey(e => e.ID);
            //     entity.Property(e => e.Name).IsRequired();
            //     entity.Property(e => e.DoB).IsRequired();
            //     entity.Property(e => e.Email).IsRequired();

            // });

            // modelBuilder.Entity<Transaction>(entity =>
            // {
            //     entity.HasKey(e => e.ID);
            //     entity.Property(e => e.ProductName).IsRequired();
            //     entity.Property(e => e.Amount);
            //     entity.Property(e => e.PurchasedBy);
            //     entity.Property(e => e.PurchasedOn);
            // });
        }
    }
}