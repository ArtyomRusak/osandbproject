using System.Data.Entity.ModelConfiguration;
using DumaProject.Core.Entities;

namespace DumaProject.EFData.EFContext.Mappings
{
    internal class MemberMap : EntityTypeConfiguration<Member>
    {
        public MemberMap()
        {
            HasKey(e => e.Id);
            Property(e => e.Name).IsRequired().HasMaxLength(30);
            Property(e => e.Surname).IsRequired().HasMaxLength(40);
            Property(e => e.Patronymic).IsRequired().HasMaxLength(40);
            Property(e => e.PassportData).IsRequired().HasMaxLength(9);
            HasMany(e => e.Commissions).WithMany(e => e.Consist);
        }
    }
}
