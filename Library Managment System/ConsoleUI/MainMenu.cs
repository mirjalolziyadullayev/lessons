using Library_Managment_System.ConsoleUI.SubMenu;

namespace Library_Managment_System.ConsoleUI;

public class MainMenu
{
    public void Display()
    {
        BookMenu bookMenu;
        MemberMenu memberMenu;

        bool loop = true;
        while (loop)
        {
            Console.WriteLine("_____________ Library Managment System _____________");
            Console.WriteLine(" 1. Manage Books");
            Console.WriteLine(" 2. Manage Members");
            Console.WriteLine(" 3. Exit\n");

            Console.Write("Enter your chose: >>> ");
            var choise = Console.ReadLine();
            Console.Clear();
            switch (choise)
            {
                case "1":
                    bookMenu = new BookMenu();
                    bookMenu.DisplayBook();
                    break;
                case "2":
                    memberMenu = new MemberMenu();
                    memberMenu.DisplayMember();
                    break;
                case "3":
                    loop = false;
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Wrong choose!\nPress any key to re-enter");
                    Console.ReadLine();
                    continue;
            }
        }
    }
}
