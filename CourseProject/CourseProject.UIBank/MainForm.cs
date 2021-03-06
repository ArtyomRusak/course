﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CourseProject.Core.Entities;
using CourseProject.EFData;
using CourseProject.EFData.DBContext;
using CourseProject.Services.Exceptions;
using CourseProject.Services.Services;

namespace CourseProject.UIBank
{
    public partial class MainForm : Form
    {
        private readonly BankContext _context;

        public MainForm()
        {
            InitializeComponent();
            _context = new BankContext(Resources.ConnectionString);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var unitOfWork = new UnitOfWork(_context);
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

            var deposits = depositService.GetAllDeposits().ToList();
            var loans = loanService.GetAllLoans().ToList();

            foreach (var deposit in deposits)
            {
                deposit.Summary = deposit.OpeningSummary + deposit.Calculate(DateTime.Now);
                depositService.UpdateDeposit(deposit);
            }
            foreach (var loan in loans)
            {
                loan.Summary = loan.OpeningSummary + loan.Calculate(DateTime.Now);
                loanService.UpdateLoan(loan);
            }


            _dgvCustomers.DataSource = null;
            _tbxFindCustomer.Text = "";

            this._cbxSelect.SelectedIndex = 0;
            unitOfWork.Commit();
        }

        private void __findCustomer_Click(object sender, EventArgs e)
        {
            var unitOfWork = new UnitOfWork(_context);
            var membershipService = new MembershipService(unitOfWork, unitOfWork);

            if (_tbxFindCustomer.Text == "")
            {
                var data = membershipService.GetAllCustomers();
                _dgvCustomers.DataSource = data;
                unitOfWork.Commit();
                return;
            }

            switch (_cbxSelect.SelectedIndex)
            {
                case 0:
                    {
                        try
                        {
                            var data = membershipService.GetCustomersBySurname(_tbxFindCustomer.Text);
                            _dgvCustomers.DataSource = data;
                            unitOfWork.Commit();
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
                            var data = membershipService.GetCustomerByPassportData(_tbxFindCustomer.Text);
                            _dgvCustomers.DataSource = new List<Customer> { data };
                            unitOfWork.Commit();
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

        private void _btnAddDeposit_Click(object sender, EventArgs e)
        {
            AddDepositForm form = new AddDepositForm();
            form.ShowDialog();
            this.MainForm_Load(null, null);
        }

        private void _btnAddLoan_Click(object sender, EventArgs e)
        {
            AddLoanForm form = new AddLoanForm();
            form.ShowDialog();
            this.MainForm_Load(null, null);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.Dispose();
        }
    }
}
