using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DumaProject.Core.Entities
{
    public class RoleCommission : Entity<int>
    {
        public string Value { get; set; }
        public virtual HashSet<JournalRecord> JournalRecords { get; set; }
    }
}
