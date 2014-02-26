using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DumaProject.Core.Entities;
using DumaProject.DALInterfaces;
using DumaProject.EFData.EFContext;

namespace DumaProject.EFData
{
    public class UnitOfWork : IUnitOfWork, IRepositoryFactory
    {
        private DumaContext _context;

        public IRepository<Member, int> GetMemberRepository()
        {
            throw new NotImplementedException();
        }

        public IRepository<RoleMember, int> GetRoleMemberRepository()
        {
            throw new NotImplementedException();
        }

        public IRepository<RoleCommission, int> GetRoleCommissionRepository()
        {
            throw new NotImplementedException();
        }

        public IRepository<ProfileMember, int> GetProfileMemberRepository()
        {
            throw new NotImplementedException();
        }

        public IRepository<ProfileCommission, int> GetProfileCommissionRepository()
        {
            throw new NotImplementedException();
        }

        public IRepository<Commission, int> GetCommissionRepository()
        {
            throw new NotImplementedException();
        }

        public IRepository<JournalRecord, long> GetJournalRecordRepository()
        {
            throw new NotImplementedException();
        }

        public IRepository<Meeting, long> GetMeetingRepository()
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void Rollback()
        {
            throw new NotImplementedException();
        }

        public void PreSave()
        {
            throw new NotImplementedException();
        }
    }
}
