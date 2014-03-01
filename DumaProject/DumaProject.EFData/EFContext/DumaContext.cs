using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using DumaProject.Core.Entities;
using DumaProject.EFData.EFContext.Mappings;

namespace DumaProject.EFData.EFContext
{
    public class DumaContext : DbContext
    {
        public DbSet<Member> Members { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<Commission> Commissions { get; set; }
        public DbSet<JournalRecord> JournalRecords { get; set; }
        public DbSet<ProfileCommission> ProfileCommissions { get; set; }
        public DbSet<ProfileMember> ProfileMembers { get; set; }
        public DbSet<RoleCommission> RoleCommissions { get; set; }
        public DbSet<RoleMember> RoleMembers { get; set; }

        public DumaContext(string connectionString)
            : base(connectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MemberMap());
            modelBuilder.Configurations.Add(new CommissionMap());
            modelBuilder.Configurations.Add(new JournalRecordMap());
            modelBuilder.Configurations.Add(new MeetingMap());
            modelBuilder.Configurations.Add(new RoleMemberMap());
            modelBuilder.Configurations.Add(new ProfileCommissionMap());
            modelBuilder.Configurations.Add(new ProfileMemberMap());
            modelBuilder.Configurations.Add(new RoleCommissionMap());

            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
