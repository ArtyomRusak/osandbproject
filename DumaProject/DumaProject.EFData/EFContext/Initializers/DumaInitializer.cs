using System;
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

            var role1 = new RoleMember {Value = "Инженер"};
            var role2 = new RoleMember {Value = "Депутат"};
            var role3 = new RoleMember {Value = "Уборщик"};
            var role4 = new RoleMember {Value = "Менеджер"};
            var role5 = new RoleMember {Value = "Охранник"};
            var role6 = new RoleMember {Value = "Бухгалтер"};
            var role7 = new RoleMember {Value = "Администратор"};

            context.RoleMembers.Add(role1);
            context.RoleMembers.Add(role2);
            context.RoleMembers.Add(role3);
            context.RoleMembers.Add(role4);
            context.RoleMembers.Add(role5);
            context.RoleMembers.Add(role6);
            context.RoleMembers.Add(role7);

            context.SaveChanges();

            var profile1 = new ProfileCommission {Description = "По аграрным вопросам"};
            var profile2 = new ProfileCommission {Description = "По обороне"};
            var profile3 = new ProfileCommission {Description = "По физической культуре, спорту и делам молодежи"};
            var profile4 = new ProfileCommission {Description = "По науке и наукоемким технологиям"};
            var profile5 = new ProfileCommission {Description = "По образованию"};
            var profile6 = new ProfileCommission {Description = "По транспорту"};
            var profile7 = new ProfileCommission {Description = "По охране здоровья"};
            var profile8 = new ProfileCommission {Description = "По промышленности"};
            var profile9 = new ProfileCommission {Description = "По жилищной политике и жилищно-коммунальному хозяйству"};
            var profile10 = new ProfileCommission {Description = "По культуре"};
            var profile11 = new ProfileCommission {Description = "По энергетике"};
            var profile12 = new ProfileCommission {Description = "По безопасности и противодействию коррупции"};
            var profile13 = new ProfileCommission {Description = "По делам национальностей"};
            var profile14 = new ProfileCommission {Description = "По вопросам семьи, женщин и детей"};
            var profile15 = new ProfileCommission {Description = "По земельным отношениям и строительству"};
            var profile16 = new ProfileCommission {Description = "По природным ресурсам, природопользованию и экологии"};

            context.ProfileCommissions.Add(profile1);
            context.ProfileCommissions.Add(profile2);
            context.ProfileCommissions.Add(profile3);
            context.ProfileCommissions.Add(profile4);
            context.ProfileCommissions.Add(profile5);
            context.ProfileCommissions.Add(profile6);
            context.ProfileCommissions.Add(profile7);
            context.ProfileCommissions.Add(profile8);
            context.ProfileCommissions.Add(profile9);
            context.ProfileCommissions.Add(profile10);
            context.ProfileCommissions.Add(profile11);
            context.ProfileCommissions.Add(profile12);
            context.ProfileCommissions.Add(profile13);
            context.ProfileCommissions.Add(profile14);
            context.ProfileCommissions.Add(profile15);
            context.ProfileCommissions.Add(profile16);

            context.SaveChanges();
        }
    }
}
