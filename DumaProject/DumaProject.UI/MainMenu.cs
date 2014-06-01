using System;
using System.Windows.Forms;
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
            dgvMembers.Visible = false;
            dgvCommissions.Visible = false;
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

            dgvMembers.Visible = true;
            dgvCommissions.Visible = false;

            unitOfWork.Commit();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            var form = new AddEditEmployee();
            form.ShowDialog();
            UpdateGrids();
        }

        private void ChooseMember(object sender, DataGridViewCellEventArgs e)
        {
            var memberId = Convert.ToInt32(dgvMembers.Rows[e.RowIndex].Cells[0].Value);
            var form = new AddEditEmployee(memberId);
            form.ShowDialog();
            UpdateGrids();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            _context.Dispose();
        }

        private void btnAddComission_Click(object sender, EventArgs e)
        {
            var form = new AddChangeComission();
            form.ShowDialog();
            UpdateGrids();
        }

        private void btnViewCommissions_ButtonClick(object sender, EventArgs e)
        {
            if (_context != null)
            {
                _context = new DumaContext(Resources.ConnectionString);
            }

            var unitOfWork = new UnitOfWork(_context);
            var commissionService = new CommissionService(unitOfWork, unitOfWork);

            var commissions = commissionService.GetAllCommissions();

            dgvCommissions.DataSource = commissions;

            dgvMembers.Visible = false;
            dgvCommissions.Visible = true;

            unitOfWork.Commit();
        }

        private void dgvCommissions_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var commissionId = Convert.ToInt32(dgvCommissions.Rows[e.RowIndex].Cells[0].Value);
            //var form = new AddChangeComission(commissionId);
            var form = new ViewCommission(commissionId);
            form.ShowDialog();
        }

        private void editComissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvCommissions.CurrentRow != null)
            {
                var commissionId = Convert.ToInt32(dgvCommissions.CurrentRow.Cells[0].Value);
                var form = new AddChangeComission(commissionId);
                form.ShowDialog();
                UpdateGrids();
            }
            else
            {
                MessageBox.Show("Выберите коммисию для показа");
            }
        }

        private void UpdateGrids()
        {
            if (_context != null)
            {
                _context = new DumaContext(Resources.ConnectionString);
            }
            var unitOfWork = new UnitOfWork(_context);
            var commissionService = new CommissionService(unitOfWork, unitOfWork);
            var membershipService = new MembershipService(unitOfWork, unitOfWork);

            dgvCommissions.DataSource = null;
            dgvMembers.DataSource = null;

            var members = membershipService.GetAllMembers();
            var commissions = commissionService.GetAllCommissions();

            dgvCommissions.DataSource = commissions;
            dgvMembers.DataSource = members;

            unitOfWork.Commit();
        }

        //TODO: Do method to refresh all dataGridViews.
    }
}
