using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public Member CheckExistAccount(string Email, string Password) => MemberDAO.Instance.CheckExistAccount(Email, Password);  

        public void Delete(int MemberID) => MemberDAO.Instance.Delete(MemberID);

        public Member GetMemberByID(int MemberID) => MemberDAO.Instance.GetMemberByID(MemberID);

        public IEnumerable<Member> GetMembers() => MemberDAO.Instance.GetMembers();

        public void Insert(Member member)  => MemberDAO.Instance.Insert(member);

        public void Update(Member member) => MemberDAO.Instance.Update(member);
        
    }
}
