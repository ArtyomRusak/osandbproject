using System.Data.Entity.ModelConfiguration;
using DumaProject.Core.Entities;

namespace DumaProject.EFData.EFContext.Mappings
{
    internal class MeetingMap : EntityTypeConfiguration<Meeting>
    {
        public MeetingMap()
        {
            Property(e => e.Date).IsRequired();
            Property(e => e.Venue).IsRequired().HasMaxLength(100);
            Property(e => e.DurationInMinutes).IsRequired();
            HasRequired(e => e.Commission).WithMany(e => e.Meetings).HasForeignKey(e => e.CommissionId);
            HasMany(e => e.Participants).WithMany();
        }
    }
}
