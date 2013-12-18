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
using CourseProject.Services;
using CourseProject.Services.Services;

namespace UIBank
{
    public partial class AddAccountForm : Form
    {
        private BankContext _context;
        private readonly UnitOfWork _unitOfWork;
        private readonly CurrencyService _currencyService;

        public AddAccountForm()
        {
            InitializeComponent();
            _context = new BankContext(Resources.ConnectionString);
            _unitOfWork = new UnitOfWork(_context);
            _currencyService = new CurrencyService(_unitOfWork, _unitOfWork);
        }

        private void AddAccountForm_Load(object sender, EventArgs e)
        {
            var currencies = _currencyService.GetCurrencies();
            _cbxCurrencies.Items.AddRange(currencies.Select(w => w.Value).ToArray());
            _cbxCurrencies.SelectedIndex = 0;
        }

        private void _btnCreate_Click(object sender, EventArgs e)
        {
            if (_tbxPassportData.Text == "")
            {
                MessageBox.Show(Resources.EmptyFields);
            }

            var membershipService = new MembershipService(_unitOfWork, _unitOfWork);
            var accountService = new AccountService(_unitOfWork, _unitOfWork);
            var currency = _currencyService.GetCurrencyByValue(_cbxCurrencies.SelectedItem.ToString());

            var customer = membershipService.GetCustomerByPassportData(_tbxPassportData.Text);
            if (customer == null)
            {
                AddCustomerForm form = new AddCustomerForm(_tbxPassportData.Text);
                form.ShowDialog();
            }

            customer = membershipService.GetCustomerByPassportData(_tbxPassportData.Text);
            accountService.CreateAccount((double) _nudSummary.Value, customer.Id, currency.Id);
            _unitOfWork.Dispose();
            this.Close();
        }

        private void AddAccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _unitOfWork.Dispose();
        }
    }
}
