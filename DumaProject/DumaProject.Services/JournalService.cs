using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DumaProject.BLInterfaces.BLLInterfaces;
using DumaProject.BLInterfaces.Exceptions;
using DumaProject.Core.Entities;
using DumaProject.Core.Exceptions;
using DumaProject.DALInterfaces;

namespace DumaProject.Services
{
    public class JournalService : BaseService, IJournalService
    {
        public JournalService(IUnitOfWork unitOfWork, IRepositoryFactory repositoryFactory)
            : base(unitOfWork, repositoryFactory)
        {
        }

        public JournalRecord CreateRecord(DateTime entryDate, int memberId, int commissionId, int roleId)
        {
            var journalRecordRepository = RepositoryFactory.GetJournalRecordRepository();

            var record = new JournalRecord
            {
                EntryDate = entryDate,
                MemberId = memberId,
                CommissionId = commissionId,
                RoleCommissionId = roleId
            };
            journalRecordRepository.Create(record);

            try
            {
                UnitOfWork.PreSave();
            }
            catch (Exception ex)
            {
                throw new JournalServiceException(ex);
            }

            return record;
        }

        public void UpdateRecord(JournalRecord record)
        {
            var journalRecordRepository = RepositoryFactory.GetJournalRecordRepository();

            try
            {
                journalRecordRepository.Update(record);
            }
            catch (RepositoryException ex)
            {
                throw new JournalServiceException(ex);
            }
        }

        public JournalRecord GetRecordById(long recordId)
        {
            var journalRecordRepository = RepositoryFactory.GetJournalRecordRepository();

            try
            {
                var record = journalRecordRepository.GetEntityById(recordId);
                return record;
            }
            catch (RepositoryException ex)
            {
                throw new JournalServiceException(ex);
            }
        }

        public HashSet<JournalRecord> GetRecordsForCommission(int commissionId)
        {
            var journalRecordRepository = RepositoryFactory.GetJournalRecordRepository();

            try
            {
                var records = journalRecordRepository.Filter(e => e.CommissionId == commissionId).ToList();
                return new HashSet<JournalRecord>(records);
            }
            catch (RepositoryException ex)
            {
                throw new JournalServiceException(ex);
            }
        }

        public HashSet<JournalRecord> GetRecordsForEmployee(int employeeId)
        {
            var journalRecordRepository = RepositoryFactory.GetJournalRecordRepository();

            try
            {
                var records = journalRecordRepository.Filter(e => e.MemberId == employeeId).ToList();
                return new HashSet<JournalRecord>(records);
            }
            catch (RepositoryException ex)
            {
                throw new JournalServiceException(ex);
            }
        }

        public HashSet<JournalRecord> GetRecordsForRoleInCommission(int roleId, int commissionId)
        {
            var journalRecordRepository = RepositoryFactory.GetJournalRecordRepository();

            try
            {
                var records = journalRecordRepository.Filter(e => e.CommissionId == commissionId && e.RoleCommissionId == roleId).ToList();
                return new HashSet<JournalRecord>(records);
            }
            catch (RepositoryException ex)
            {
                throw new JournalServiceException(ex);
            }
        }
    }
}
