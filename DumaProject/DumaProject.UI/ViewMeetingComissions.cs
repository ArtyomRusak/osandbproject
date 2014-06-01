using System;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using DumaProject.Core.Entities;
using DumaProject.EFData;
using DumaProject.EFData.EFContext;
using DumaProject.Services;

namespace DumaProject.UI
{
    public partial class ViewMeetingComissions : Form
    {
        private readonly int _commissionId;
        private Commission _commission;
        private readonly DumaContext _context = new DumaContext(Resources.ConnectionString);

        public string Profile
        {
            get { return lblProfile.Text; }
            set { lblProfile.Text = value; }
        }

        public string Commission
        {
            get { return lblCommission.Text; }
            set { lblCommission.Text = value; }
        }

        public ViewMeetingComissions(int commissionId)
        {
            InitializeComponent();
            _commissionId = commissionId;
        }

        private void ViewMeetingComissions_Load(object sender, System.EventArgs e)
        {
            var unitOfWork = new UnitOfWork(_context);
            var commissionService = new CommissionService(unitOfWork, unitOfWork);
            var meetingService = new MeetingService(unitOfWork, unitOfWork);

            _commission = commissionService.GetCommissionById(_commissionId);

            Commission = String.Format("Commission name: {0}", _commission.Name);
            Profile = String.Format("Commisiion profile name - {0}", _commission.Profile.Description);

            var meetings = meetingService.GetMeetingsForCommission(_commission);
            dgvMeetings.DataSource = meetings;

            unitOfWork.Commit();
        }

        private void ViewMeetingComissions_FormClosed(object sender, FormClosedEventArgs e)
        {
            _context.Dispose();
        }
    }
}
