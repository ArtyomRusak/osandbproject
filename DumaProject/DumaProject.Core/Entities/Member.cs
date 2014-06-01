using System;
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
        public virtual List<Commission> Commissions { get; set; }

        public string NSP
        {
            get { return String.Format("{0} {1} {2}", Name, Surname, Patronymic); }
        }

        public override string ToString()
        {
            return NSP;
        }
    }
}
