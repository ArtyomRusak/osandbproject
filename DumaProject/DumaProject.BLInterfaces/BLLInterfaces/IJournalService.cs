using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DumaProject.Core.Entities;

namespace DumaProject.BLInterfaces.BLLInterfaces
{
    public interface IJournalService : IService
    {
        JournalRecord CreateRecord(DateTime entryDate, int memberId, int commissionId, int roleId);
        void UpdateRecord(JournalRecord record);
        JournalRecord GetRecordById(long recordId);
        HashSet<JournalRecord> GetRecordsForCommission(int commissionId);
        HashSet<JournalRecord> GetRecordsForEmployee(int employeeId);
        HashSet<JournalRecord> GetRecordsForRoleInCommission(int roleId, int commissionId);
    }
}
