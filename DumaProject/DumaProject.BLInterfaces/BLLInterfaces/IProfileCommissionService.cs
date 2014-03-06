using DumaProject.Core.Entities;

namespace DumaProject.BLInterfaces.BLLInterfaces
{
    public interface IProfileCommissionService : IService
    {
        ProfileCommission CreateProfile(string description, int commissionId);
        void UpdateProfile(ProfileCommission profile);
        void RemoveProfile(ProfileCommission profile);
        ProfileCommission GetProfileById(int commissionId);
    }
}
