using System.Collections.Generic;

namespace DumaProject.Core.Entities
{
    public class Commission : Entity<int>
    {
        public Commission()
        {
            JournalRecords = new HashSet<JournalRecord>();
            Meetings = new HashSet<Meeting>();
            Consist = new HashSet<Member>();
        }

        public string Name { get; set; }
        public virtual HashSet<Member> Consist { get; set; }
        public ProfileCommission Profile { get; set; }
        public Member President { get; set; }
        public int PresidentId { get; set; }
        public virtual HashSet<JournalRecord> JournalRecords { get; set; }
        public virtual HashSet<Meeting> Meetings { get; set; }
    }
}
