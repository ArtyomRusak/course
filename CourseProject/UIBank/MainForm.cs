using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseProject.Core.Entities;
using CourseProject.EFData;
using CourseProject.EFData.DBContext;
using CourseProject.Services.Exceptions;
using CourseProject.Services.Services;

namespace UIBank
{
    public partial class MainForm : Form
    {
        private BankContext _context;
        private readonly UnitOfWork _unitOfWork;
        private readonly MembershipService _service;

        public MainForm()
        {
            InitializeComponent();
            _context = new BankContext(Resources.ConnectionString);
            _unitOfWork = new UnitOfWork(_context);
            _service = new MembershipService(_unitOfWork, _unitOfWork);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var context = new BankContext(Resources.ConnectionString);
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

        private void __findCustomer_Click(object sender, EventArgs e)
        {
            if (_tbxFindCustomer.Text == "")
            {
                MessageBox.Show(Resources.FindCustomerError);
                return;
            }
            switch (_cbxSelect.SelectedIndex)
            {
                case 0:
                    {
                        try
                        {
                            var data = _service.GetCustomerByPassportData(_tbxFindCustomer.Text);
                            _customerView.DataSource = new List<Customer> { data };
                        }
                        catch (MembershipServiceException ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }
                        break;
                    }
                case 1:
                    {
                        try
                        {
                            var data = _service.GetCustomersBySurname(_tbxFindCustomer.Text);
                            _customerView.DataSource = data;
                        }
                        catch (MembershipServiceException ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }
                        break;
                    }
            }
        }

        private void _btnAddCustomer_Click(object sender, EventArgs e)
        {
            var form = new AddCustomerForm();
            form.ShowDialog();
            this.MainForm_Load(null, null);
        }

        private void _cbxSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            _tbxFindCustomer.Clear();
        }
    }
}
