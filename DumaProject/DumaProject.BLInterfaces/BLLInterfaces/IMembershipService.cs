using System.Collections.Generic;
using DumaProject.Core.Entities;

namespace DumaProject.BLInterfaces.BLLInterfaces
{
    public interface IMembershipService : IService
    {
        Member CreateMember(string name, string surname, string patronymic, string passportData, string roleName);
        void UpdateMember(Member member);
        void RemoveMember(Member member);
        Member GetMemberById(int memberId);
        void ChangeRole(int memberId, RoleMember role);
        List<Commission> GetCommissionsOfMember(int memberId);
        List<Member> GetMembersExceptOfCommission(int commissionId);
    }
}
