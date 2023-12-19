using Task_Scheduler.Models;

namespace Task_Scheduler.Interfaces;

public interface IUserService
{
    UserModel Create(UserModel user);
    UserModel Update(UserModel user);
    bool Delete(UserModel user);
    List<UserModel> GetAll();
    UserModel Get(int id);
}
