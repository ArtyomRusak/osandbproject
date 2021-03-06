﻿using System;
using System.Windows.Forms;
using DumaProject.Core.Entities;
using DumaProject.EFData;
using DumaProject.EFData.EFContext;
using DumaProject.Services;
using duma_project;

namespace DumaProject.UI
{
    public partial class ViewCommission : Form
    {
        private readonly int _commissionId;
        private readonly DumaContext _context = new DumaContext(Resources.ConnectionString);
        private Commission _commission;

        public ViewCommission(int commissionId)
        {
            InitializeComponent();
            _commissionId = commissionId;
        }

        private void ViewComission_Load(object sender, EventArgs e)
        {
            var unitOfWork = new UnitOfWork(_context);
            var commissionService = new CommissionService(unitOfWork, unitOfWork);

            _commission = commissionService.GetCommissionById(_commissionId);
            tbxName.Text = _commission.Name;
            tbxProfile.Text = _commission.Profile.Description;
            tbxPresident.Text = _commission.President.NSP;

            unitOfWork.Commit();
        }

        private void ViewComission_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.Dispose();
        }

        private void btnAddMeeting_Click(object sender, EventArgs e)
        {
            var form = new AddChangeMeeting(_commissionId);
            form.ShowDialog();
        }

        private void btnMeetings_Click(object sender, EventArgs e)
        {
            var form = new ViewMeetingComissions(_commissionId);
            form.ShowDialog();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            var form = new ViewComissionMembers(_commissionId);
            form.ShowDialog();
        }
    }
}
