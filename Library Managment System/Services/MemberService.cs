using Library_Managment_System.Interfaces;
using Library_Managment_System.Models;

namespace Library_Managment_System.Services
{
    public class MemberService : IMemberService
    {
        List<Member> members;

        public MemberService()
        {
            members = new List<Member>();
        }
        public bool borrowBook(int bookId)
        {
            throw new NotImplementedException();
        }

        public bool deleteMember(int id)
        {
            throw new NotImplementedException();
        }

        public void displayMemberDetails(int id)
        {
            throw new NotImplementedException();
        }

        public void registerNewMember(Member member)
        {
            member.membershipId = members.Last().membershipId + 1;
            members.Add(member);
        }

        public bool returnBook(int bookId)
        {
            return false;
        }

        List<Book> IMemberService.displayBorrowedBooks(int memberId)
        {
            return Book;
        }
    }
}
