using DumaProject.Core.Entities;

namespace DumaProject.DALInterfaces
{
    public interface IRepositoryFactory
    {
        IRepository<Member, int> GetMemberRepository();
        IRepository<RoleMember, int> GetRoleMemberRepository();
        IRepository<RoleCommission, int> GetRoleCommissionRepository();
        IRepository<ProfileMember, int> GetProfileMemberRepository();
        IRepository<ProfileCommission, int> GetProfileCommissionRepository();
        IRepository<Commission, int> GetCommissionRepository();
        IRepository<JournalRecord, long> GetJournalRecordRepository();
        IRepository<Meeting, long> GetMeetingRepository();
    }
}
