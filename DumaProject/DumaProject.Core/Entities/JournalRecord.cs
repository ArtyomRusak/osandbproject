using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DumaProject.Core.Entities
{
    public class JournalRecord : Entity<long>
    {
        public DateTime EntryDate { get; set; }
        public DateTime ExitDate { get; set; }
        public virtual Member Member { get; set; }
        public int MemberId { get; set; }
        public virtual Commission Commission { get; set; }
        public int CommissionId { get; set; }
        public virtual RoleCommission Role { get; set; }
        public int RoleCommissionId { get; set; }
    }
}
