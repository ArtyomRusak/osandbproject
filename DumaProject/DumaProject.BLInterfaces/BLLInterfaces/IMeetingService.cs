using System;
using System.Collections.Generic;
using DumaProject.Core.Entities;

namespace DumaProject.BLInterfaces.BLLInterfaces
{
    public interface IMeetingService : IService
    {
        Meeting SetMeetingForCommission(DateTime date, string venue, int durationInMinutes, int commissionId);
        Meeting SetMeetingForCommission(Meeting meeting, Commission commission);
        Meeting GetMeetingById(long meetingId);
        void UpdateMeeting(Meeting meeting);
        void AddParticipantsForMeeting(long meetingId, ICollection<Member> participants);
        void ExcludeParticipants(long meetingId, ICollection<Member> participants);
        List<Meeting> GetMeetingsForCommission(Commission commission);
        void CancelMeeting(long meetingId);
        void EndMeeting(long meetingId);
        List<Meeting> GetMeetingsOfMemberParticipate(int memberId);
        List<Meeting> GetAllMeetings();
    }
}
