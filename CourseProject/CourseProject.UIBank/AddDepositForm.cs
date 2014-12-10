using System;
using System.Linq;
using System.Windows.Forms;
using CourseProject.EFData;
using CourseProject.EFData.DBContext;
using CourseProject.Services.Services;
using CourseProject.UIBank.Helpers;

namespace CourseProject.UIBank
{
  public partial class AddDepositForm : Form
  {
    private readonly BankContext _context;
    private readonly UnitOfWork _unitOfWork;
    private readonly ValidationHelper _validationHelper;

    public AddDepositForm()
    {
      InitializeComponent();
      _context = new BankContext(Resources.ConnectionString);
      _unitOfWork = new UnitOfWork(_context);
      _validationHelper = new ValidationHelper(this.errorProvider1);
    }

    public AddDepositForm(string passportData)
    {
      InitializeComponent();
      _context = new BankContext(Resources.ConnectionString);
      _unitOfWork = new UnitOfWork(_context);
      _tbxPassportData.Text = passportData;
      _tbxPassportData.ReadOnly = true;
      _validationHelper = new ValidationHelper(this.errorProvider1);
    }

    private void AddDepositForm_Load(object sender, EventArgs e)
    {
      var currencyService = new CurrencyService(_unitOfWork, _unitOfWork);
      var optionDepositService = new OptionDepositService(_unitOfWork, _unitOfWork);
      var currencies = currencyService.GetCurrencies();
      var optionDeposits = optionDepositService.GetOptionDeposits();

      _cbxCurrencies.Items.AddRange(currencies.Select(w => w.Value).ToArray());
      _cbxOptionDeposits.Items.AddRange(optionDeposits.Select(w => w.Name).ToArray());

      _cbxCurrencies.SelectedIndex = 0;
      _cbxOptionDeposits.SelectedIndex = 0;
    }

    private void _btnCreateDeposit_Click(object sender, EventArgs e)
    {
      if (this.ValidateChildren())
      {
        MessageBox.Show("There are validation erros on page.");
        return;
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
        var form = new AddCustomerForm(_tbxPassportData.Text);
        form.ShowDialog();
        customer = membershipService.GetCustomerByPassportData(_tbxPassportData.Text);
        if (customer == null)
        {
          MessageBox.Show("Try one more time!");
          return;
        }
      }

      depositService.CreateDeposit((double)_nudSummary.Value, customer.Id, currency.Id, optionDeposit.Id);
      _unitOfWork.Commit();
      this.Close();
    }

    private void AddDepositForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      _context.Dispose();
    }

    private void _tbxPassportData_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
      if (_validationHelper.CheckForEmpty(_tbxPassportData) == false)
      {
        return;
      }

      if (_validationHelper.CheckForRegex(_tbxPassportData, "[A-Z]{2}[0-9]{7}", "Template for passport don't match. For example - MP3001232") == false)
      {
        return;
      }

      _validationHelper.SetEmptyMessageForErrorProvider(_tbxPassportData);
    }
  }
}
