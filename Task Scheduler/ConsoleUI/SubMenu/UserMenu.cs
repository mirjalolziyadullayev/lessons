using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Scheduler.Services;

namespace Task_Scheduler.ConsoleUI.SubMenu;

internal class UserMenu
{
    private UserService _userService;
    public UserMenu(UserService userService)
    {
        _userService = userService;
    }

}
