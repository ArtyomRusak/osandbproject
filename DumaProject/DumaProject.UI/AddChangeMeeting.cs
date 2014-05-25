using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DumaProject.Core.Entities;
using DumaProject.EFData;
using DumaProject.EFData.EFContext;
using DumaProject.Services;

namespace DumaProject.UI
{
    public partial class AddChangeMeeting : Form
    {
        private readonly long _meetingId;
        private readonly int _commissionId;
        private readonly DumaContext _context = new DumaContext(Resources.ConnectionString);
        Meeting _meeting;
        private readonly UnitOfWork _unitOfWork;
        private Commission _commission;

        public string Venue
        {
            get { return tbxVenue.Text; }
            set { tbxVenue.Text = value; }
        }

        public AddChangeMeeting(int commissionId)
        {
            InitializeComponent();
            _commissionId = commissionId;
            _unitOfWork = new UnitOfWork(_context);
        }

        public AddChangeMeeting(long meetingId, int commissionId)
        {
            InitializeComponent();
            _meetingId = meetingId;
            _commissionId = commissionId;
        }

        private void AddChangeMeeting_Load(object sender, EventArgs e)
        {
            var commissionService = new CommissionService(_unitOfWork, _unitOfWork);
            var meetingService = new MeetingService(_unitOfWork, _unitOfWork);

            var members = commissionService.GetMembersOfCommission(_commissionId);
            _commission = commissionService.GetCommissionById(_commissionId);

            lbxMembers.DataSource = members;

            if (_meetingId != 0)
            {
                _meeting = meetingService.GetMeetingById(_meetingId);
                Venue = _meeting.Venue;
                dtpDate.Value = _meeting.Date;
                dtpBeginning.Value = _meeting.Date;
                dtpEnding.Value = _meeting.Date.AddMinutes(_meeting.DurationInMinutes);
                lbxMeetingMembers.DataSource = _meeting.Participants;
                lbxMembers.DataSource = GetMembersExceptMeeting();
            }
            else
            {
                _meeting = meetingService.SetMeetingForCommission(DateTime.Now, "Temporary", 0, _commissionId);
            }
        }

        private void AddChangeMeeting_FormClosing(object sender, FormClosingEventArgs e)
        {
            _unitOfWork.Rollback();
            _context.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var meetingService = new MeetingService(_unitOfWork, _unitOfWork);

            if (Venue == String.Empty)
            {
                MessageBox.Show("Введите место встречи!");
                return;
            }

            var meetingDate = GenerateDate(dtpDate.Value, dtpBeginning.Value);
            var duration = GenerateDuration(dtpBeginning.Value, dtpEnding.Value);
            if (duration < 0)
            {
                MessageBox.Show("Выберите правильное время!");
                return;
            }
            _meeting.Date = meetingDate;
            _meeting.DurationInMinutes = duration;
            _meeting.Venue = Venue;

            meetingService.UpdateMeeting(_meeting);

            try
            {
                _unitOfWork.Commit();
                MessageBox.Show("Успешно добавлена!");
            }
            catch (Exception exception)
            {
                _unitOfWork.Rollback();
                MessageBox.Show("Что-то пошло не так");
            }
        }

        private void btnActiveMember_Click(object sender, EventArgs e)
        {
            var selectedMember = (Member) lbxMembers.SelectedItem;

            SetDatasourcesToNull();

            _meeting.Participants.Add(selectedMember);
            var members = GetMembersExceptMeeting();
            lbxMembers.DataSource = members;
            lbxMeetingMembers.DataSource = _meeting.Participants;
        }

        private void btnInactiveMembers_Click(object sender, EventArgs e)
        {
            var selectedItem = (Member) lbxMeetingMembers.SelectedItem;

            SetDatasourcesToNull();

            _meeting.Participants.Remove(selectedItem);
            var members = GetMembersExceptMeeting();
            lbxMeetingMembers.DataSource = _meeting.Participants;
            lbxMembers.DataSource = members;
        }

        private List<Member> GetMembersExceptMeeting()
        {
            var members = _commission.Consist.Except(_meeting.Participants).ToList();
            return members;
        }

        private void SetDatasourcesToNull()
        {
            lbxMembers.DataSource = null;
            lbxMeetingMembers.DataSource = null;
        }

        private DateTime GenerateDate(DateTime date, DateTime beginningTime)
        {
            var meetingDate = new DateTime(date.Year, date.Month, date.Day, beginningTime.Hour, beginningTime.Minute,
                beginningTime.Second);
            return meetingDate;
        }

        private int GenerateDuration(DateTime beginningTime, DateTime endingTime)
        {
            var span = endingTime - beginningTime;
            var duration = (int)span.TotalMinutes;
            return duration;
        }
    }
}
