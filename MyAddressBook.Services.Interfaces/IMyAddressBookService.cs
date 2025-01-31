using MyAddressBook.Domain.Entities;

namespace MyAddressBook.Services.Interfaces
{
    public interface IMyAddressBookService
    {
        Task<BookRecord> AddRecord(BookRecord entity);
        Task DeleteBookRecord(int id);
        IEnumerable<BookRecord> GetBookRecords();
    }
}
