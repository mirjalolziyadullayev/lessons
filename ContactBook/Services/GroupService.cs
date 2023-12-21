using ContactBook.Interfaces;
using ContactBook.Models;

namespace ContactBook.Services;

internal class GroupService : IGroupService
{
    public (int ContactID, int GroupID) AddContact(ContactModel model)
    {
        throw new NotImplementedException();
    }

    public GroupModel Create(GroupModel model)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int ID)
    {
        throw new NotImplementedException();
    }

    public List<GroupModel> GetAll()
    {
        throw new NotImplementedException();
    }

    public GroupModel GetById(int id)
    {
        throw new NotImplementedException();
    }

    public List<GroupModel> GetContactsByGroup(int groupID)
    {
        throw new NotImplementedException();
    }

    public GroupModel Update(GroupModel model)
    {
        throw new NotImplementedException();
    }
}
