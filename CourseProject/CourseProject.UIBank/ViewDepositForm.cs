using System;
using System.Windows.Forms;
using CourseProject.Core.Entities;
using CourseProject.EFData;
using CourseProject.EFData.DBContext;
using CourseProject.Services.Services;

namespace CourseProject.UIBank
{
    public partial class ViewDepositForm : Form
    {
        private readonly int _depositId;
        private Deposit _deposit;
        private readonly BankContext _context;

        public ViewDepositForm(int depositId)
        {
            InitializeComponent();
            _depositId = depositId;
            _context = new BankContext(Resources.ConnectionString);
        }

        private void ViewDepositForm_Load(object sender, EventArgs e)
        {
            var unitOfWork = new UnitOfWork(_context);
            var depositService = new DepositService(unitOfWork, unitOfWork);
            _deposit = depositService.GetDepositById(_depositId);
            _lblDepositId.Text = String.Format("Customer - {0}. ID of this account - {1}",
                String.Format("{0} {1} {2}", _deposit.Customer.Surname, _deposit.Customer.Name,
                    _deposit.Customer.Patronymic), _deposit.Id);
            _tbxSummary.Text = _deposit.Summary.ToString();

            unitOfWork.Commit();
        }

        private void ViewDepositForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.Dispose();
        }

        private void _btnCalculate_Click(object sender, EventArgs e)
        {
            var date = _dtmpDate.Value;
            if (date < DateTime.Now)
            {
                MessageBox.Show("Wrong date!");
                return;
            }

            var percent = _deposit.Calculate(date);
            _tbxPercent.Text = percent.ToString();
        }
    }
}
