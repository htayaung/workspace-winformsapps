using ContactManager.Infrastructure;
using ContactManager.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactManager.Services
{
    public class ContactService : IDisposable
    {
        private readonly ApplicationDbContext dbContext;

        private bool disposed;

        public ContactService()
        {
            dbContext = new ApplicationDbContext();
        }

        public IEnumerable<Contact> GetMany()
        {
            var contacts = dbContext.Contacts
                .AsNoTracking()
                .ToList();
            return contacts;
        }

        public Contact GetOne(int id)
        {
            var contact = dbContext.Contacts
                .AsNoTracking()
                .FirstOrDefault(item => item.Id == id);
            if (contact == null)
            {
                throw new NoRecordFoundException();
            }

            return contact;
        }

        public IEnumerable<Contact> Find(string text)
        {
            var contacts = dbContext.Contacts
                .AsNoTracking()
                .ToList()
                .Where(item => item.FirstName.Contains(text, StringComparison.OrdinalIgnoreCase) ||
                    item.LastName.Contains(text, StringComparison.OrdinalIgnoreCase) ||
                    item.PhoneNo.Contains(text, StringComparison.OrdinalIgnoreCase))
                .ToList();
            return contacts;
        }

        public void AddOne(Contact contact)
        {
            dbContext.Contacts.Add(contact);
            dbContext.SaveChanges();
            dbContext.Entry(contact).State = EntityState.Detached;
        }

        public void UpdateOne(Contact contact)
        {
            dbContext.Contacts.Update(contact);
            dbContext.SaveChanges();
            dbContext.Entry(contact).State = EntityState.Detached;
        }

        public void DeleteOne(int id)
        {
            var contact = GetOne(id);

            dbContext.Contacts.Remove(contact);
            dbContext.SaveChanges();
            dbContext.Entry(contact).State = EntityState.Detached;
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    dbContext.Dispose();
                }

                disposed = true;
            }
        }
    }
}
