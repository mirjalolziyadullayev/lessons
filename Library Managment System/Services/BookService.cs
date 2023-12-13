using Library_Managment_System.Interfaces;
using Library_Managment_System.Models;

namespace Library_Managment_System.Services
{
    internal class BookService : IBookService
    {
        List<Book> books;

        public BookService()
        {
            books = new List<Book>();
        }
        public void addNewBook(Book book)
        {
            book.Id = books.Last().Id + 1;
            books.Add(book);
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
                    found = book;
                    break;
                }
            }
            return found;
        }
    }
}
