﻿using Task_Scheduler.ConsoleUI.SubMenu;
using Task_Scheduler.Services;

namespace Task_Scheduler.ConsoleUI;

internal class MainMenu
{
    private readonly UserService userService;
    private readonly TaskService taskService;

    private readonly UserMenu userMenu;
    private readonly TaskMenu taskMenu;

    public MainMenu()
    {
        this.userService = new UserService();
        this.taskService = new TaskService(userService);

        this.userMenu = new UserMenu(userService);
        this.taskMenu = new TaskMenu(userService, taskService);
    }

    public void Display()
    {
        bool loop = true;
        while (loop)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Task Scheduler App");
            Console.WriteLine("----------------------------------------\n");

            Console.WriteLine(" 1. Manage Users");
            Console.WriteLine(" 2. Manage Tasks");
            Console.WriteLine(" 3. Exit...\n");

            Console.WriteLine("----------------------");
            Console.Write(" Enter Your Choice: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    userMenu.Display();
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
