using System.Collections.Generic;
using DumaProject.Core.Entities;

namespace DumaProject.BLInterfaces.BLLInterfaces
{
    public interface ICommissionService : IService
    {
        Commission CreateCommission(string name);
        Commission CreateCommission(string name, int presidentId);
        void RemoveCommission(Commission commission);
        Commission GetCommissionById(int commissionId);
        Member SetPresident(int commissionId, Member member);
        void AddMemberToCommission(int commissionId, Member member);
        void ExcludeMemberFromCommission(int commissionId, Member member);
        HashSet<Member> GetMembersOfCommission(int commissionId); 
    }
}
