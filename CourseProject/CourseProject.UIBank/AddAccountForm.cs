using System;
using System.Linq;
using System.Windows.Forms;
using CourseProject.EFData;
using CourseProject.EFData.DBContext;
using CourseProject.Services.Services;
using CourseProject.UIBank.Helpers;

namespace CourseProject.UIBank
{
  public partial class AddAccountForm : Form
  {
    private BankContext _context;
    private readonly UnitOfWork _unitOfWork;
    private readonly CurrencyService _currencyService;
    private readonly ValidationHelper _validationHelper;

    public AddAccountForm()
    {
      InitializeComponent();
      _context = new BankContext(Resources.ConnectionString);
      _unitOfWork = new UnitOfWork(_context);
      _currencyService = new CurrencyService(_unitOfWork, _unitOfWork);
      _validationHelper = new ValidationHelper(this.errorProvider1);
    }

    public AddAccountForm(string passportData)
    {
      InitializeComponent();
      _context = new BankContext(Resources.ConnectionString);
      _unitOfWork = new UnitOfWork(_context);
      _currencyService = new CurrencyService(_unitOfWork, _unitOfWork);
      _tbxPassportData.Text = passportData;
      _tbxPassportData.ReadOnly = true;
      _validationHelper = new ValidationHelper(this.errorProvider1);
    }

    private void AddAccountForm_Load(object sender, EventArgs e)
    {
      var currencies = _currencyService.GetCurrencies();
      _cbxCurrencies.Items.AddRange(currencies.Select(w => w.Value).ToArray());
      _cbxCurrencies.SelectedIndex = 0;
    }

    private void _btnCreate_Click(object sender, EventArgs e)
    {
      if (this.ValidateChildren() == false)
      {
        MessageBox.Show("There are validation erros on page.");
        return;
      }

      var membershipService = new MembershipService(_unitOfWork, _unitOfWork);
      var accountService = new AccountService(_unitOfWork, _unitOfWork);
      var currency = _currencyService.GetCurrencyByValue(_cbxCurrencies.SelectedItem.ToString());

      var customer = membershipService.GetCustomerByPassportData(_tbxPassportData.Text);
      if (customer == null)
      {
        var form = new AddCustomerForm(_tbxPassportData.Text);
        form.ShowDialog();
        customer = membershipService.GetCustomerByPassportData(_tbxPassportData.Text);
      }

      accountService.CreateAccount((double)_nudSummary.Value, customer.Id, currency.Id);
      _unitOfWork.Dispose();
      this.Close();
    }

    private void AddAccountForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      _unitOfWork.Dispose();
    }

    private void _tbxPassportData_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
      if (_validationHelper.CheckForEmpty(_tbxPassportData) == false)
      {
        return;
      }

      if (_validationHelper.CheckForRegex(_tbxPassportData, "[A-Z]{2}[0-9]{7}$", "Template for passport don't match. For example - MP3001232") == false)
      {
        return;
      }

      _validationHelper.SetEmptyMessageForErrorProvider(_tbxPassportData);
    }
  }
}
