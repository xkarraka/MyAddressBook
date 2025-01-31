using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using MyAddressBook.Data.Interfaces;
using MyAddressBook.Data.SQlite;
using MyAddressBook.Domain.Entities;

namespace MyAddressBook.Data
{
    public class BookRepository : IRepository
    {
        private readonly DbContext _dbContext;
        public BookRepository(MyAddressBookDbContext dbContext) {
            this._dbContext = dbContext;
        }    
        public async Task<BookRecord> Add(BookRecord entity)
        {
            this._dbContext.Add(entity);
            await this._dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task Delete(int id )
        {
            var entity = this._dbContext.Find<BookRecord>(id);

            if (entity == null)
                throw new Exception("Bookrecord with Id {id} was not found");

            _dbContext.Remove(entity);
            await this._dbContext.SaveChangesAsync();
        }

        public IEnumerable<BookRecord> GetAll()
        {
            return _dbContext.Set<BookRecord>().ToList();
        }
    }
}
