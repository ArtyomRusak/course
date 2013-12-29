using System.Collections.Generic;
using System.Linq;
using CourseProject.Core;
using CourseProject.Core.Entities;
using CourseProject.Core.Exceptions;
using CourseProject.Infrastructure.Guard.Validation;
using CourseProject.Services.Exceptions;

namespace CourseProject.Services.Services
{
    public class OptionLoanService : IService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepositoryFactory _factoryOfRepositories;

        public OptionLoanService(IUnitOfWork unitOfWork, IRepositoryFactory factoryOfRepositories)
        {
            Guard.AgainstNullReference(unitOfWork, "unitOfWork");
            Guard.AgainstNullReference(factoryOfRepositories, "factoryOfRepositories");

            _unitOfWork = unitOfWork;
            _factoryOfRepositories = factoryOfRepositories;
        }

        public List<OptionLoan> GetOptionLoans()
        {
            var optionLoanRepository = _factoryOfRepositories.GetOptionLoanRepository();
            return optionLoanRepository.All().ToList();
        }

        public OptionLoan GetOptionLoanByName(string name)
        {
            var optionLoanRepository = _factoryOfRepositories.GetOptionLoanRepository();
            try
            {
                return optionLoanRepository.Find(e => e.Name == name);
            }
            catch (RepositoryException e)
            {
                throw new OptionLoanServiceException(e.Message);
            }
        }
    }
}
