using CrudApplication.Model;
using Microsoft.EntityFrameworkCore;

namespace CrudApplication.Services
{
    public class ContactService : IContactService
    {
        private IFileService fileService;
        public ContactService(IFileService fileService)
        {
            this.fileService = fileService;
        }
        public async Task<Contact> AddContactAsync(Contact contact)
        {
            try
            {
                if (contact is null)
                {
                    throw new Exception("Contact does not be empty!");
                }
                return await fileService.AddContactAsync(contact);
            }
            catch (DbUpdateException ex)
            {
                throw new Exception("Error with database!", ex);
            }
        }

        public async Task<List<Contact>> GetAllContactsAsync()
        {
            return await fileService.SelectAllContactAsync();
        }

        public async Task<Contact> UpdateContactAsync(Contact contact)
        {
            try
            {
                if (contact is null)
                {
                    throw new Exception("Contact does not be empty!");
                }
                return await fileService.UpdateContactAsync(contact);
            }
            catch (DbUpdateException ex)
            {
                throw new Exception("Error with database!", ex);
            }
        }

        public async Task<Contact> DeleteContactAsync(Contact contact)
        {
            try
            {
                if (contact is null)
                {
                    throw new Exception("Contact does not be empty!");
                }
                return await fileService.DeleteContactAsync(contact);
            }
            catch (DbUpdateException ex)
            {
                throw new Exception("Error with database!", ex);
            }
        }
    }
}