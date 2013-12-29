using System;
using System.Linq;
using System.Windows.Forms;
using CourseProject.EFData;
using CourseProject.EFData.DBContext;
using CourseProject.Services.Exceptions;
using CourseProject.Services.Services;

namespace CourseProject.UIBank
{
    public partial class AddCustomerForm : Form
    {
        private string _passportData;
        private readonly BankContext _context;

        public AddCustomerForm()
        {
            InitializeComponent();
            _context = new BankContext(Resources.ConnectionString);
        }

        public AddCustomerForm(string passportData)
        {
            InitializeComponent();
            _context = new BankContext(Resources.ConnectionString);
            _passportData = passportData;
            _tbxPassportData.Text = passportData;
            _tbxPassportData.ReadOnly = true;
        }

        private void _btnAddCustomer_Click(object sender, EventArgs e)
        {
            var textBoxs = this.Controls.OfType<TextBox>().ToArray();
            if (textBoxs.Any(textBox => textBox.Text == ""))
            {
                MessageBox.Show(Resources.EmptyFields);
                return;
            }
            if (_dtmpBirthDate.Value > DateTime.Now)
            {
                MessageBox.Show(Resources.WrongBirthDateValue);
                return;
            }

            var unitOfWork = new UnitOfWork(_context);
            var membershipService = new MembershipService(unitOfWork, unitOfWork);

            try
            {
                var customer = membershipService.CreateCustomer(_tbxName.Text, _tbxSurname.Text, _tbxPatronymic.Text,
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
    }
}
