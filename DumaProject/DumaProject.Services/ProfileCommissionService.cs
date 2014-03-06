using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DumaProject.BLInterfaces.BLLInterfaces;
using DumaProject.BLInterfaces.Exceptions;
using DumaProject.Core.Entities;
using DumaProject.Core.Exceptions;
using DumaProject.DALInterfaces;

namespace DumaProject.Services
{
    public class ProfileCommissionService : BaseService, IProfileCommissionService
    {
        public ProfileCommissionService(IUnitOfWork unitOfWork, IRepositoryFactory repositoryFactory)
            : base(unitOfWork, repositoryFactory)
        {
        }

        public ProfileCommission CreateProfile(string description, int commissionId)
        {
            var profileCommissionRepository = RepositoryFactory.GetProfileCommissionRepository();

            var profile = new ProfileCommission { Description = description, CommissionId = commissionId };
            profileCommissionRepository.Create(profile);

            try
            {
                UnitOfWork.PreSave();
            }
            catch (Exception ex)
            {
                throw new ProfileCommissionServiceException(ex);
            }

            return profile;
        }

        public void UpdateProfile(ProfileCommission profile)
        {
            var profileCommissionRepository = RepositoryFactory.GetProfileCommissionRepository();

            try
            {
                profileCommissionRepository.Update(profile);
            }
            catch (RepositoryException ex)
            {
                throw new ProfileCommissionServiceException(ex);
            }
        }

        public void RemoveProfile(ProfileCommission profile)
        {
            var profileCommissionRepository = RepositoryFactory.GetProfileCommissionRepository();

            try
            {
                profileCommissionRepository.Remove(profile);
            }
            catch (RepositoryException ex)
            {
                throw new ProfileCommissionServiceException(ex);
            }
        }

        public ProfileCommission GetProfileById(int commissionId)
        {
            var profileCommissionRepository = RepositoryFactory.GetProfileCommissionRepository();

            try
            {
                var profile = profileCommissionRepository.Find(e => e.CommissionId == commissionId);
                return profile;
            }
            catch (RepositoryException ex)
            {
                throw new ProfileCommissionServiceException(ex);
            }
        }
    }
}
