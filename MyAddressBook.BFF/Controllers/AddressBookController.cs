using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyAddressBook.Data.Interfaces;
using MyAddressBook.Domain.Entities;

namespace MyAddressBook.BFF.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddressBookController : ControllerBase
    {
        private readonly IRepository repository;

        public AddressBookController(IRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(repository.GetAll());
        }

        [HttpPost]
        public async Task<IActionResult> Create(BookRecord record)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            await repository.Add(record);

            return Ok(record);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await repository.Delete(id);
            return Ok();
        }
    }
}
