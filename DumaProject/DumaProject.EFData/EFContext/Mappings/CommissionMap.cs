using System.Data.Entity.ModelConfiguration;
using DumaProject.Core.Entities;

namespace DumaProject.EFData.EFContext.Mappings
{
    internal class CommissionMap : EntityTypeConfiguration<Commission>
    {
        public CommissionMap()
        {
            HasKey(e => e.Id);
            Property(e => e.Name).IsRequired().HasMaxLength(30);
            HasRequired(e => e.President).WithMany().HasForeignKey(e => e.PresidentId);
            HasMany(e => e.Consist).WithMany(e => e.Commissions);
            HasMany(e => e.Meetings).WithMany();
            HasMany(e => e.JournalRecords).WithMany();
        }
    }
}
