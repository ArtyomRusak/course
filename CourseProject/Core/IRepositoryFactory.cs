using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.InterfaceRepository;

namespace Core
{
    public interface IRepositoryFactory
    {
        IRepository<Account> GetAccountRepository();
        IRepository<Currency> GetCurrencyRepository();
        IRepository<Customer> GetCustomerRepository();
        IRepository<Deposit> GetDepositRepository();
        IRepository<History> GetHistoryRepository();
        IRepository<Loan> GetLoanRepository();
        IRepository<OptionDeposit> GetOptionDepositRepository();
        IRepository<OptionLoan> GetOptionLoanRepository();
    }
}
