using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DumaProject.Core.Entities;

namespace DumaProject.BLInterfaces.BLLInterfaces
{
    public interface IProfileMemberInterface : IService
    {
        ProfileMember CreateProfile(string address, string mobileTelephone1, string mobileTelephone2,
            string homeNumber, int memberId);
        void UpdateProfile(ProfileMember profile);
        void RemoveProfile(ProfileMember profile);
        ProfileMember GetProfileByMemberId(int memberId);
    }
}
