using System;
using System.Collections.Generic;
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

        public Member CreateMember(string name, string surname, string patronymic, string passportData)
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

            var role = roleRepository.Find(e => e.Value == "Employee");
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

        public HashSet<Commission> GetCommissionsOfMember(int memberId)
        {
            var member = GetMemberById(memberId);
            return member.Commissions;
        }
    }
}
