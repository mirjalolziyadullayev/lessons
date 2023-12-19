using Task_Scheduler.ConsoleUI.SubMenu;
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

    }
}
