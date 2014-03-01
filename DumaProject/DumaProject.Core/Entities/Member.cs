using System.Collections.Generic;

namespace DumaProject.Core.Entities
{
    public class Member : Entity<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string PassportData { get; set; }
        public virtual RoleMember Role { get; set; }
        public virtual HashSet<Commission> Commissions { get; set; }
    }
}
