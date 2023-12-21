using ContactBook.Models;

namespace ContactBook.Interfaces;

public interface IGroupService
{
    GroupModel Create(GroupModel model);
    GroupModel Update(GroupModel model);
    bool Delete(int ID);
    GroupModel GetById(int id);
    List<GroupModel> GetAll();
    (int ContactID, int GroupID) AddContact(ContactModel model);
    List<GroupModel> GetContactsByGroup(int groupID);
}
