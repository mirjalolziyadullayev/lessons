using ContactBook.Models;

namespace ContactBook.Interfaces;

public interface IContactService
{
    ContactModel Create(ContactModel contact);
    ContactModel Update(ContactModel contact);
    bool Delete(ContactModel contact);
    ContactModel GetByID(int id);
    List<ContactModel> GetAll();
}
