using System.Diagnostics;
using System.Windows.Forms;
using DumaProject.Core.Entities;
using DumaProject.EFData;
using DumaProject.EFData.EFContext;
using DumaProject.Services;

namespace DumaProject.UI
{
    public partial class ViewMeeting : Form
    {
        private readonly long _meetingId;
        private readonly DumaContext _context = new DumaContext(Resources.ConnectionString);
        private Meeting _meeting;

        public ViewMeeting(long meetingId)
        {
            InitializeComponent();
            _meetingId = meetingId;
        }

        private void ViewMeeting_Load(object sender, System.EventArgs e)
        {
            var unitOfWork = new UnitOfWork(_context);
            var meetingService = new MeetingService(unitOfWork, unitOfWork);

            _meeting = meetingService.GetMeetingById(_meetingId);

            dgvMembers.DataSource = _meeting.Participants;

            dtpDate.Value = _meeting.Date;
            dtpStart.Value = _meeting.Date;
            dtpEnd.Value = _meeting.Date.AddMinutes(_meeting.DurationInMinutes);
            tbxPlace.Text = _meeting.Venue;

            cmbxType.SelectedIndex = 0;
        }

        private void ViewMeeting_FormClosed(object sender, FormClosedEventArgs e)
        {
            _context.Dispose();
        }

        private void btnReport_Click(object sender, System.EventArgs e)
        {
            var reportService = new ReportService();

            var type = (string) cmbxType.SelectedItem;

            reportService.GenerateReportForMeeting(_meeting, _meeting.Commission, type);
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
