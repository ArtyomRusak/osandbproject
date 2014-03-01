using System.Collections.Generic;

namespace DumaProject.Core.Entities
{
    public class RoleCommission : Entity<int>
    {
        public string Value { get; set; }
        public virtual HashSet<JournalRecord> JournalRecords { get; set; }
    }
}
