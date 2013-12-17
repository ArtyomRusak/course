using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseProject.EFData;
using CourseProject.EFData.DBContext;
using CourseProject.Services.Services;

namespace UIBank
{
    public partial class AddCustomerForm : Form
    {


        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void _btnAddCustomer_Click(object sender, EventArgs e)
        {
            var textBoxs = this.Controls.OfType<TextBox>().ToArray();
            if (textBoxs.Any(textBox => textBox.Text == ""))
            {
                MessageBox.Show(Resources.EmptyFields);
                return;
            }

            var context = new BankContext(Resources.ConnectionString);
            UnitOfWork unitOfWork = new UnitOfWork(context);
            MembershipService membershipService = new MembershipService(unitOfWork, unitOfWork);
            try
            {
                var customer = membershipService.CreateCustomer(_tbxName.Text, _tbxSurname.Text, _tbxPatronymic.Text,
                    _tbxPassportData.Text, _tbxAddress.Text, _dtmpBirthDate.Value);
                unitOfWork.Dispose();
                MessageBox.Show(Resources.CustomerAdded);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
