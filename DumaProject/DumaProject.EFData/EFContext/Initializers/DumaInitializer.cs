using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Transactions;
using DumaProject.Core.Entities;

namespace DumaProject.EFData.EFContext.Initializers
{
    public class DumaInitializer : IDatabaseInitializer<DumaContext>
    {
        public void InitializeDatabase(DumaContext context)
        {
            bool databaseExists;
            using (new TransactionScope(TransactionScopeOption.Suppress))
            {
                databaseExists = context.Database.Exists();
            }
            if (databaseExists)
            {
                if (context.Database.CompatibleWithModel(true))
                {
                    return;
                }
                context.Database.Delete();
            }
            context.Database.Create();
            //context.Database.ExecuteSqlCommand("ALTER TABLE Users ADD CONSTRAINT EmailDataUnique UNIQUE (Email)");
            //context.Database.ExecuteSqlCommand("ALTER TABLE Users ADD CONSTRAINT NameDataUnique UNIQUE (UserName)");
            //context.Database.ExecuteSqlCommand("ALTER TABLE Roles ADD CONSTRAINT RoleNameDataUnique UNIQUE (Name)");
            try
            {
                context.SaveChanges();
                Seed(context);
            }
            catch (Exception ex)
            {
                context.Dispose();
                throw;
            }
        }

        public void Seed(DumaContext context)
        {
            //TODO: First variables.

            //var member = new Member
            //{
            //    Name = "Lesha",
            //    Surname = "Yurchak",
            //    Patronymic = "Vladimirovich",
            //    PassportData = "MP"
            //};

            //context.Members.Add(member);
            //context.SaveChanges();

            //var commission = new Commission {Name = "Hello", President = member};
            //context.Commissions.Add(commission);

            //var roleCom = new RoleCommission {Value = "Commandor"};
            //context.RoleCommissions.Add(roleCom);

            //context.SaveChanges();
            //commission.Consist.Add(member);


            //var record = new JournalRecord
            //{
            //    EntryDate = DateTime.Now,
            //    ExitDate = DateTime.Now.AddDays(3),
            //    Member = member,
            //    Commission = commission,
            //    Role = roleCom
            //};

            //commission.JournalRecords.Add(record);

            //context.SaveChanges();

            var role1 = new RoleMember { Value = "Инженер" };
            var role2 = new RoleMember { Value = "Депутат" };
            var role3 = new RoleMember { Value = "Уборщик" };
            var role4 = new RoleMember { Value = "Менеджер" };
            var role5 = new RoleMember { Value = "Охранник" };
            var role6 = new RoleMember { Value = "Бухгалтер" };
            var role7 = new RoleMember { Value = "Администратор" };

            context.RoleMembers.Add(role1);
            context.RoleMembers.Add(role2);
            context.RoleMembers.Add(role3);
            context.RoleMembers.Add(role4);
            context.RoleMembers.Add(role5);
            context.RoleMembers.Add(role6);
            context.RoleMembers.Add(role7);

            context.SaveChanges();

            var profiles = new List<ProfileCommission>()
            {
                new ProfileCommission {Description = "По аграрным вопросам"},
                new ProfileCommission {Description = "По обороне"},
                new ProfileCommission {Description = "По физической культуре, спорту и делам молодежи"},
                new ProfileCommission {Description = "По науке и наукоемким технологиям"},
                new ProfileCommission {Description = "По образованию"},
                new ProfileCommission {Description = "По транспорту"},
                new ProfileCommission {Description = "По охране здоровья"},
                new ProfileCommission {Description = "По промышленности"},
                new ProfileCommission {Description = "По жилищной политике и жилищно-коммунальному хозяйству"},
                new ProfileCommission {Description = "По культуре"},
                new ProfileCommission {Description = "По энергетике"},
                new ProfileCommission {Description = "По безопасности и противодействию коррупции"},
                new ProfileCommission {Description = "По делам национальностей"},
                new ProfileCommission {Description = "По вопросам семьи, женщин и детей"},
                new ProfileCommission {Description = "По земельным отношениям и строительству"},
                new ProfileCommission {Description = "По природным ресурсам, природопользованию и экологии"},
            };

            profiles.ForEach(e => context.ProfileCommissions.Add(e));

            var presidentRole = new RoleCommission { Value = "Президент" };
            var memberRole = new RoleCommission { Value = "Член" };

            context.RoleCommissions.Add(presidentRole);
            context.RoleCommissions.Add(memberRole);

            context.SaveChanges();
        }
    }
}
