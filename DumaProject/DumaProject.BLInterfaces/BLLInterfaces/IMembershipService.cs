using System.Collections.Generic;
using DumaProject.Core.Entities;

namespace DumaProject.BLInterfaces.BLLInterfaces
{
    public interface IMembershipService : IService
    {
        Member CreateMember(string name, string surname, string patronymic, string passportData);
        void UpdateMember(Member member);
        void RemoveMember(Member member);
        Member GetMemberById(int memberId);
        void ChangeRole(int memberId, RoleMember role);
        HashSet<Commission> GetCommissionsOfMember(int memberId);
    }
}
