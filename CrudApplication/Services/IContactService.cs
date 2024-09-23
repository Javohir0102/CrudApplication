using CrudApplication.Model;

namespace CrudApplication.Services
{
    public interface IContactService
    {
        Task<Contact> AddContactAsync(Contact contact);
        Task<List<Contact>> GetAllContactsAsync();
        Task<Contact> UpdateContactAsync(Contact contact);
        Task<Contact> DeleteContactAsync(Contact contact);
    }
}