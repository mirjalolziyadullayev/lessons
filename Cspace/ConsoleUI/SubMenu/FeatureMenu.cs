using Cspace.Interfaces;
using Cspace.Services;

namespace Cspace.ConsoleUI.SubMenu;

public class FeatureMenu
{
    private readonly FeatureService _featureService;
    public FeatureMenu(FeatureService featureService)
    {
        _featureService = featureService;
    }
    public void Display()
    {
        var loop = true;
        while (loop)
        {
            Console.WriteLine("_______ C-Space / Features _______");
            Console.WriteLine(" 1. Create Feature");
            Console.WriteLine(" 2. Update Feature");
            Console.WriteLine(" 3. Delete Feature");
            Console.WriteLine(" 4. Get Feature by ID");
            Console.WriteLine(" 5. Get all Features\n");
            Console.WriteLine(" 6. Go Back to C-Scpace\n\n");

            Console.Write("Enter your choise: ");
            var choise = Console.ReadLine();
            Console.Clear();
            //switch (choise)
            //{
            //    case "1":
            //        _userService.Create();
            //        break;
            //    case "2":
            //        _userService.Update();
            //        break;
            //    case "3":
            //        _userService.Delete();
            //        break;
            //    case "4":
            //        _userService.GetByID();
            //        break;
            //    case "5":
            //        _userService.GetAll();
            //        break;
            //    case "6":
            //        Console.WriteLine("Press any key to confirm...");
            //        Console.ReadLine();

            //        loop = false;
            //        return;
            //}
        }
    }
}
