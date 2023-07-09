using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Models;
namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        public IEnumerable<Member> GetMembers();
        public Member GetMemberByID(int MemberID);
        public void Insert(Member member);
        public void Update(Member member);
        public void Delete(int MemberID);
        public Member CheckExistAccount(string Email, string Password);
    }
}
