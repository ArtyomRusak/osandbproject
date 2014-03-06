using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DumaProject.Core.Entities;

namespace DumaProject.BLInterfaces.BLLInterfaces
{
    public interface IMeetingService : IService
    {
        Meeting SetMeetingForCommission(DateTime date, string venue, int durationInMinutes, Commission commission);
        Meeting SetMeetingForCommission(Meeting meeting, Commission commission);
        Meeting GetMeetingById(int meetingId);
        void AddParticipantsForMeeting(int meetingId, ICollection<Member> participants);
        void ExcludeParticipants(int meetingId, ICollection<Member> participants);
        HashSet<Meeting> GetMeetingsForCommission(Commission commission);
        void CancelMeeting(int meetingId);
        void EndMeeting(int meetingId);
    }
}
