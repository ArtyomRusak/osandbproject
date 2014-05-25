using System;
using System.Collections.Generic;
using System.Linq;
using DumaProject.BLInterfaces.BLLInterfaces;
using DumaProject.BLInterfaces.Exceptions;
using DumaProject.Core.Entities;
using DumaProject.Core.Exceptions;
using DumaProject.DALInterfaces;
using DumaProject.Infrastructure.Guard;

namespace DumaProject.Services
{
    public class CommissionService : BaseService, ICommissionService
    {
        public CommissionService(IUnitOfWork unitOfWork, IRepositoryFactory repositoryFactory)
            : base(unitOfWork, repositoryFactory)
        {
        }

        public Commission CreateCommission(string name)
        {
            var commissionRepository = RepositoryFactory.GetCommissionRepository();

            var commission = new Commission {Name = name};
            commissionRepository.Create(commission);

            try
            {
                UnitOfWork.PreSave();
            }
            catch (RepositoryException ex)
            {
                throw new CommissionServiceException(ex);
            }

            return commission;
        }

        public Commission CreateCommission(string name, int profileId, int presidentId)
        {
            var commissionRepository = RepositoryFactory.GetCommissionRepository();

            var commission = new Commission { Name = name };
            commissionRepository.Create(commission);

            commission.PresidentId = presidentId;
            commission.ProfileCommissionId = profileId;

            try
            {
                UnitOfWork.PreSave();
            }
            catch (RepositoryException ex)
            {
                throw new CommissionServiceException(ex);
            }

            return commission;
        }

        public void UpdateCommission(Commission commission)
        {
            var commissionRepository = RepositoryFactory.GetCommissionRepository();

            try
            {
                commissionRepository.Update(commission);
            }
            catch (Exception ex)
            {
                throw new CommissionServiceException(ex);
            }
        }

        public void RemoveCommission(Commission commission)
        {
            var commissionRepository = RepositoryFactory.GetCommissionRepository();

            try
            {
                commissionRepository.Remove(commission);
            }
            catch (RepositoryException ex)
            {
                throw new CommissionServiceException(ex);
            }
        }

        public Commission GetCommissionById(int commissionId)
        {
            var commissionRepository = RepositoryFactory.GetCommissionRepository();

            try
            {
                var commission = commissionRepository.GetEntityById(commissionId);
                return commission;
            }
            catch (Exception ex)
            {
                throw new CommissionServiceException(ex);
            }
        }

        public Member SetPresident(int commissionId, Member member)
        {
            Guard.AgainstNullReference(member, "member");

            var commission = GetCommissionById(commissionId);
            commission.PresidentId = member.Id;

            return member;
        }

        public void AddMemberToCommission(int commissionId, Member member)
        {
            Guard.AgainstNullReference(member, "member");

            var commission = GetCommissionById(commissionId);
            commission.Consist.Add(member);
        }

        public void ExcludeMemberFromCommission(int commissionId, Member member)
        {
            var commission = GetCommissionById(commissionId);
            commission.Consist.Remove(member);
        }

        public List<Member> GetMembersOfCommission(int commissionId)
        {
            var commission = GetCommissionById(commissionId);
            return commission.Consist;
        }

        public List<Commission> GetAllCommissions()
        {
            var commissionRepository = RepositoryFactory.GetCommissionRepository();

            try
            {
                var commissions = commissionRepository.All().ToList();
                return commissions;
            }
            catch (Exception ex)
            {
                throw new CommissionServiceException(ex);
            }
        }
    }
}
