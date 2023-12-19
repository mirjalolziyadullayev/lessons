using Task_Scheduler.Models;
using Task_Scheduler.Services;

namespace Task_Scheduler.ConsoleUI.SubMenu;

internal class UserMenu
{
    private UserService _userService;
    public UserMenu(UserService userService)
    {
        _userService = userService;
    }

    public void Display()
    {
        bool loop = true;
        while (loop)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Task Scheduler App / User");
            Console.WriteLine("----------------------------------------\n");

            Console.WriteLine(" 1. Create");
            Console.WriteLine(" 2. Update");
            Console.WriteLine(" 3. Delete");
            Console.WriteLine(" 4. Get all\n");
            Console.WriteLine(" 5. Exit...\n");

            Console.WriteLine("----------------------");
            Console.Write(" Enter Your Choice: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateUser:
                    UserModel CreateUser = new UserModel();

                    Console.Write("Enter your Firstname: ");
                    CreateUser.Firstname = Console.ReadLine();
                    Console.Write("Enter your Lastname: ");
                    CreateUser.Lastname = Console.ReadLine();


                    UserModel CreatedUser = _userService.Create(CreateUser);
                    if (CreatedUser != null)
                    {
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine($" User ID: {CreatedUser.Id}");
                        Console.WriteLine($" User FIrstname: {CreatedUser.Firstname}");
                        Console.WriteLine($" User Lastname: {CreatedUser.Lastname}");
                        Console.WriteLine("----------------------------------------\n");
                    }
                    else
                    {
                        Console.WriteLine("------------------------------------------------------");
                        Console.WriteLine(" This user is not found. Press any key to re-enter");
                        Console.WriteLine("------------------------------------------------------\n");
                        Console.ReadLine();
                        goto CreateUser;
                    }
                    break;
                case "2":
                UpdateUser:
                    UserModel UpdateUser = new UserModel();
                    Console.Write("Enter your ID: ");
                    UpdateUser.Id = int.Parse(Console.ReadLine());
                    Console.Write("Enter your Firstname: ");
                    UpdateUser.Firstname = Console.ReadLine();
                    Console.Write("Enter your Lastname: ");
                    UpdateUser.Lastname = Console.ReadLine();

                    UserModel UpdatedUser = _userService.Update(UpdateUser);
                    if (UpdatedUser != null)
                    {
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine($" User ID: {UpdatedUser.Id}");
                        Console.WriteLine($" User FIrstname: {UpdatedUser.Firstname}");
                        Console.WriteLine($" User Lastname: {UpdatedUser.Lastname}");
                        Console.WriteLine("----------------------------------------\n");
                    }
                    else
                    {
                        Console.WriteLine("------------------------------------------------------");
                        Console.WriteLine(" This user is not found. Press any key to re-enter");
                        Console.WriteLine("------------------------------------------------------\n");
                        Console.ReadLine();
                        goto UpdateUser;
                    }
                    break;
                case "3":
                    List<UserModel> AllUsers = _userService.GetAll();
                    if (AllUsers != null)
                    {
                        foreach (UserModel user in AllUsers)
                        {
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine($" User ID: {user.Id}");
                            Console.WriteLine($" User FIrstname: {user.Firstname}");
                            Console.WriteLine($" User Lastname: {user.Lastname}");
                            Console.WriteLine("----------------------------------------\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("------------------------------------------------------");
                        Console.WriteLine(" User list is empty. Press any key to go back");
                        Console.WriteLine("------------------------------------------------------\n");
                        Console.ReadLine();
                        continue;
                    }
                    break;
                case "5":
                    Console.Write("Exit...");
                    Console.ReadLine();
                    loop = false;
                    break;
                default:
                    Console.Write("Wrong input. Press any key to re-enter...");
                    Console.ReadLine();
                    continue;
            }
        }
    }
}
