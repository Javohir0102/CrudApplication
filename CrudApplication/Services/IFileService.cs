using CrudApplication.Model;

namespace CrudApplication.Services
{
    public interface IFileService
    {
        Task<Contact> AddContactAsync(Contact contact);
        Task<List<Contact>> SelectAllContactAsync();
        Task<Contact> UpdateContactAsync(Contact contact);
        Task<Contact> DeleteContactAsync(Contact contact);
    }
}
