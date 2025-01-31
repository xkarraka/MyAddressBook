using System.Linq.Expressions;
using MyAddressBook.Domain.Entities;

namespace MyAddressBook.Data.Interfaces
{
    public interface IRepository
    {
        IEnumerable<BookRecord> GetAll();
        Task<BookRecord> Add(BookRecord entity);
        Task Delete(int id);
    }
}
