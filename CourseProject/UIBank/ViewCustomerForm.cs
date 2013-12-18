using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using CourseProject.Core.Entities;
using CourseProject.EFData;
using CourseProject.EFData.DBContext;
using CourseProject.Services.Services;

namespace UIBank
{
    public partial class ViewCustomerForm : Form
    {
        private Customer _customer;
        private readonly int _customerId;

        public ViewCustomerForm(int customerId)
        {
            InitializeComponent();
            _customerId = customerId;
        }

        private void ViewCustomerForm_Load(object sender, EventArgs e)
        {
            BankContext context = new BankContext(Resources.ConnectionString);
            UnitOfWork unitOfWork = new UnitOfWork(context);
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

            unitOfWork.Dispose();
        }
    }
}
