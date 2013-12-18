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
        public MainForm()
        {
            InitializeComponent();
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

            _dgvCustomers.DataSource = null;
            _tbxFindCustomer.Text = "";

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
            var context = new BankContext(Resources.ConnectionString);
            UnitOfWork unitOfWork = new UnitOfWork(context);
            var membershipService = new MembershipService(unitOfWork, unitOfWork);
            switch (_cbxSelect.SelectedIndex)
            {
                case 0:
                    {
                        try
                        {
                            var data = membershipService.GetCustomerByPassportData(_tbxFindCustomer.Text);
                            _dgvCustomers.DataSource = new List<Customer> { data };
                            unitOfWork.Dispose();
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
                            var data = membershipService.GetCustomersBySurname(_tbxFindCustomer.Text);
                            _dgvCustomers.DataSource = data;
                            unitOfWork.Dispose();
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

        private void _customerView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int customerId = int.Parse(_dgvCustomers.Rows[e.RowIndex].Cells[0].Value.ToString());
            ViewCustomerForm form = new ViewCustomerForm(customerId);
            form.ShowDialog();
            this.MainForm_Load(null, null);
        }

        private void _btnAddAccount_Click(object sender, EventArgs e)
        {
            AddAccountForm form = new AddAccountForm();
            form.ShowDialog();
            this.MainForm_Load(null, null);
        }
    }
}
