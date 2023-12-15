using Library_Managment_System.Models;
using Library_Managment_System.Services;

namespace Library_Managment_System.ConsoleUI.SubMenu;

public class MemberMenu
{
    public void DisplayMember()
    {
        BookService bookService = new BookService();
        MemberService memberService = new MemberService();

        bool loop = true;
        while (loop)
        {
            Console.WriteLine("_____________ LibraryManagment System / Member Service _____________");
            Console.WriteLine(" 1. Create Member");
            Console.WriteLine(" 2. Update Member");
            Console.WriteLine(" 3. Delete Member");
            Console.WriteLine(" 4. Get All Members");
            Console.WriteLine(" 5. Borrow Book");
            Console.WriteLine(" 6. Return Book");
            Console.WriteLine(" 7. Display Members Borrowed Books\n");
            Console.WriteLine(" 8. Go Back... ");

            Console.Write("Enter your chose: >>> ");
            var choise = Console.ReadLine();
            Console.Clear();
            switch (choise)
            {
                case "1":
                create:
                    string cmembername = string.Empty;
                    string cmemberphoneoremail = string.Empty;


                    Console.WriteLine("_____________ LibraryManagment System / Book Service / Create _____________");
                    Console.Write(" Enter Member's name/full name: ");
                    cmembername = Console.ReadLine();
                    Console.Write(" Enter Member's phone/email: ");
                    cmemberphoneoremail= Console.ReadLine();

                    Member member = new Member();
                    member.name = cmembername;
                    member.phoneoremail = cmemberphoneoremail;

                    Member ccreatedMember = memberService.registerNewMember(member);
                    if (ccreatedMember != null)
                    {
                        Console.WriteLine("Success. Member registered...\n");
                        Console.WriteLine(
                            $" Member's ID: {ccreatedMember.membershipId},\n" +
                            $" Member's Name: {ccreatedMember.name},\n" +
                            $" Member's Author: {ccreatedMember.phoneoremail}\n"
                        );
                    }
                    else
                    {
                        Console.WriteLine("Aaugh, Dumbass. Enter Valid ID again!\n");
                        Console.WriteLine("Press any key to re-enter...");
                        Console.ReadLine();
                        goto create;
                    }

                    break;
                case "2":
                update:
                    int umemberid = 0;
                    string umembername = string.Empty;
                    string umemberphoneoremail = string.Empty;


                    Console.WriteLine("_____________ LibraryManagment System / Book Service / Update _____________");
                    Console.Write(" Enter Member's ID: ");
                    umemberid = int.Parse(Console.ReadLine());
                    Console.Write(" Enter Member's name/full name: ");
                    cmembername = Console.ReadLine();
                    Console.Write(" Enter Member's phone/email: ");
                    cmemberphoneoremail = Console.ReadLine();

                    Member updatemember = new Member();
                    updatemember.membershipId = umemberid;
                    updatemember.name = cmembername;
                    updatemember.phoneoremail = cmemberphoneoremail;

                    bool found = memberService.updateMember(updatemember);
                    if (found != false)
                    {
                        Console.WriteLine("Success. Member updated...\n");
                        Console.WriteLine(
                            $" Member's ID: {updatemember.membershipId},\n" +
                            $" Member's Name: {updatemember.name},\n" +
                            $" Member's Phone or email: {updatemember.phoneoremail}\n"
                        );
                    }
                    else
                    {
                        Console.WriteLine("Aaugh, Dumbass. Enter Valid ID again!\n");
                        Console.WriteLine("Press any key to re-enter...");
                        Console.ReadLine();
                        goto update;
                    }

                    break;
                case "3":
                delete:
                    int dmemberid = 0;

                    Console.WriteLine("_____________ LibraryManagment System / Member Service / Delete _____________");
                    Console.Write(" Enter Book's ID: ");
                    dmemberid = int.Parse(Console.ReadLine());

                    bool ddeletemember = memberService.deleteMember(dmemberid);
                    if (ddeletemember != false)
                    {
                        Console.WriteLine("Success. Member deleted...\n");
                    }
                    else
                    {
                        Console.WriteLine("Aaugh, Dumbass. Enter Valid ID again!\n");
                        Console.WriteLine("Press any key to re-enter...");
                        Console.ReadLine();
                        goto delete;
                    }

                    break;
                case "4":
                    List<Book> bookslist = new List<Book>();
                    bookslist = bookService.getBooks();

                    Console.WriteLine("_____________ LibraryManagment System / Member Service / Get All _____________");
                    List<Member> memberlist = memberService.getAllMembers();
                    foreach (Member memberitem in memberlist)
                    {
                        Console.WriteLine(
                            $"__________________________________________________" +
                            $" Member's ID: {memberitem.membershipId},\n" +
                            $" Member's Name: {memberitem.name},\n" +
                            $" Member's Phone or Email: {memberitem.phoneoremail},\n" +
                            $"__________________________________________________"
                        );
                    }

                    break;
                case "5":
                displaybookdetails:
                    int dsiplaybookid = 0;

                    Console.WriteLine("_____________ LibraryManagment System / Book Service / Display Book Details By ID _____________");
                    Console.Write(" Enter Book's ID: ");
                    dbookid = int.Parse(Console.ReadLine());
                    var displaybook = bookService.displayBookDetails(dsiplaybookid);
                    if (displaybook != null)
                    {
                        Console.WriteLine(
                        $"__________________________________________________" +
                        $" Book's ID: {displaybook.Id},\n" +
                        $" Book's Name: {displaybook.Title},\n" +
                        $" Book's Author: {displaybook.Author},\n" +
                        $" Book's Genre: {displaybook.Genre},\n" +
                        $" Book's Published Year: {displaybook.PublicationYear},\n" +
                        $" Book's isBorrowed Status {displaybook.isBorrowed}\n" +
                        $"__________________________________________________"
                    );
                    }
                    else
                    {
                        Console.WriteLine("Aaugh, Dumbass. Enter Valid ID again!\n");
                        Console.WriteLine("Press any key to re-enter...");
                        Console.ReadLine();
                        goto displaybookdetails;
                    }

                    break;
                case "8":
                    loop = false;
                    Console.WriteLine("Press any key to exit Book Service...");
                    Console.ReadLine();
                    return;
                default:
                    Console.WriteLine("Wrong choose!\nPress any key to re-enter");
                    Console.ReadLine();
                    continue;
            }
        }
    }
}
