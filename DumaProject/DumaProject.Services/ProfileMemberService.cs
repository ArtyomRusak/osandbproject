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
    public class ProfileMemberService : BaseService, IProfileMemberInterface
    {
        public ProfileMemberService(IUnitOfWork unitOfWork, IRepositoryFactory repositoryFactory)
            : base(unitOfWork, repositoryFactory)
        {
        }

        public ProfileMember CreateProfile(string address, string mobileTelephone1, string mobileTelephone2, string homeNumber,
            int memberId)
        {
            var memberRepository = RepositoryFactory.GetMemberRepository();
            var profileMemberRepository = RepositoryFactory.GetProfileMemberRepository();

            var member = memberRepository.GetEntityById(memberId);
            if (member == null)
            {
                return null;
            }

            var profile = new ProfileMember
            {
                Address = address,
                HomeNumber = homeNumber,
                MobileTelephone1 = mobileTelephone1,
                MobileTelephone2 = mobileTelephone2,
                MemberId = member.Id
            };
            profileMemberRepository.Create(profile);

            try
            {
                UnitOfWork.PreSave();
            }
            catch (Exception ex)
            {
                throw new ProfileMemberServiceException(ex);
            }

            return profile;
        }

        public void UpdateProfile(ProfileMember profile)
        {
            var profileMemberRepository = RepositoryFactory.GetProfileMemberRepository();

            try
            {
                profileMemberRepository.Update(profile);
            }
            catch (RepositoryException ex)
            {
                throw new ProfileMemberServiceException(ex);
            }
        }

        public void RemoveProfile(ProfileMember profile)
        {
            var profileMemberRepository = RepositoryFactory.GetProfileMemberRepository();

            try
            {
                profileMemberRepository.Remove(profile);
            }
            catch (RepositoryException ex)
            {
                throw new ProfileMemberServiceException(ex);
            }
        }

        public ProfileMember GetProfileByMemberId(int memberId)
        {
            var profileMemberRepository = RepositoryFactory.GetProfileMemberRepository();

            try
            {
                return profileMemberRepository.Find(e => e.MemberId == memberId);
            }
            catch (RepositoryException ex)
            {
                throw new ProfileMemberServiceException(ex);
            }
        }
    }
}
