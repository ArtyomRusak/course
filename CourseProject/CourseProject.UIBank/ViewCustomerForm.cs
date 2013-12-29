using System;
using System.Windows.Forms;
using CourseProject.Core.Entities;
using CourseProject.EFData;
using CourseProject.EFData.DBContext;
using CourseProject.Services.Exceptions;
using CourseProject.Services.Services;

namespace CourseProject.UIBank
{
    public partial class ViewCustomerForm : Form
    {
        private Customer _customer;
        private readonly int _customerId;
        private readonly BankContext _context;

        public ViewCustomerForm(int customerId)
        {
            InitializeComponent();
            _customerId = customerId;
            _context = new BankContext(Resources.ConnectionString);
        }

        private void ViewCustomerForm_Load(object sender, EventArgs e)
        {
            var unitOfWork = new UnitOfWork(_context);
            var accountService = new AccountService(unitOfWork, unitOfWork);
            var loanService = new LoanService(unitOfWork, unitOfWork);
            var depositService = new DepositService(unitOfWork, unitOfWork);
            var membershipService = new MembershipService(unitOfWork, unitOfWork);

            _customer = membershipService.GetCustomerById(_customerId);

            _lblFIO.Text = String.Format("NSP:{0}{1} {2} {3}", Environment.NewLine, _customer.Surname, _customer.Name, _customer.Patronymic);
            _lblAddress.Text = String.Format("Address:{0}{1}", Environment.NewLine, _customer.Address);
            _lblBirthDate.Text = String.Format("BirthDate:{0}{1}", Environment.NewLine, _customer.BirthDate.ToShortDateString());
            _lblPassportData.Text = String.Format("PassportData:{0}{1}", Environment.NewLine, _customer.PassportData);

            var accounts = accountService.GetAccountsByCustomerId(_customer.Id);
            var loans = loanService.GetLoansByCustomerId(_customer.Id);
            var deposits = depositService.GetDepositsByCustomerId(_customer.Id);

            _dgvAccounts.DataSource = accounts;
            _dgvDeposits.DataSource = deposits;
            _dgvLoans.DataSource = loans;

            unitOfWork.Commit();
        }

        private void _btnAddAccount_Click(object sender, EventArgs e)
        {
            var form = new AddAccountForm(_customer.PassportData);
            form.ShowDialog();
            ViewCustomerForm_Load(null, null);
        }

        private void _btnAddLoan_Click(object sender, EventArgs e)
        {
            var form = new AddLoanForm(_customer.PassportData);
            form.ShowDialog();
            ViewCustomerForm_Load(null, null);
        }

        private void _btnAddDeposit_Click(object sender, EventArgs e)
        {
            var form = new AddDepositForm(_customer.PassportData);
            form.ShowDialog();
            ViewCustomerForm_Load(null, null);
        }

        private void _dgvAccounts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var accountId = int.Parse(_dgvAccounts[0, e.RowIndex].Value.ToString());
            var form = new EditAccountForm(accountId);
            form.ShowDialog();
            ViewCustomerForm_Load(null, null);
        }

        private void ViewCustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.Dispose();
        }

        private void _dgvLoans_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var loanId = int.Parse(_dgvLoans[0, e.RowIndex].Value.ToString());
            var form = new ViewLoanForm(loanId);
            form.ShowDialog();
            ViewCustomerForm_Load(null, null);
        }

        private void _dgvDeposits_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var depositId = int.Parse(_dgvDeposits[0, e.RowIndex].Value.ToString());
            var form = new ViewDepositForm(depositId);
            form.ShowDialog();
            ViewCustomerForm_Load(null, null);
        }

        private void _btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            var unitOfWork = new UnitOfWork(_context);
            var membershipService = new MembershipService(unitOfWork, unitOfWork);
            var customer = membershipService.GetCustomerById(_customer.Id);
            try
            {
                membershipService.RemoveCustomer(customer);
                unitOfWork.Commit();
                MessageBox.Show("Customer deleted!");
                Close();
            }
            catch (MembershipServiceException membershipServiceException)
            {
                MessageBox.Show(membershipServiceException.Message);
                unitOfWork.Rollback();
                return;
            }
        }
    }
}
