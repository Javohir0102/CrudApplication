using CrudApplication.Model;
using CrudApplication.Services;
using Microsoft.AspNetCore.Mvc;

namespace CrudApplication.Controllers
{
    [ApiController]
    [Route("api/contacts")]
    public class ContactController : ControllerBase
    {
        public IContactService contactService;
        public ContactController(IContactService contactService)
        {
            this.contactService = contactService;
        }

        [HttpPost]
        public async Task<Contact> CreateContactAsync(Contact contact)
        {
            return await contactService.AddContactAsync(contact);
        }

        [HttpGet]
        public async Task<List<Contact>> ReadAllContactAsync()
        {
            return await contactService.GetAllContactsAsync();
        }

        [HttpPut]
        public Task<Contact> UpdateContactAsync(Contact contact)
        {
            return contactService.UpdateContactAsync(contact);
        }

        [HttpDelete]
        public async Task<Contact> DeleteContactAsyn(Contact contact)
        {
            return await contactService.DeleteContactAsync(contact);
        }
    }
}
