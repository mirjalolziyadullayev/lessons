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
            Console.WriteLine(" 2. Delete");
            Console.WriteLine(" 2. Get all");
            Console.WriteLine(" 3. Exit...\n");

            Console.WriteLine("----------------------");
            Console.Write(" Enter Your Choice: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreatedUser:
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
                        goto CreatedUser;
                    }
                    break;
                case "2":
                    taskMenu.Display();
                    break;
                case "3":
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
