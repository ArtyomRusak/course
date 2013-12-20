﻿using System;
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
using CourseProject.Services.Services;

namespace UIBank
{
    public partial class AddDepositForm : Form
    {
        private BankContext _context;
        private readonly UnitOfWork _unitOfWork;

        public AddDepositForm()
        {
            InitializeComponent();
            _context = new BankContext(Resources.ConnectionString);
            _unitOfWork = new UnitOfWork(_context);
        }

        public AddDepositForm(string passportData)
        {
            InitializeComponent();
            _context = new BankContext(Resources.ConnectionString);
            _unitOfWork = new UnitOfWork(_context);
            _tbxPassportData.Text = passportData;
            _tbxPassportData.ReadOnly = true;
        }

        private void AddDepositForm_Load(object sender, EventArgs e)
        {
            var currencyService = new CurrencyService(_unitOfWork, _unitOfWork);
            var optionDepositService = new OptionDepositService(_unitOfWork, _unitOfWork);
            var currencies = currencyService.GetCurrencies();
            var optionDeposits = optionDepositService.GetOptionDeposits();

            _cbxCurrencies.Items.AddRange(currencies.Select(w => w.Value).ToArray());
            _cbxOptionDeposits.Items.AddRange(optionDeposits.Select(w => w.Name).ToArray());
        }

        private void _btnCreateDeposit_Click(object sender, EventArgs e)
        {
            if (_tbxPassportData.Text == "")
            {
                MessageBox.Show(Resources.EmptyFields);
            }

            var membershipService = new MembershipService(_unitOfWork, _unitOfWork);
            var depositService = new DepositService(_unitOfWork, _unitOfWork);
            var currencyService = new CurrencyService(_unitOfWork, _unitOfWork);
            var optionDepositService = new OptionDepositService(_unitOfWork, _unitOfWork);
            var currency = currencyService.GetCurrencyByValue(_cbxCurrencies.SelectedItem.ToString());
            var optionDeposit = optionDepositService.GetOptionDepositByName(_cbxOptionDeposits.SelectedItem.ToString());

            var customer = membershipService.GetCustomerByPassportData(_tbxPassportData.Text);
            if (customer == null)
            {
                AddCustomerForm form = new AddCustomerForm();
                form.ShowDialog();
                customer = membershipService.GetCustomerByPassportData(_tbxPassportData.Text);
            }

            depositService.CreateDeposit((double) _nudSummary.Value, customer.Id, currency.Id, optionDeposit.Id);
            _unitOfWork.Dispose();
            this.Close();
        }

        private void AddDepositForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _unitOfWork.Dispose();
        }
    }
}