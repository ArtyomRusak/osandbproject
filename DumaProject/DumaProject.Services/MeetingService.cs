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
    public class MeetingService : BaseService, IMeetingService
    {
        public MeetingService(IUnitOfWork unitOfWork, IRepositoryFactory repositoryFactory)
            : base(unitOfWork, repositoryFactory)
        {
        }

        public Meeting SetMeetingForCommission(DateTime date, string venue, int durationInMinutes, Commission commission)
        {
            var meetingRepository = RepositoryFactory.GetMeetingRepository();

            var meeting = new Meeting { Date = date, DurationInMinutes = durationInMinutes, CommissionId = commission.Id };
            meetingRepository.Create(meeting);

            try
            {
                UnitOfWork.PreSave();
            }
            catch (Exception ex)
            {
                throw new MeetingServiceException(ex);
            }

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

            return meeting;
        }

        public Meeting GetMeetingById(int meetingId)
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

        public void AddParticipantsForMeeting(int meetingId, ICollection<Member> participants)
        {
            var meeting = GetMeetingById(meetingId);
            foreach (var participant in participants)
            {
                //Artyom Rusak zlychka
                meeting.Participants.Add(participant);
            }
        }

        public void ExcludeParticipants(int meetingId, ICollection<Member> participants)
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
    }
}
