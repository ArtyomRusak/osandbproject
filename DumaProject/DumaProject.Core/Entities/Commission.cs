using System.Collections.Generic;

namespace DumaProject.Core.Entities
{
    public class Commission : Entity<int>
    {
        public Commission()
        {
            //JournalRecords = new HashSet<JournalRecord>();
            //Meetings = new HashSet<Meeting>();
            //Consist = new HashSet<Member>();
        }

        public string Name { get; set; }
        public virtual List<Member> Consist { get; set; }
        public virtual ProfileCommission Profile { get; set; }
        public int ProfileCommissionId { get; set; }
        public virtual Member President { get; set; }
        public int PresidentId { get; set; }
        public virtual List<JournalRecord> JournalRecords { get; set; }
        public virtual List<Meeting> Meetings { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
