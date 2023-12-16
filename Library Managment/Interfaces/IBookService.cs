using Library_Managment.Models;

namespace Library_Managment.Interfaces;

public interface IBookService
{
    public Book addNewBook(Book book);
    public Book displayBookDetails(int id);
    public Book updateBook(Book book);
    public bool deleteBook(int id);
    public List<Book> getBooks();
}

