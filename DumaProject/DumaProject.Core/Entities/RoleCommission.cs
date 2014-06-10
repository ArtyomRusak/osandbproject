using System.Collections.Generic;

namespace DumaProject.Core.Entities
{
    public class RoleCommission : Entity<int>
    {
        public RoleCommission()
        {
            JournalRecords = new List<JournalRecord>();
        }

        public string Value { get; set; }
        public virtual List<JournalRecord> JournalRecords { get; set; }
    }
}