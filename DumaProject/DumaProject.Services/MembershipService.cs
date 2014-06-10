using System;
using System.Collections.Generic;
using System.Linq;
using DumaProject.BLInterfaces.BLLInterfaces;
using DumaProject.BLInterfaces.Exceptions;
using DumaProject.Core.Entities;
using DumaProject.DALInterfaces;

namespace DumaProject.Services
{
    public class MembershipService : BaseService, IMembershipService
    {
        public MembershipService(IUnitOfWork unitOfWork, IRepositoryFactory repositoryFactory)
            : base(unitOfWork, repositoryFactory)
        {
        }

        public Member CreateMember(string name, string surname, string patronymic, string passportData, string roleName)
        {
            var roleRepository = RepositoryFactory.GetRoleMemberRepository();
            var memberRepository = RepositoryFactory.GetMemberRepository();

            var member = new Member
            {
                Name = name,
                Surname = surname,
                Patronymic = patronymic,
                PassportData = passportData
            };

            var role = roleRepository.Find(e => e.Value == roleName);
            member.Role = role;

            memberRepository.Create(member);

            try
            {
                UnitOfWork.PreSave();
            }
            catch (Exception e)
            {
                throw new MembershipServiceException(e);
            }

            return member;
        }


        public void UpdateMember(Member member)
        {
            var memberRepository = RepositoryFactory.GetMemberRepository();

            try
            {
                memberRepository.Update(member);
            }
            catch (Exception e)
            {
                throw new MembershipServiceException(e);
            }
        }

        public void RemoveMember(Member member)
        {
            var memberRepository = RepositoryFactory.GetMemberRepository();

            try
            {
                memberRepository.Remove(member);
            }
            catch (Exception e)
            {
                throw new MembershipServiceException(e);
            }
        }

        public Member GetMemberById(int memberId)
        {
            var memberRepository = RepositoryFactory.GetMemberRepository();

            try
            {
                return memberRepository.GetEntityById(memberId);
            }
            catch (Exception e)
            {
                throw new MembershipServiceException(e);
            }
        }

        public void ChangeRole(int memberId, RoleMember role)
        {
            var member = GetMemberById(memberId);
            member.Role = role;
            UpdateMember(member);
        }

        public void ChangeRole(int memberId, string roleName)
        {
            var roleMemberRepository = RepositoryFactory.GetRoleMemberRepository();

            var member = GetMemberById(memberId);
            var role = GetRoleByName(roleName);

            member.Role = role;
            UpdateMember(member);
        }

        public RoleMember GetRoleByName(string roleName)
        {
            var roleMemberRepository = RepositoryFactory.GetRoleMemberRepository();

            try
            {
                var role = roleMemberRepository.Find(e => e.Value == roleName);
                return role;
            }
            catch (Exception e)
            {
                throw new MembershipServiceException(e);
            }
        }

        public List<Commission> GetCommissionsOfMember(int memberId)
        {
            var member = GetMemberById(memberId);
            return member.Commissions;
        }

        public List<Member> GetMembersExceptOfCommission(int commissionId)
        {
            var memberRepository = RepositoryFactory.GetMemberRepository();
            var commissionRepository = RepositoryFactory.GetCommissionRepository();

            var commission = commissionRepository.GetEntityById(commissionId);

            try
            {
                var members =
                    memberRepository.All().ToList().Where(e => e.Commissions.Contains(commission) == false).ToList();
                return members;
            }
            catch (Exception ex)
            {
                throw new MembershipServiceException(ex);
            }
        }

        public List<Member> GetMembersForPresident()
        {
            var memberRepository = RepositoryFactory.GetMemberRepository();
            var roleMemberRepository = RepositoryFactory.GetRoleMemberRepository();

            try
            {
                var role = roleMemberRepository.Find(e => e.Value == "Депутат");
                var members = memberRepository.Filter(e => e.Role.Id == role.Id).ToList();
                return members;
            }
            catch (Exception ex)
            {
                throw new MembershipServiceException(ex);
            }
        }

        public List<Member> GetAllMembers()
        {
            var memberRepository = RepositoryFactory.GetMemberRepository();

            try
            {
                var members = memberRepository.All().ToList();
                return members;
            }
            catch (Exception e)
            {
                throw new MembershipServiceException(e);
            }
        }

        public List<RoleMember> GetAllRoles()
        {
            var roleMemberRepository = RepositoryFactory.GetRoleMemberRepository();

            try
            {
                var roles = roleMemberRepository.All().ToList();
                return roles;
            }
            catch (Exception e)
            {
                throw new MembershipServiceException(e);
            }
        }
    }
}
