using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Windows.Forms;
using DumaProject.Core.Entities;
using DumaProject.EFData;
using DumaProject.EFData.EFContext;
using DumaProject.Services;

namespace DumaProject.UI
{
    public partial class MainMenu : Form
    {
        private DumaContext _context = new DumaContext(Resources.ConnectionString);

        public MainMenu()
        {
            InitializeComponent();
        }

        private void ViewAllEmployees(object sender, EventArgs e)
        {
            if (_context != null)
            {
                _context = new DumaContext(Resources.ConnectionString);
            }
            var unitOfWork = new UnitOfWork(_context);
            var memberService = new MembershipService(unitOfWork, unitOfWork);

            var members = memberService.GetAllMembers();
            dgvMembers.DataSource = members;

            unitOfWork.Commit();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            var form = new AddEditEmployee();
            form.ShowDialog();
        }

        private void ChooseMember(object sender, DataGridViewCellEventArgs e)
        {
            var memberId = Convert.ToInt32(dgvMembers.Rows[e.RowIndex].Cells[0].Value);
            var form = new AddEditEmployee(memberId);
            form.ShowDialog();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            _context.Dispose();
        }
    }
}
