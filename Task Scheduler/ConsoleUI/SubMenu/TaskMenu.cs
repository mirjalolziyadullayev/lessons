using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Scheduler.Services;

namespace Task_Scheduler.ConsoleUI.SubMenu;

internal class TaskMenu
{
    private UserService _userService;
    private TaskService _taskService;
	public TaskMenu(UserService userService, TaskService taskService)
	{
		_userService = userService;
		_taskService = taskService;
	}

	public void Display()
	{

	}
}
