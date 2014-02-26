using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DumaProject.Core.Entities;

namespace DumaProject.EFData.EFContext.Mappings
{
    internal class ProfileCommissionMap : EntityTypeConfiguration<ProfileCommission>
    {
        public ProfileCommissionMap()
        {
            HasKey(e => e.Id);
            Property(e => e.Description).IsRequired().HasMaxLength(250);
        }
    }
}
