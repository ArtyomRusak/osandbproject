using System.Windows.Forms;
using DumaProject.Core.Entities;
using DumaProject.EFData;
using DumaProject.EFData.EFContext;
using DumaProject.Services;

namespace DumaProject.UI
{
    public partial class ViewEmployee : Form
    {
        private readonly int _memberId;
        private readonly DumaContext _context = new DumaContext(Resources.ConnectionString);
        private Member _member;
        private ProfileMember _profile;

        public ViewEmployee(int memberId)
        {
            InitializeComponent();
            _memberId = memberId;
        }

        #region [Properties]

        public string MemberName
        {
            get { return tbxName.Text; }
            set { tbxName.Text = value; }
        }

        public string Surname
        {
            get { return tbxSurname.Text; }
            set { tbxSurname.Text = value; }
        }

        public string Patronymic
        {
            get { return tbxPatronymic.Text; }
            set { tbxPatronymic.Text = value; }
        }

        public string Passport
        {
            get { return tbxPassport.Text; }
            set { tbxPassport.Text = value; }
        }

        public string Home
        {
            get { return tbxHome.Text; }
            set { tbxHome.Text = value; }
        }

        public string Address
        {
            get { return tbxAddress.Text; }
            set { tbxAddress.Text = value; }
        }

        public string Role
        {
            get { return tbxRole.Text; }
            set { tbxRole.Text = value; }
        }

        public string Mobile
        {
            get { return tbxMobile.Text; }
            set { tbxMobile.Text = value; }
        }

        #endregion

        private void ViewEmployee_Load(object sender, System.EventArgs e)
        {
            var unitOfWork = new UnitOfWork(_context);
            var membershipService = new MembershipService(unitOfWork, unitOfWork);
            var profileMemberService = new ProfileMemberService(unitOfWork, unitOfWork);
            var meetingService = new MeetingService(unitOfWork, unitOfWork);

            _member = membershipService.GetMemberById(_memberId);
            _profile = profileMemberService.GetProfileByMemberId(_member.Id);
            SetDataToControls();

            var commissions = membershipService.GetCommissionsOfMember(_member.Id);
            var meetings = meetingService.GetMeetingsOfMemberParticipate(_member.Id);

            dgvCommissions.DataSource = commissions;
            dgvMeetings.DataSource = meetings;

            unitOfWork.Commit();
        }

        private void SetDataToControls()
        {
            MemberName = _member.Name;
            Surname = _member.Surname;
            Patronymic = _member.Patronymic;
            Passport = _member.PassportData;
            Role = _member.Role.Value;

            Home = _profile.HomeNumber;
            Address = _profile.Address;
            Mobile = _profile.MobileTelephone1;
        }


        private void ViewEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            _context.Dispose();
        }
    }
}
