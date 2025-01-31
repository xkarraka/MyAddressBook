using MyAddressBook.Data.Interfaces;
using MyAddressBook.Domain.Entities;
using MyAddressBook.Services.Interfaces;

namespace MyAddressBook.Services
{
    public class MyAddressBookService : IMyAddressBookService
    {
        private readonly IRepository _repository;

        public MyAddressBookService(IRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<BookRecord> GetBookRecords()
        {
            return _repository.GetAll();
        }

        public async Task DeleteBookRecord(int id)
        {
            await _repository.Delete(id);
        }

        public async Task<BookRecord> AddRecord(BookRecord entity)
        {
            await _repository.Add(entity);
            return entity;
        }
    }
}
