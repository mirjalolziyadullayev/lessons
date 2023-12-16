using Library_Managment.Interfaces;
using Library_Managment.Models;

namespace Library_Managment.Services;

public class BookService : IBookService
{
    List<Book> books;
    List<Book> borrowedBooks;

    MemberService memberService;
    public BookService()
    {
        books = new List<Book>();
        memberService = new MemberService();
        borrowedBooks = memberService.displayBorrowedBooks();
    }
    public Book addNewBook(Book book)
    {
        book.Id = books.Last().Id + 1;
        books.Add(book);
        return book;
    }
    public Book updateBook(Book book) 
    {
        Book foundAndUpdated = null;
        foreach (var item in books)
        {
            if (item.Id == book.Id)
            {
                item.Title = book.Title;
                item.Author = book.Author;
                item.Genre = book.Genre;
                item.PublicationYear = book.PublicationYear;
                foundAndUpdated = item;
            }
        }
        return foundAndUpdated;
    }
    public bool deleteBook(int id)
    {
        var found = false;
        foreach (var book in books)
        {
            if (book.Id == id)
            {
                books.Remove(book);
                found = true;
                break;
            }
        }
        return found;
    }
    public Book displayBookDetails(int id)
    {
        Book found = null;
        foreach (var book in books)
        {
            if (book.Id == id)
            {
                foreach (var borrowedBook in borrowedBooks) 
                {
                    if (borrowedBook.Id == book.Id)
                    {
                        book.isBorrowed = true;
                        book.borrowedMemberID = borrowedBook.borrowedMemberID;
                        book.isAvailable = false;
                    }
                }
                found = book;
                break;
            }
        }
        return found;
    }
    public List<Book> getBooks() 
    {
        foreach (Book book in books)
        {
            foreach (Book borrowed in borrowedBooks)
            {
                if (book.Id == borrowed.Id)
                {
                    book.isBorrowed= true;
                    book.borrowedMemberID = borrowed.borrowedMemberID;
                    book.isAvailable = false;
                }
            }
        }
        return books;
    }
}
