using Library_Managment_System.Models;
using Library_Managment_System.Services;
using System.Data;

namespace Library_Managment_System.ConsoleUI.SubMenu;

public class BookMenu
{
    public void DisplayBook()
    {
        BookService bookService = new BookService();

        bool loop = true;
        while (loop)
        {
            Console.WriteLine("_____________ LibraryManagment System / Book Service _____________");
            Console.WriteLine(" 1. Create Book");
            Console.WriteLine(" 2. Update Book");
            Console.WriteLine(" 3. Delete Book");
            Console.WriteLine(" 4. Get All Books");
            Console.WriteLine(" 5. Display Book Details By ID");
            Console.WriteLine(" 6. Go Back... ");

            Console.Write("Enter your chose: >>> ");
            var choise = Console.ReadLine();
            Console.Clear();
            switch (choise)
            {
                case "1":
                    create:
                    string cbookname = string.Empty;
                    string cbookauthor = string.Empty;
                    string cbookgenre = string.Empty;
                    string cbookyear = string.Empty;


                    Console.WriteLine("_____________ LibraryManagment System / Book Service / Create _____________");
                    Console.Write(" Enter Book Name/Title: ");
                    cbookname = Console.ReadLine();
                    Console.WriteLine(" Enter Book's Author: ");
                    cbookauthor = Console.ReadLine();
                    Console.WriteLine(" Enter Book's Genre: ");
                    cbookgenre = Console.ReadLine();
                    Console.WriteLine(" Enter Book's Published year: ");
                    cbookyear = Console.ReadLine();

                    Book cbook = new Book();
                    cbook.Title = cbookname;
                    cbook.Author = cbookauthor;
                    cbook.PublicationYear = cbookyear;
                    cbook.Genre = cbookgenre;

                    Book ccreatedBook = bookService.addNewBook(cbook);
                    if (ccreatedBook != null)
                    {
                        Console.WriteLine("Success. Book added to library...\n");
                        Console.WriteLine(
                            $" Book's ID: {ccreatedBook.Id},\n" +
                            $" Book's Name: {ccreatedBook.Title},\n" +
                            $" Book's Author: {ccreatedBook.Author},\n" +
                            $" Book's Genre: {ccreatedBook.Genre},\n" +
                            $" Book's Published Year: {ccreatedBook.PublicationYear},\n" +
                            $" Book's isBorrowed Status {ccreatedBook.isBorrowed}\n"
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
                    int ubookid = 0;
                    string ubookname = string.Empty;
                    string ubookauthor = string.Empty;
                    string ubookgenre = string.Empty;
                    string ubookyear = string.Empty;


                    Console.WriteLine("_____________ LibraryManagment System / Book Service / Update _____________");
                    Console.Write(" Enter Book's ID: ");
                    ubookid = int.Parse(Console.ReadLine());
                    Console.Write(" Enter Book Name/Title: ");
                    ubookname = Console.ReadLine();
                    Console.WriteLine(" Enter Book's Author: ");
                    ubookauthor = Console.ReadLine();
                    Console.WriteLine(" Enter Book's Genre: ");
                    ubookgenre = Console.ReadLine();
                    Console.WriteLine(" Enter Book's Published year: ");
                    ubookyear = Console.ReadLine();

                    Book ubook = new Book();
                    ubook.Title = ubookname;
                    ubook.Author = ubookauthor;
                    ubook.PublicationYear = ubookyear;
                    ubook.Genre = ubookgenre;

                    Book uupdateBook = bookService.updateBook(ubook);
                    if (uupdateBook != null)
                    {
                        Console.WriteLine("Success. Book updated...\n");
                        Console.WriteLine(
                            $" Book's ID: {uupdateBook.Id},\n" +
                            $" Book's Name: {uupdateBook.Title},\n" +
                            $" Book's Author: {uupdateBook.Author},\n" +
                            $" Book's Genre: {uupdateBook.Genre},\n" +
                            $" Book's Published Year: {uupdateBook.PublicationYear},\n" +
                            $" Book's isBorrowed Status {uupdateBook.isBorrowed}\n"
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
                    int dbookid = 0;

                    Console.WriteLine("_____________ LibraryManagment System / Book Service / Delete _____________");
                    Console.Write(" Enter Book's ID: ");
                    ubookid = int.Parse(Console.ReadLine());

                    bool ddeletebook = bookService.deleteBook(dbookid);
                    if (ddeletebook != false)
                    {
                        Console.WriteLine("Success. Book deleted...\n");
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

                    Console.WriteLine("_____________ LibraryManagment System / Book Service / Get All _____________");
                    foreach (Book book in bookslist)
                    {
                        Console.WriteLine(
                            $"__________________________________________________"+
                            $" Book's ID: {book.Id},\n" +
                            $" Book's Name: {book.Title},\n" +
                            $" Book's Author: {book.Author},\n" +
                            $" Book's Genre: {book.Genre},\n" +
                            $" Book's Published Year: {book.PublicationYear},\n" +
                            $" Book's isBorrowed Status {book.isBorrowed}\n" +
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
                case "6":
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
