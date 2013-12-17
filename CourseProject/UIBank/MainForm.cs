using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseProject.EFData;
using CourseProject.EFData.DBContext;
using CourseProject.Services.Services;

namespace UIBank
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var context = new BankContext(Resources.ConectionString);
            var unitOfWork = new UnitOfWork(context);
            var loanService = new LoanService(unitOfWork, unitOfWork);
            var accountService = new AccountService(unitOfWork, unitOfWork);
            var depositService = new DepositService(unitOfWork, unitOfWork);
            var membershipService = new MembershipService(unitOfWork, unitOfWork);

            int countOfLoans = loanService.GetCountOfAllLoans();
            int countOfAccounts = accountService.GetCountOfAllAccounts();
            int countOfDeposits = depositService.GetCountOfAllDeposits();
            int countOfCustomers = membershipService.GetCountOfAllCustomers();

            this._lblLoans.Text = String.Format("Count of loans - {0}", countOfLoans.ToString());
            this._lblCustomers.Text = String.Format("Count of customers - {0}", countOfCustomers.ToString());
            this._lblDeposits.Text = String.Format("Count of deposits - {0}", countOfDeposits.ToString());
            this._lblAccounts.Text = String.Format("Count of accounts - {0}", countOfAccounts.ToString());

            this._cbxSelect.SelectedIndex = 0;
            unitOfWork.Dispose();
        }
    }
}
