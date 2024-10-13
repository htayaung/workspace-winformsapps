using ContactManager.Models;

namespace ContactManager.ViewModels
{
    public class ContactVM : Contact
    {
        public int SerialNo { get; set; }

        public static ContactVM From(Contact contact)
        {
            return new ContactVM
            {
                Id = contact.Id,
                FirstName = contact.FirstName,
                LastName = contact.LastName,
                PhoneNo = contact.PhoneNo,
                Email = contact.Email,
                Address = contact.Address,
                Website = contact.Website,
            };
        }
    }
}
