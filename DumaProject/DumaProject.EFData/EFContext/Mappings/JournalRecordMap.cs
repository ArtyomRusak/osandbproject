using System.Data.Entity.ModelConfiguration;
using DumaProject.Core.Entities;

namespace DumaProject.EFData.EFContext.Mappings
{
    internal class JournalRecordMap : EntityTypeConfiguration<JournalRecord>
    {
        public JournalRecordMap()
        {
            HasKey(e => e.Id);
            Property(e => e.EntryDate).IsRequired();
            HasRequired(e => e.Member).WithMany().HasForeignKey(e => e.MemberId).WillCascadeOnDelete(false);
            HasRequired(e => e.Commission).WithMany().HasForeignKey(e => e.CommissionId);
            HasRequired(e => e.Role).WithMany(e => e.JournalRecords).HasForeignKey(e => e.RoleCommissionId);
        }
    }
}
