using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DumaProject.Core.Entities;

namespace DumaProject.EFData.EFContext.Mappings
{
    internal class RoleCommissionMap : EntityTypeConfiguration<RoleCommission>
    {
        public RoleCommissionMap()
        {
            HasKey(e => e.Id);
            Property(e => e.Value).IsRequired().HasMaxLength(20);
        }
    }
}
