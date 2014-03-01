using System.Data.Entity.ModelConfiguration;
using DumaProject.Core.Entities;

namespace DumaProject.EFData.EFContext.Mappings
{
    internal class RoleMemberMap : EntityTypeConfiguration<RoleMember>
    {
        public RoleMemberMap()
        {
            HasKey(e => e.Id);
            Property(e => e.Value).IsRequired().HasMaxLength(25);
        }
    }
}
