using System;
using System.Collections.Generic;
using System.Linq;
using DumaProject.BLInterfaces.BLLInterfaces;
using DumaProject.BLInterfaces.Exceptions;
using DumaProject.Core.Entities;
using DumaProject.Core.Exceptions;
using DumaProject.DALInterfaces;

namespace DumaProject.Services
{
    public class MeetingService : BaseService, IMeetingService
    {
        public MeetingService(IUnitOfWork unitOfWork, IRepositoryFactory repositoryFactory)
            : base(unitOfWork, repositoryFactory)
        {
        }

        public Meeting SetMeetingForCommission(DateTime date, string venue, int durationInMinutes, int commissionId)
        {
            var meetingRepository = RepositoryFactory.GetMeetingRepository();
            var commissionRepository = RepositoryFactory.GetCommissionRepository();

            var meeting = new Meeting { Date = date, Venue = venue, DurationInMinutes = durationInMinutes, CommissionId = commissionId };
            meetingRepository.Create(meeting);

            try
            {
                UnitOfWork.PreSave();
            }
            catch (Exception ex)
            {
                throw new MeetingServiceException(ex);
            }

            var commission = commissionRepository.GetEntityById(commissionId);
            commission.Meetings.Add(meeting);

            return meeting;
        }

        public Meeting SetMeetingForCommission(Meeting meeting, Commission commission)
        {
            var meetingRepository = RepositoryFactory.GetMeetingRepository();
            meetingRepository.Create(meeting);

            try
            {
                UnitOfWork.PreSave();
            }
            catch (Exception ex)
            {
                throw new MeetingServiceException(ex);
            }

            commission.Meetings.Add(meeting);

            return meeting;
        }

        public Meeting GetMeetingById(long meetingId)
        {
            var meetingRepository = RepositoryFactory.GetMeetingRepository();

            try
            {
                return meetingRepository.GetEntityById(meetingId);
            }
            catch (RepositoryException ex)
            {
                throw new MeetingServiceException(ex);
            }
        }

        public void UpdateMeeting(Meeting meeting)
        {
            var meetingRepository = RepositoryFactory.GetMeetingRepository();

            try
            {
                meetingRepository.Update(meeting);
            }
            catch (Exception ex)
            {
                throw new MeetingServiceException(ex);
            }
        }

        public void AddParticipantsForMeeting(long meetingId, ICollection<Member> participants)
        {
            var meeting = GetMeetingById(meetingId);
            foreach (var participant in participants)
            {
                //Artyom Rusak zlychka
                meeting.Participants.Add(participant);
            }
        }

        public void ExcludeParticipants(long meetingId, ICollection<Member> participants)
        {
            var meeting = GetMeetingById(meetingId);
            foreach (var participant in participants)
            {
                meeting.Participants.Remove(participant);
            }
        }

        public HashSet<Meeting> GetMeetingsForCommission(Commission commission)
        {
            var meetingRepository = RepositoryFactory.GetMeetingRepository();

            try
            {
                var meetings = meetingRepository.Filter(e => e.CommissionId == commission.Id).ToList();
                return new HashSet<Meeting>(meetings);
            }
            catch (RepositoryException ex)
            {
                throw new MeetingServiceException(ex);
            }
        }

        public void CancelMeeting(long meetingId)
        {
            var meeting = GetMeetingById(meetingId);
            meeting.IsCancelled = true;
        }

        public void EndMeeting(long meetingId)
        {
            var meeting = GetMeetingById(meetingId);
            meeting.IsEnded = true;
        }
    }
}
