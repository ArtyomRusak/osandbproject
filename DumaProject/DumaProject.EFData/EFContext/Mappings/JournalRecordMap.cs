using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DumaProject.Core.Entities;

namespace DumaProject.EFData.EFContext.Mappings
{
    internal class JournalRecordMap : EntityTypeConfiguration<JournalRecord>
    {
        public JournalRecordMap()
        {
            HasKey(e => e.Id);
            Property(e => e.EntryDate).IsRequired();
            Property(e => e.ExitDate).IsRequired();
            HasRequired(e => e.Member).WithMany().HasForeignKey(e => e.MemberId).WillCascadeOnDelete(false);
            HasRequired(e => e.Commission).WithMany().HasForeignKey(e => e.CommissionId);
            HasRequired(e => e.Role).WithMany(e => e.JournalRecords).HasForeignKey(e => e.RoleCommissionId);
        }
    }
}
