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
                item.Name = user.Name;
                found = item;
            }
        }
        return found;
    }
}
