using ContactManager.Models;

namespace ContactManager.Services
{
    public interface IContactService
    {
        IEnumerable<Contact> GetMany();
        Contact GetOne(int id);
        IEnumerable<Contact> Find(string text);
        void AddOne(Contact contact);
        void UpdateOne(Contact contact);
        void DeleteOne(int id);
    }
}
