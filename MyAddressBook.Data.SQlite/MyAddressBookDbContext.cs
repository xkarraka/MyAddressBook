using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;
using MyAddressBook.Domain.Entities;

namespace MyAddressBook.Data.SQlite
{
    public class MyAddressBookDbContext : DbContext
    {
        public MyAddressBookDbContext()
        {

        }

        public MyAddressBookDbContext(DbContextOptions<MyAddressBookDbContext> options) 
            : base(options) 
        {
        }   

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BookRecord>().HasData(
     
                new BookRecord { id = 1, fullName = "Julian Urrego", phoneNumber = "573012600120" },
                new BookRecord { id = 2, fullName = "Pedro Suares", phoneNumber = "573012600000" }
            );
        }

        public virtual DbSet<BookRecord> BookRecords { get; set; }
    }
}
