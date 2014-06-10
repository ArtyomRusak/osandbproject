using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DumaProject.Core.Entities;
using DumaProject.EFData;
using DumaProject.EFData.EFContext;
using DumaProject.Services;

namespace DumaProject.UI
{
    public partial class AddChangeComission : Form
    {
        private int _commissionId;
        private Commission _commission;
        private readonly DumaContext _context = new DumaContext(Resources.ConnectionString);
        public string CommissionName
        {
            get { return tbxName.Text; }
            set { tbxName.Text = value; }
        }

        public int ProfileId { get { return Convert.ToInt32(cmbxProfile.SelectedValue.ToString()); } }
        public int PresidentId { get { return Convert.ToInt32(cmbxPresident.SelectedValue.ToString()); } }

        public AddChangeComission()
        {
            InitializeComponent();
        }

        public AddChangeComission(int commissionId)
        {
            InitializeComponent();
            _commissionId = commissionId;
        }

        private void AddChangeComission_Load(object sender, EventArgs e)
        {
            var unitOfWork = new UnitOfWork(_context);
            var commissionService = new CommissionService(unitOfWork, unitOfWork);
            var profileCommissionService = new ProfileCommissionService(unitOfWork, unitOfWork);
            var membershipService = new MembershipService(unitOfWork, unitOfWork);

            var membersForPresident = membershipService.GetMembersForPresident();
            var profiles = profileCommissionService.GetAllProfiles();

            if (_commissionId != 0)
            {
                _commission = commissionService.GetCommissionById(_commissionId);
                CommissionName = _commission.Name;

                cmbxProfile.DataSource = profiles;
                if (_commission.Profile == null)
                {
                    cmbxProfile.SelectedItem = 0;
                }
                cmbxProfile.Text = _commission.Profile.Description;

                cmbxPresident.DataSource = membersForPresident;
                cmbxPresident.Text = _commission.President.NSP;

                var membersForList = GetMembersNonCommission(unitOfWork);
                var commissionMembers = commissionService.GetMembersOfCommission(_commission.Id);

                lbxMembers.DataSource = membersForList;
                lbxCommissionMembers.DataSource = commissionMembers;

                unitOfWork.Commit();
            }
            else
            {
                CommissionName = String.Empty;
                cmbxProfile.DataSource = profiles;
                cmbxPresident.DataSource = membersForPresident;
                unitOfWork.Commit();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var unitOfWork = new UnitOfWork(_context);
            var commissionService = new CommissionService(unitOfWork, unitOfWork);

            if (CommissionName == "")
            {
                MessageBox.Show("Enter name!");
                return;
            }

            try
            {
                if (_commission == null)
                {
                    _commission = commissionService.CreateCommission(CommissionName, ProfileId, PresidentId);
                    _commissionId = _commission.Id;
                    unitOfWork.Commit();
                    MessageBox.Show("Successfully added commission!");
                    Close();
                }
                else
                {
                    _commission.Name = CommissionName;
                    var selectedPresident = (Member) cmbxPresident.SelectedItem;
                    commissionService.SetPresident(_commission.Id, selectedPresident);
                    commissionService.UpdateCommission(_commission);
                    unitOfWork.Commit();
                    MessageBox.Show("Successfully update commission!");
                    Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something was wrong!");
                unitOfWork.Rollback();
            }
        }

        private void AddChangeComission_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var members = (List<Member>)lbxMembers.DataSource;
            var commissionMembers = (List<Member>) lbxCommissionMembers.DataSource;
            var member = (Member) lbxMembers.SelectedItem;
            lbxCommissionMembers.DataSource = _commission.Consist;
        }

        private void btnActiveMember_Click(object sender, EventArgs e)
        {
            var unitOfWork = new UnitOfWork(_context);
            var commissionService = new CommissionService(unitOfWork, unitOfWork);

            List<Member> members;

            var selectedMember = (Member) lbxMembers.SelectedItem;

            try
            {
                commissionService.AddMemberToCommission(_commission.Id, selectedMember);
                members = commissionService.GetMembersOfCommission(_commission.Id);
                unitOfWork.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something was wrong!");
                unitOfWork.Rollback();
                return;
            }

            SetDatasourcesToNull();

            lbxMembers.DataSource = GetMembersNonCommission(null);
            lbxCommissionMembers.DataSource = members;
        }

        private void btnInactiveMember_Click(object sender, EventArgs e)
        {
            var unitOfWork = new UnitOfWork(_context);
            var commissionService = new CommissionService(unitOfWork, unitOfWork);

            List<Member> members;

            var selectedMember = (Member) lbxCommissionMembers.SelectedItem;

            try
            {
                commissionService.ExcludeMemberFromCommission(_commission.Id, selectedMember);
                members = commissionService.GetMembersOfCommission(_commission.Id);
                unitOfWork.Commit();
            }
            catch (Exception)
            {
                MessageBox.Show("Something was wrong!");
                unitOfWork.Rollback();
                return;
            }

            SetDatasourcesToNull();

            lbxMembers.DataSource = GetMembersNonCommission(null);
            lbxCommissionMembers.DataSource = members;
        }

        private List<Member> GetMembersNonCommission(UnitOfWork unitOfWork)
        {
            MembershipService membershipService;
            List<Member> members = null;

            if (unitOfWork != null)
            {
                membershipService = new MembershipService(unitOfWork, unitOfWork);
                members = membershipService.GetMembersExceptOfCommission(_commission.Id);
            }
            else
            {
                var localUnitOfWork = new UnitOfWork(_context);
                membershipService = new MembershipService(localUnitOfWork, localUnitOfWork);
                members = membershipService.GetMembersExceptOfCommission(_commission.Id);
                localUnitOfWork.Commit();
            }

            return members;
        }
        
        private void SetDatasourcesToNull()
        {
            lbxMembers.DataSource = null;
            lbxCommissionMembers.DataSource = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
