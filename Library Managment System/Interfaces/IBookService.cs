using Library_Managment_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Managment_System.Interfaces
{
    internal interface IBookService
    {
        public void addNewBook(Book book);
        public Book displayBookDetails(int id);
        public bool deleteBook(int id);
    }
}

