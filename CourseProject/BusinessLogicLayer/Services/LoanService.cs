using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.Exceptions;
using Core;
using Core.Entities;
using Infrastructure.Guard.Validation;

namespace BusinessLogicLayer.Services
{
    public class LoanService : IService
    {
        #region [Private members]

        private IUnitOfWork _unitOfWork;
        private readonly IRepositoryFactory _factoryOfRepositories;

        #endregion


        #region [Ctor's]

        public LoanService(IUnitOfWork unitOfWork, IRepositoryFactory factoryOfRepositories)
        {
            Guard.AgainstNullReference(unitOfWork, "unitOfWork");
            Guard.AgainstNullReference(factoryOfRepositories, "factoryOfRepositories");

            _unitOfWork = unitOfWork;
            _factoryOfRepositories = factoryOfRepositories;
        }

        #endregion


        #region [LoanService's members]

        public Loan CreateLoan(double startSummary, int customerId, int currencyId, int optionLoanId)
        {
            Guard.AgainstNegatives((int) startSummary);

            var loan = new Loan
            {
                OpeningSummary = startSummary,
                Summary = startSummary,
                CreateDate = DateTime.Now,
                CustomerId = customerId,
                CurrencyId = currencyId,
                OptionLoanId = optionLoanId
            };

            var loanRepository = _factoryOfRepositories.GetLoanRepository();
            loanRepository.Create(loan);

            try
            {
                _unitOfWork.PreSave();
            }
            catch (Exception exception)
            {
                throw new ServiceException(exception);
            }

            return loan;
        }

        public void UpdateLoan(Loan loan)
        {
            var loanRepository = _factoryOfRepositories.GetLoanRepository();
            try
            {
                loanRepository.Update(loan);
            }
            catch (Exception ex)
            {
                throw new LoanServiceException(ex);
            }
        }

        public void RemoveLoan(Loan loan)
        {
            var loanRepository = _factoryOfRepositories.GetLoanRepository();
            try
            {
                loanRepository.Remove(loan);
            }
            catch (Exception ex)
            {
                throw new LoanServiceException(ex);
            }
        }

        public Loan GetLoanById(int loanId)
        {
            var loanRepository = _factoryOfRepositories.GetLoanRepository();
            try
            {
                return loanRepository.GetEntityById(loanId);
            }
            catch (Exception ex)
            {
                
                throw new LoanServiceException(ex);
            }
        }

        public List<Loan> GetLoansByCustomerId(int customerId)
        {
            var loanRepository = _factoryOfRepositories.GetLoanRepository();
            return loanRepository.Filter(e => e.CustomerId == customerId).ToList();
        }

        public int GetCountOfAllLoans()
        {
            var loanRepository = _factoryOfRepositories.GetLoanRepository();
            return loanRepository.All().Count();
        }

        #endregion

    }
}
