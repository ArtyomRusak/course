using System;
using System.Linq;
using System.Net.Mime;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CourseProject.EFData;
using CourseProject.EFData.DBContext;
using CourseProject.Services.Exceptions;
using CourseProject.Services.Services;
using CourseProject.UIBank.Helpers;

namespace CourseProject.UIBank
{
    public partial class AddCustomerForm : Form
    {
        private string _passportData;
        private readonly BankContext _context;
        private ValidationHelper _validationHelper;

        public AddCustomerForm()
        {
            InitializeComponent();
            _context = new BankContext(Resources.ConnectionString);
            _validationHelper = new ValidationHelper(this.errorProvider1);
        }

        public AddCustomerForm(string passportData)
        {
            InitializeComponent();
            _context = new BankContext(Resources.ConnectionString);
            _passportData = passportData;
            _tbxPassportData.Text = passportData;
            _tbxPassportData.ReadOnly = true;
            _validationHelper = new ValidationHelper(this.errorProvider1);
        }

        private void _btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                MessageBox.Show("There are validation errors on page.");
                return;
            }

            var unitOfWork = new UnitOfWork(_context);
            var membershipService = new MembershipService(unitOfWork, unitOfWork);

            try
            {
                membershipService.CreateCustomer(_tbxName.Text, _tbxSurname.Text, _tbxPatronymic.Text,
                    _tbxPassportData.Text, _tbxAddress.Text, _dtmpBirthDate.Value);
                unitOfWork.Commit();
                MessageBox.Show(Resources.CustomerAdded);
                this.Close();
            }
            catch (ServiceException ex)
            {
                unitOfWork.Rollback();
                MessageBox.Show("There is a customer with those passport data.");
                return;
            }
        }

        private void AddCustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.Dispose();
        }

        private void _tbxName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (_validationHelper.CheckForEmpty(_tbxName) == false)
            {
                return;
            }

            if (
                _validationHelper.CheckForRegex(_tbxName, "[a-zA-z]{0, 10}",
                    "Name must not contain special symbols, numbers and have length more than 10 symbols") == false)
            {
                return;
            }

            _validationHelper.SetEmptyMessageForErrorProvider(_tbxName);
        }

        private void _tbxSurname_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (_validationHelper.CheckForEmpty(_tbxSurname) == false)
            {
                return;
            }

            if (
                _validationHelper.CheckForRegex(_tbxSurname, "[a-zA-Z]{0, 40}",
                    "Surname must not contain special symbols, numbers and have length more than 40 symbols") == false)
            {
                this.errorProvider1.SetError(_tbxSurname, "Name can't have special symbols and numbers");
                return;
            }

            _validationHelper.SetEmptyMessageForErrorProvider(_tbxSurname);
        }

        private void _tbxPatronymic_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (_validationHelper.CheckForEmpty(_tbxPatronymic) == false)
            {
                return;
            }

            if (
                _validationHelper.CheckForRegex(_tbxPatronymic, "[a-zA-Z]{0, 40}",
                    "Patronymic must not contain special symbols, numbers and have length more than 40 symbols") ==
                false)
            {
                return;
            }

            _validationHelper.SetEmptyMessageForErrorProvider(_tbxPatronymic);
        }

        private void _tbxPassportData_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (_validationHelper.CheckForEmpty(_tbxPassportData) == false)
            {
                return;
            }

            if (
                _validationHelper.CheckForRegex(_tbxPassportData, "[A-Z]{2}[0-9]{7}",
                    "Template for passport don't match. For example - MP3001232") == false)
            {
                return;
            }

            _validationHelper.SetEmptyMessageForErrorProvider(_tbxPassportData);
        }

        private void _dtmpBirthDate_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (_dtmpBirthDate.Value > DateTime.Now)
            {
                this.errorProvider1.SetError(_dtmpBirthDate, "Wrong data");
            }

            this.errorProvider1.SetError(_dtmpBirthDate, String.Empty);
        }

        private void _tbxAddress_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (_validationHelper.CheckForEmpty(_tbxAddress) == false)
            {
                return;
            }

            if (_validationHelper.CheckForLength(_tbxAddress, 100) == false)
            {
                return;
            }

            _validationHelper.SetEmptyMessageForErrorProvider(_tbxAddress);
        }
    }
}