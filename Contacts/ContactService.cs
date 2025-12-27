using Contacts.Data;
using Contacts.Models;
using Microsoft.EntityFrameworkCore;

namespace Contacts
{
    public class ContactService : IContactService
    {
        private readonly ContactsDbContext _context;

        public ContactService(ContactsDbContext context)
        {
            _context = context;
        }


        public async Task AddAsync(Contact contact)
        {
            Console.WriteLine($"Adding Contact: {contact.FirstName}, {contact.LastName}, {contact.EmailAddress}");
            _context.Contacts.Add(contact);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Contact>> GetAllAsync()
        {
            return await _context.Contacts.ToListAsync();
        }

        public async Task<Contact?> GetByIdAsync(int id)
        {
            return await _context.Contacts.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task UpdateAsync(Contact contact)
        {
            _context.Contacts.Update(contact);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var contact = await _context.Contacts.FindAsync(id);
            if (contact != null)
            {
                _context.Contacts.Remove(contact);
                await _context.SaveChangesAsync();
            }
        }
    }
}
