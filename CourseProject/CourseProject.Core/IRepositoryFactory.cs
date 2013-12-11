using CourseProject.Core.Entities;
using CourseProject.Core.InterfaceRepository;

namespace CourseProject.Core
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
