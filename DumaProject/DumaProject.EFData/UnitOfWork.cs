using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DumaProject.Core.Entities;
using DumaProject.Core.Exceptions;
using DumaProject.DALInterfaces;
using DumaProject.EFData.EFContext;
using DumaProject.EFData.Repositories;

namespace DumaProject.EFData
{
    public class UnitOfWork : IUnitOfWork, IRepositoryFactory, IDisposable
    {
        private DumaContext _context;
        private DbContextTransaction _transaction;
        private bool _isTransactionActive;
        private bool _disposed;
        private IRepository<Member, int> _memberRepository;
        private IRepository<RoleMember, int> _roleMemberRepository;
        private IRepository<RoleCommission, int> _roleCommissionRepository;
        private IRepository<ProfileMember, int> _profileMemberRepository;
        private IRepository<ProfileCommission, int> _profileCommissionRepository;
        private IRepository<Commission, int> _commissionRepository;
        private IRepository<JournalRecord, long> _journalRecordRepository;
        private IRepository<Meeting, long> _meetingRepository;

        public UnitOfWork(DumaContext context)
        {
            _context = context;
            _transaction = _context.Database.BeginTransaction();
            _isTransactionActive = true;
        }

        public IRepository<Member, int> GetMemberRepository()
        {
            return _memberRepository ?? (_memberRepository = new Repository<Member, int>(_context));
        }

        public IRepository<RoleMember, int> GetRoleMemberRepository()
        {
            return _roleMemberRepository ?? (_roleMemberRepository = new Repository<RoleMember, int>(_context));
        }

        public IRepository<RoleCommission, int> GetRoleCommissionRepository()
        {
            return _roleCommissionRepository ??
                   (_roleCommissionRepository = new Repository<RoleCommission, int>(_context));
        }

        public IRepository<ProfileMember, int> GetProfileMemberRepository()
        {
            return _profileMemberRepository ?? (_profileMemberRepository = new Repository<ProfileMember, int>(_context));
        }

        public IRepository<ProfileCommission, int> GetProfileCommissionRepository()
        {
            return _profileCommissionRepository ??
                   (_profileCommissionRepository = new Repository<ProfileCommission, int>(_context));
        }

        public IRepository<Commission, int> GetCommissionRepository()
        {
            return _commissionRepository ?? (_commissionRepository = new Repository<Commission, int>(_context));
        }

        public IRepository<JournalRecord, long> GetJournalRecordRepository()
        {
            return _journalRecordRepository ??
                   (_journalRecordRepository = new Repository<JournalRecord, long>(_context));
        }

        public IRepository<Meeting, long> GetMeetingRepository()
        {
            return _meetingRepository ?? (_meetingRepository = new Repository<Meeting, long>(_context));
        }

        public void Commit()
        {
            try
            {
                if (_isTransactionActive && !_disposed)
                {
                    _context.SaveChanges();
                    _transaction.Commit();
                    _isTransactionActive = false;
                }
            }
            catch (Exception e)
            {
                _transaction.Rollback();
                _isTransactionActive = false;
                throw new RepositoryException(e.Message);
            }
        }

        public void Rollback()
        {
            if (_isTransactionActive && !_disposed)
            {
                _transaction.Rollback();
                _isTransactionActive = false;
            }
        }

        public void PreSave()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            if (_isTransactionActive)
            {
                try
                {
                    _context.SaveChanges();
                    _transaction.Commit();
                    _isTransactionActive = false;
                }
                catch (Exception e)
                {
                    _transaction.Rollback();
                    _isTransactionActive = false;

                    _context.Dispose();
                    _disposed = true;

                    throw new RepositoryException(e.Message);
                }
            }
            if (!_disposed)
            {
                _context.Dispose();
                _disposed = true;
            }
        }
    }
}
