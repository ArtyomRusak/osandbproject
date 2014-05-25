using System.Collections.Generic;

namespace DumaProject.Core.Entities
{
    public class ProfileCommission : Entity<int>
    {
        public string Description { get; set; }
        public virtual List<Commission> Commissions { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}
