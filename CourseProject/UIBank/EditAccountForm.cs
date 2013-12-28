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
using CourseProject.Infrastructure.Guard.Validation;
using CourseProject.Services.Exceptions;
using CourseProject.Services.Services;

namespace UIBank
{
    public partial class EditAccountForm : Form
    {
        private readonly int _accountId;
        private Account _account;
        private readonly BankContext _context;

        public EditAccountForm(int accountId)
        {
            InitializeComponent();
            _accountId = accountId;
            _context = new BankContext(Resources.ConnectionString);
        }

        private void EditAccountForm_Load(object sender, EventArgs e)
        {
            var unitOfWork = new UnitOfWork(_context);
            var accountService = new AccountService(unitOfWork, unitOfWork);
            _account = accountService.GetAccountById(_accountId);
            _tbxSummary.Text = _account.Summary.ToString();
            _lblAccountId.Text = String.Format("Customer - {0}. ID of this account - {1}",
                String.Format("{0} {1} {2}", _account.Customer.Surname, _account.Customer.Name,
                    _account.Customer.Patronymic), _account.Id);
            _cbxSelect.SelectedIndex = 0;

            unitOfWork.Commit();
        }

        private void EditAccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.Dispose();
        }

        private void _btnFindAccounts_Click(object sender, EventArgs e)
        {
            if (_tbxFindAccount.Text == "")
            {
                MessageBox.Show(Resources.FindAccountError);
                return;
            }

            var unitOfWork = new UnitOfWork(_context);
            var accountService = new AccountService(unitOfWork, unitOfWork);

            switch (_cbxSelect.SelectedIndex)
            {
                case 0:
                    {
                        try
                        {
                            var accounts =
                                accountService.GetAccountsByPassportData(_tbxFindAccount.Text)
                                    .Where(w => w.Currency.Value == _account.Currency.Value).ToList();
                            _dgvAccounts.DataSource = accounts;
                            unitOfWork.Commit();
                        }
                        catch (AccountServiceException ex)
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
                            var accounts = accountService.GetAccountById(int.Parse(_tbxFindAccount.Text));

                            if (accounts.Currency.Value != _account.Currency.Value)
                            {
                                accounts = null;
                            }

                            _dgvAccounts.DataSource = new List<Account> { accounts };
                            unitOfWork.Commit();
                        }
                        catch (AccountServiceException ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }
                        break;
                    }
                case 2:
                    {
                        try
                        {
                            var accounts = accountService.GetAccountByCustomerSurname(_tbxFindAccount.Text)
                                .Where(w => w.Currency.Value == _account.Currency.Value).ToList();
                            _dgvAccounts.DataSource = accounts;
                            unitOfWork.Commit();
                        }
                        catch (AccountServiceException ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }
                        break;
                    }
            }
        }

        private void _btnAdd_Click(object sender, EventArgs e)
        {
            var unitOfWork = new UnitOfWork(_context);
            var accountService = new AccountService(unitOfWork, unitOfWork);

            var confirmMessage = MessageBox.Show(String.Format("Would you really want to add {0} {1} to account?", _nudSummary.Value, _account.Currency.Value),
                "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (confirmMessage.ToString() == "OK")
            {
                _account.Summary += (double)_nudSummary.Value;
                accountService.UpdateAccount(_account);

                unitOfWork.Commit();

                _tbxSummary.Text = _account.Summary.ToString();
                _nudSummary.Value = 0;
            }
            else
            {
                unitOfWork.Commit();
                return;
            }
        }

        private void _btnLower_Click(object sender, EventArgs e)
        {
            var unitOfWork = new UnitOfWork(_context);
            var accountService = new AccountService(unitOfWork, unitOfWork);

            var confirmMessage = MessageBox.Show(String.Format("Would you really want to take {0} {1} from account?", _nudSummary.Value, _account.Currency.Value),
                "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (confirmMessage.ToString() == "OK")
            {
                try
                {
                    Guard.AgainstIsLessThan(_account.Summary - (double)_nudSummary.Value, 0);
                    _account.Summary -= (double)_nudSummary.Value;
                    accountService.UpdateAccount(_account);

                    unitOfWork.Commit();

                    _tbxSummary.Text = _account.Summary.ToString();
                    _nudSummary.Value = 0;
                }
                catch (ArgumentException argumentException)
                {
                    MessageBox.Show(Resources.LowCashError);
                    unitOfWork.Rollback();
                    return;
                }
                catch (AccountServiceException ex)
                {
                    MessageBox.Show(ex.Message);
                    unitOfWork.Rollback();
                    return;
                }
            }
            else
            {
                unitOfWork.Commit();
                return;
            }
        }

        private void _btnTransact_Click(object sender, EventArgs e)
        {
            var unitOfWork = new UnitOfWork(_context);
            var accountService = new AccountService(unitOfWork, unitOfWork);

            var confirmMessage = MessageBox.Show(String.Format("Would you really want to transact {0} {1} from this account to another account?", _nudSummaryTransact.Value, _account.Currency.Value),
                "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (confirmMessage.ToString() == "OK")
            {
                try
                {
                    var accountToTakeId = int.Parse(_dgvAccounts[0, _dgvAccounts.CurrentCell.RowIndex].Value.ToString());
                    Guard.AgainstIsLessThan(_account.Summary - (double)_nudSummaryTransact.Value, 0);
                    Guard.AgainstEqualityOfValues(accountToTakeId, _account.Id,
                        new Exception("Can not transact to same accounts!"));

                    var accountToTake = accountService.GetAccountById(accountToTakeId);

                    _account.Summary -= (double)_nudSummaryTransact.Value;
                    accountToTake.Summary += (double)_nudSummaryTransact.Value;

                    accountService.UpdateAccount(_account);
                    accountService.UpdateAccount(accountToTake);

                    unitOfWork.Commit();

                    _tbxSummary.Text = _account.Summary.ToString();
                    _dgvAccounts.DataSource = new List<Account> { accountToTake };

                    MessageBox.Show("Successfully!");
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(Resources.LowCashError);
                    unitOfWork.Rollback();
                    return;
                }
                catch (AccountServiceException ex)
                {
                    MessageBox.Show(ex.Message);
                    unitOfWork.Rollback();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            else
            {
                unitOfWork.Commit();
                return;
            }
        }

        private void _btnAnnul_Click(object sender, EventArgs e)
        {
            var unitOfWork = new UnitOfWork(_context);
            var accountService = new AccountService(unitOfWork, unitOfWork);

            try
            {
                _account.Summary = 0;
                accountService.UpdateAccount(_account);
                unitOfWork.Commit();
                _tbxSummary.Text = "0";
                MessageBox.Show("Done!");
                return;
            }
            catch (AccountServiceException accountServiceException)
            {
                MessageBox.Show(accountServiceException.Message);
                unitOfWork.Rollback();
                return;
            }
        }
    }
}
