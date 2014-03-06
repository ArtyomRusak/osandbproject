using System.Data.Entity.ModelConfiguration;
using DumaProject.Core.Entities;

namespace DumaProject.EFData.EFContext.Mappings
{
    internal class ProfileCommissionMap : EntityTypeConfiguration<ProfileCommission>
    {
        public ProfileCommissionMap()
        {
            HasKey(e => e.Id);
            Property(e => e.Description).IsRequired().HasMaxLength(250);
            HasRequired(e => e.Commission).WithMany().HasForeignKey(e => e.CommissionId).WillCascadeOnDelete(false);
        }
    }
}
