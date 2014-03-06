using System;
using System.Collections.Generic;
using DumaProject.Core.Entities;

namespace DumaProject.BLInterfaces.BLLInterfaces
{
    public interface IMeetingService : IService
    {
        Meeting SetMeetingForCommission(DateTime date, string venue, int durationInMinutes, Commission commission);
        Meeting SetMeetingForCommission(Meeting meeting, Commission commission);
        Meeting GetMeetingById(long meetingId);
        void AddParticipantsForMeeting(long meetingId, ICollection<Member> participants);
        void ExcludeParticipants(long meetingId, ICollection<Member> participants);
        HashSet<Meeting> GetMeetingsForCommission(Commission commission);
        void CancelMeeting(long meetingId);
        void EndMeeting(long meetingId);
    }
}
