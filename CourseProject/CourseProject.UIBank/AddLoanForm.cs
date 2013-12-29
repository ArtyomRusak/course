﻿using System;
using System.Linq;
using System.Windows.Forms;
using CourseProject.EFData;
using CourseProject.EFData.DBContext;
using CourseProject.Services.Services;

namespace CourseProject.UIBank
{
    public partial class AddLoanForm : Form
    {
        private readonly BankContext _context;
        private readonly UnitOfWork _unitOfWork;

        public AddLoanForm()
        {
            InitializeComponent();
            _context = new BankContext(Resources.ConnectionString);
            _unitOfWork = new UnitOfWork(_context);
        }

        public AddLoanForm(string passportData)
        {
            InitializeComponent();
            _context = new BankContext(Resources.ConnectionString);
            _unitOfWork = new UnitOfWork(_context);
            _tbxPassportData.Text = passportData;
            _tbxPassportData.ReadOnly = true;
        }

        private void AddLoanForm_Load(object sender, EventArgs e)
        {
            var currencyService = new CurrencyService(_unitOfWork, _unitOfWork);
            var optionLoanService = new OptionLoanService(_unitOfWork, _unitOfWork);
            var currencies = currencyService.GetCurrencies();
            var optionLoans = optionLoanService.GetOptionLoans();

            _cbxCurrencies.Items.AddRange(currencies.Select(w => w.Value).ToArray());
            _cbxOptionLoans.Items.AddRange(optionLoans.Select(w => w.Name).ToArray());
        }

        private void _btnCreateDeposit_Click(object sender, EventArgs e)
        {
            if (_tbxPassportData.Text == "")
            {
                MessageBox.Show(Resources.EmptyFields);
            }

            var membershipService = new MembershipService(_unitOfWork, _unitOfWork);
            var loanService = new LoanService(_unitOfWork, _unitOfWork);
            var currencyService = new CurrencyService(_unitOfWork, _unitOfWork);
            var optionLoanService = new OptionLoanService(_unitOfWork, _unitOfWork);
            var currency = currencyService.GetCurrencyByValue(_cbxCurrencies.SelectedItem.ToString());
            var optionLoan = optionLoanService.GetOptionLoanByName(_cbxOptionLoans.SelectedItem.ToString());

            var customer = membershipService.GetCustomerByPassportData(_tbxPassportData.Text);
            if (customer == null)
            {
                AddCustomerForm form = new AddCustomerForm(_tbxPassportData.Text);
                form.ShowDialog();
                customer = membershipService.GetCustomerByPassportData(_tbxPassportData.Text);
                if (customer == null)
                {
                    MessageBox.Show("Try one more time!");
                    return;
                }
            }

            loanService.CreateLoan((double)_nudSummary.Value, customer.Id, currency.Id, optionLoan.Id);
            _unitOfWork.Commit();
            this.Close();
        }

        private void AddLoanForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.Dispose();
        }
    }
}