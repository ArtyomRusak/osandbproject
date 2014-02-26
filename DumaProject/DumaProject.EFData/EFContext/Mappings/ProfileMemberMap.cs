using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DumaProject.Core.Entities;

namespace DumaProject.EFData.EFContext.Mappings
{
    internal class ProfileMemberMap : EntityTypeConfiguration<ProfileMember>
    {
        public ProfileMemberMap()
        {
            HasKey(e => e.Id);
            //Property(e => e.Address).IsRequired().HasMaxLength(100);
            //Property(e => e.MobileTelephone1).IsRequired().HasMaxLength(20);
            //Property(e => e.HomeNumber).IsRequired().HasMaxLength(20);
            //Property(e => e.MobileTelephone2).HasMaxLength(20);
            HasRequired(e => e.Member).WithMany().HasForeignKey(e => e.MemberId).WillCascadeOnDelete(false);
        }
    }
}
