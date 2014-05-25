using System;
using System.Collections.Generic;

namespace DumaProject.Core.Entities
{
    public class Meeting : Entity<long>
    {
        public Meeting()
        {
            Participants = new List<Member>();
        }

        public DateTime Date { get; set; }
        public string Venue { get; set; }
        public int DurationInMinutes { get; set; }
        public bool IsEnded { get; set; }
        public bool IsCancelled { get; set; }
        public virtual Commission Commission { get; set; }
        public int CommissionId { get; set; }
        public virtual List<Member> Participants { get; set; }
    }
}
