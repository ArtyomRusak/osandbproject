using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DumaProject.Core.Entities;
using DumaProject.EFData;
using DumaProject.EFData.EFContext;
using DumaProject.Services;

namespace DumaProject.UI
{
    public partial class AddEditEmployee : Form
    {
        private readonly int _memberId;
        private Member _member;
        private ProfileMember _profile;
        private readonly bool _isEditMode;
        private readonly DumaContext _context = new DumaContext(Resources.ConnectionString);

        public AddEditEmployee()
        {
            InitializeComponent();
        }

        public AddEditEmployee(int memberId)
        {
            InitializeComponent();
            _memberId = memberId;
            _isEditMode = true;
        }

        private void CloseForm(object sender, EventArgs e)
        {
            Close();
        }

        private void AddChangeEmployee_Load(object sender, EventArgs e)
        {
            var unitOfWork = new UnitOfWork(_context);
            var membershipService = new MembershipService(unitOfWork, unitOfWork);

            var roles = membershipService.GetAllRoles();

            if (_memberId != 0)
            {
                var profileMemberService = new ProfileMemberService(unitOfWork, unitOfWork);
                _member = membershipService.GetMemberById(_memberId);
                _profile = profileMemberService.GetProfileByMemberId(_member.Id);
                SetValuesForControls(_member, roles, _profile);

                unitOfWork.Commit();
            }
            else
            {
                cmbxRole.DataSource = roles;
                unitOfWork.Commit();
            }
        }

        private void SetValuesForControls(Member member, List<RoleMember> roles, ProfileMember profile)
        {
            tbxName.Text = member.Name;
            tbxSurname.Text = member.Surname;
            tbxPatronymic.Text = member.Patronymic;
            tbxPassport.Text = member.PassportData;
            cmbxRole.DataSource = roles;
            cmbxRole.Text = member.Role.Value;
            if (profile != null)
            {
                tbxAddress.Text = profile.Address;
                tbxHome.Text = profile.HomeNumber;
                tbxMobile.Text = profile.MobileTelephone1;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateMemberFields(tbxName.Text, tbxSurname.Text, tbxPatronymic.Text, tbxPassport.Text))
            {
                MessageBox.Show("Set all fields.");
                return;
            }

            var unitOfWork = new UnitOfWork(_context);
            var membershipService = new MembershipService(unitOfWork, unitOfWork);
            var profileMemberService = new ProfileMemberService(unitOfWork, unitOfWork);

            if (_isEditMode == false)
            {
                try
                {
                    _member = membershipService.CreateMember(tbxName.Text, tbxSurname.Text, tbxPatronymic.Text, tbxPassport.Text, cmbxRole.SelectedItem.ToString());
                    _profile = profileMemberService.CreateProfile(tbxAddress.Text, tbxMobile.Text, tbxHome.Text, _member.Id);
                    unitOfWork.Commit();
                    MessageBox.Show("Successfully added new employee");
                    Close();
                }
                catch (Exception exception)
                {
                    unitOfWork.Rollback();
                }

            }
            else
            {
                try
                {
                    MapToMember();
                    membershipService.UpdateMember(_member);
                    membershipService.ChangeRole(_member.Id, cmbxRole.SelectedItem.ToString());
                    if (_profile == null)
                    {
                        _profile = profileMemberService.CreateProfile(tbxAddress.Text, tbxMobile.Text, tbxHome.Text, _member.Id);
                    }
                    else
                    {
                        profileMemberService.UpdateProfile(_profile);
                    }
                }
                catch (Exception exception)
                {
                    unitOfWork.Rollback();
                }
                unitOfWork.Commit();
                MessageBox.Show("Successfully edit employee");
                Close();
            }
        }

        private void AddChangeEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            _context.Dispose();
        }

        private bool ValidateMemberFields(string name, string surname, string patronymic, string passportData)
        {
            return name == "" && surname == "" && patronymic == "" && passportData == "";
        }

        private void MapToMember()
        {
            _member.Name = tbxName.Text;
            _member.Surname = tbxSurname.Text;
            _member.Patronymic = tbxPatronymic.Text;
            _member.PassportData = tbxPassport.Text;
            if (_profile != null)
            {
                _profile.Address = tbxAddress.Text;
                _profile.MobileTelephone1 = tbxMobile.Text;
                _profile.HomeNumber = tbxHome.Text;
            }
        }
    }
}
