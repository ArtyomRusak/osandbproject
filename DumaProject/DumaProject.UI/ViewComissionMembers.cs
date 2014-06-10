using DumaProject.Core.Entities;
using DumaProject.EFData;
using DumaProject.EFData.EFContext;
using DumaProject.Services;
using DumaProject.UI;
using System.Windows.Forms;

namespace duma_project
{
    public partial class ViewComissionMembers : Form
    {
        private readonly int _comissionId;
        private readonly DumaContext _context = new DumaContext(Resources.ConnectionString);

        public ViewComissionMembers()
        {
            InitializeComponent();
        }

        public ViewComissionMembers(int comissionId)
        {
            InitializeComponent();
            _comissionId = comissionId;
        }

        private void ViewComissionMembers_Load(object sender, System.EventArgs e)
        {
            var unitOfWork = new UnitOfWork(_context);
            var commissionService = new CommissionService(unitOfWork, unitOfWork);
            var members = commissionService.GetMembersOfCommission(_comissionId);
            dgvComissionMembers.DataSource = members;
            unitOfWork.Commit();
        }

        private void ViewComissionMembers_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.Dispose();
        }
    }
}
