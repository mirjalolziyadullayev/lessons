using Library_Managment_System.Models;

namespace Library_Managment_System.Interfaces;

public interface IMemberService
{
    public Member registerNewMember(Member member);
    public Member displayMemberDetails(int id);
    public bool deleteMember(int id);
    public bool updateMember(Member member);
    public bool borrowBook(int bookId, int memberID);
    public bool returnBook(int bookId, int memberID);
    public List<Book> displayBorrowedBooksByMemberID(int memberID);
    public List<Book> displayBorrowedBooks();
    public List<Member> getAllMembers();
}
