using Contacts.Models;
using Microsoft.EntityFrameworkCore;

namespace Contacts.Data
{
    public class ContactsDbContext : DbContext
    {
        public ContactsDbContext(DbContextOptions<ContactsDbContext> options) : base(options) { }

        public DbSet<Contact> Contacts { get; set; } = null!;
    }
}
