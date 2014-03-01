using System;
using System.Collections.Generic;

namespace DumaProject.Core.Entities
{
    public class Meeting : Entity<long>
    {
        public DateTime Date { get; set; }
        public string Venue { get; set; }
        public int DurationInMinutes { get; set; }
        public virtual Commission Commission { get; set; }
        public int CommissionId { get; set; }
        public virtual HashSet<Member> Participants { get; set; }
    }
}
