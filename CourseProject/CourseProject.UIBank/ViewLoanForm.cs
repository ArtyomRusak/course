using System;
using System.Windows.Forms;
using CourseProject.Core.Entities;
using CourseProject.EFData;
using CourseProject.EFData.DBContext;
using CourseProject.Services.Services;

namespace CourseProject.UIBank
{
    public partial class ViewLoanForm : Form
    {
        private readonly int _loanId;
        private Loan _loan;
        private readonly BankContext _context;

        public ViewLoanForm(int loanId)
        {
            InitializeComponent();
            _loanId = loanId;
            _context = new BankContext(Resources.ConnectionString);
        }

        private void ViewLoanForm_Load(object sender, EventArgs e)
        {
            var unitOfWork = new UnitOfWork(_context);
            var loanService = new LoanService(unitOfWork, unitOfWork);
            _loan = loanService.GetLoanById(_loanId);
            _lblLoanId.Text = String.Format("Customer - {0}. ID of this account - {1}",
                String.Format("{0} {1} {2}", _loan.Customer.Surname, _loan.Customer.Name,
                    _loan.Customer.Patronymic), _loan.Id);
            _tbxSummary.Text = _loan.Summary.ToString();

            unitOfWork.Commit();
        }

        private void _btnCalculate_Click(object sender, EventArgs e)
        {
            var date = _dtmpDate.Value;
            if (date < DateTime.Now)
            {
                MessageBox.Show("Wrong date!");
                return;
            }

            var percent = _loan.Calculate(date);
            _tbxPercent.Text = percent.ToString();
        }

        private void ViewLoanForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.Dispose();
        }
    }
}
