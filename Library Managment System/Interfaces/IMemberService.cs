using Library_Managment_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Managment_System.Interfaces
{
    internal interface IMemberService
    {
        public void registerNewMember(Member member);
        public void displayMemberDetails(int id);
        public bool deleteMember(int id);
        public bool borrowBook (int bookId);
        public bool returnBook (int bookId);
        public List<Book> displayBorrowedBooks(int memberId);
    }
}
