using Task_Scheduler.Interfaces;
using Task_Scheduler.Models;

namespace Task_Scheduler.Services;

public class UserService : IUserService
{
    List<UserModel> _users;

    public UserService()
    {
        _users = new List<UserModel>();
    }
    public UserModel Create(UserModel user)
    {
        user.Id = _users.Count + 1;
        _users.Add(user);
        return user;
    }

    public bool Delete(UserModel user)
    {
        bool found = false;
        foreach (var item in _users)
        {
            if (user.Id == item.Id)
            {
                _users.Remove(item);
                found = true;
            }
        }
        return found;
    }

    public UserModel Get(int id)
    {
        UserModel user = null;
        foreach (var item in _users)
        {
            if (item.Id == id)
            {
                user = item;
                break;
            }
        }
        if (user == null)
        {
            throw new Exception("This user is not found");
        }
        return user;
    }

    public List<UserModel> GetAll()
    {
        return _users;
    }

    public UserModel Update(UserModel user)
    {
        UserModel found = null;
        foreach (var item in _users)
        {
            if (user.Id == item.Id)
            {
                item.Firstname = user.Firstname;
                item.Lastname = user.Lastname;
                found = item;
            }
        }
        return found;
    }
}
