using System;
using System.Collections.Generic;
using System.Linq;
using CourseProject.Core;
using CourseProject.Core.Entities;
using CourseProject.Infrastructure.Guard.Validation;
using CourseProject.Services.Exceptions;

namespace CourseProject.Services.Services
{
    public class LoanService : IService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepositoryFactory _factoryOfRepositories;

        public LoanService(IUnitOfWork unitOfWork, IRepositoryFactory factoryOfRepositories)
        {
            Guard.AgainstNullReference(unitOfWork, "unitOfWork");
            Guard.AgainstNullReference(factoryOfRepositories, "factoryOfRepositories");

            _unitOfWork = unitOfWork;
            _factoryOfRepositories = factoryOfRepositories;
        }

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

        public IQueryable<Loan> GetAllLoans()
        {
            var loanRepository = _factoryOfRepositories.GetLoanRepository();
            return loanRepository.All();
        }
    }
}
